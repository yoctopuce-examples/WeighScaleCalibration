using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using YDataRendering;

namespace HiSpeed2D
{


    public partial class Form1 : Form
    {
        const int maxPoints = 500000;
        const double learningRate = 0.002;
        const int nIterations = 10000;

        int count;
        int learnCount;
        int prevProgress;
        double aRatio, alpha, bRatio, beta, autoOffset;
        double[] stamp, temp, rawW, avgTemp, deltaTemp, pred;
        double avgSqError;
        bool disable_textChangeEvents;

        YGraph chart;
        DataSerie tempData;
        DataSerie avgTempData;
        DataSerie deltaTempData;
        DataSerie rawWData;
        DataSerie predData;
        DataSerie errorData;

        public Form1()
        {
            InitializeComponent();
            chart = new YGraph(pictureBox1, log);
            stamp = new double[maxPoints];
            temp = new double[maxPoints];
            rawW = new double[maxPoints];
            avgTemp = new double[maxPoints];
            deltaTemp = new double[maxPoints];
            pred = new double[maxPoints];

            YAxis s0 = chart.addYAxis();
            s0.showGrid = true;
            YAxis s1 = chart.addYAxis();
            s1.position = YAxis.HrzPosition.RIGHT;

            chart.navigator.enabled = true;
            chart.navigator.relativeheight = 10;
            chart.xAxis.showGrid = true;
            chart.legendPanel.enabled = true;
            chart.dataTracker.enabled = true;
            chart.navigator.yAxisHandling = Navigator.YAxisHandling.INHERIT;

            openFileDialog1.ShowDialog();
        }

        public void log(string msg)
        {
            logBox.AppendText(msg + "\r\n");
        }

        public void loadFile(string fname)
        {
            FileInfo fileInfo = new FileInfo(fname);
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            CultureInfo culture = CultureInfo.InvariantCulture;
            count = 0;

            using (var reader = new StreamReader(fname))
            {
                while (!reader.EndOfStream && count < maxPoints)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if (values.Length < 3) break;
                    if (values[0].Contains("stamp")) continue;
                    stamp[count] = (DateTime.ParseExact(values[0], "yyyy.MM.dd HH:mm:ss.ff", culture) - epoch).TotalSeconds;
                    temp[count] = float.Parse(values[1], culture);
                    rawW[count] = float.Parse(values[2], culture);
                    count++;
                }
            }
            if(count < 100)
            {
                count = 0;
                disable_textChangeEvents = true;
                dialogTitle.Text = "Invalid file";
                errorMessage.Text = "CSV file with at least 100 lines and 3 columns expected";
                errorMessage.Visible = true;
                progressBar.Visible = false;
                dialogButton.Text = "Close";
                dialogPanel.Visible = true;
                return;
            }
            fileName.Text = fileInfo.Name;
            count -= 24;
            learnCount = 3 * count / 4;
            disable_textChangeEvents = false;

            chart.DisableRedraw();
            tempData = chart.addSerie();
            avgTempData = chart.addSerie();
            deltaTempData = chart.addSerie();
            rawWData = chart.addSerie();
            predData = chart.addSerie();
            errorData = chart.addSerie();
            for (int i = 0; i < count; i++)
            {
                tempData.AddPoint(new pointXY() { x = stamp[i], y = temp[i] });
                rawWData.AddPoint(new pointXY() { x = stamp[i], y = rawW[i] });
            }
            chart.xAxis.min = stamp[count * 3 / 4];
            chart.xAxis.max = stamp[count-1];
            tempData.legend = "Temperature";
            tempData.color = Color.DarkRed;
            tempData.disabled = !showTemp.Checked;
            avgTempData.legend = "Avg.Temp.";
            avgTempData.color = Color.Red;
            avgTempData.disabled = !showAvg.Checked;
            deltaTempData.legend = "Delta.Temp.";
            deltaTempData.color = Color.DarkOrange;
            deltaTempData.disabled = !showDelta.Checked;
            rawWData.legend = "Zero Drift";
            rawWData.color = Color.DarkBlue;
            rawWData.yAxisIndex = 1;
            rawWData.disabled = !showRawW.Checked;
            predData.legend = "Pred.Drift";
            predData.color = Color.Blue;
            predData.yAxisIndex = 1;
            predData.disabled = !showPrediction.Checked;
            errorData.legend = "Residual Error";
            errorData.color = Color.Black;
            errorData.yAxisIndex = 1;
            errorData.disabled = !showError.Checked;
            chart.AllowRedraw();

            this.optimizeDeltaRate();
        }

        /*****************************************************************************************
         * 
         *         Estimation of temperature change compensation parameters
         * 
         *****************************************************************************************/

        private void optimizeDeltaRate()
        {
            if (tempChangeWorker.IsBusy)
            {
                tempChangeWorker.CancelAsync();
            }
            else
            {
                if (count == 0) return;
                prevProgress = -1;
                progressBar.Value = 0;
                progressBar.Visible = true;
                errorMessage.Visible = false;
                dialogTitle.Text = "Analyzing data...";
                dialogButton.Text = "Abort";
                dialogPanel.Visible = true;
                disable_textChangeEvents = true;
                tempChangeWorker.RunWorkerAsync();
                autoDelta.Text = "Stop";
            }
        }

        private void tempChangeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            double step, bestRatio, bestSqError;

            // Split the space in ten slices to find the initial guess (important for convergence)
            bRatio = 1.00001;
            step = 0.1;
            this.recomputeDeltaTemp(false);
            bestRatio = bRatio;
            bestSqError = avgSqError;
            for (int depth = 0; depth <= 4; depth++)
            {
                for (int i = 0; i <= 10; i++)
                {
                    worker.ReportProgress(20 * depth + 2 * i);
                    this.recomputeDeltaTemp(false);
                    if (avgSqError < bestSqError)
                    {
                        bestRatio = bRatio;
                        bestSqError = avgSqError;
                    }
                    bRatio -= step;
                }
                if (worker.CancellationPending)
                {
                    bRatio = bestRatio;
                    this.recomputeDeltaTemp(false);
                    e.Cancel = true;
                    return;
                }
                bRatio = bestRatio + step;
                step *= 0.2;
            }
            bRatio = bestRatio;
            this.recomputeDeltaTemp(false);
        }

        private void tempChangeWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            deltaRatio.Text = (Math.Round(bRatio * 100000) / 100000).ToString();
            avgRatio.Text = (Math.Round(aRatio * 100000) / 100000).ToString();
            rmsError.Text = (Math.Round(Math.Sqrt(avgSqError) * 10000) / 10000).ToString();
        }

        private void tempChangeWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            disable_textChangeEvents = false;
            dialogPanel.Visible = false;
            deltaRatio.Text = (Math.Round(bRatio * 100000) / 100000).ToString();
            autoDelta.Text = "Reset";
        }

        public void recomputeDeltaTemp(bool refresh)
        {
            if (refresh) chart.DisableRedraw();
            if (refresh) deltaTempData.clear();

            double ratio = bRatio * 0.01;
            double compt = temp[0];
            for (int i = 1; i < count; i++)
            {
                double dt = temp[i] - compt;
                compt += ratio * dt;
                deltaTemp[i] = dt;
                if (refresh) deltaTempData.AddPoint(new pointXY() { x = stamp[i], y = deltaTemp[i] });
            }
            this.estimateBeta();
            this.estimateAvgRate(refresh);
            this.recomputeAvgTemp(refresh);

            if (refresh) chart.AllowRedraw();
        }

        private void estimateBeta()
        {
            // Estimate deltaScale by assuming that deltaTemp derivative equals Zero Drift derivative
            // (so their sum of squares should be the same).
            // Derivatîve is estimated by comparing with 4 min. before
            double drawSq = 0, dtempSq = 0;
            int sameSign = 0;
            for (int i = 25; i < learnCount; i++)
            {
                double draw = rawW[i] - rawW[i - 24];
                double dtemp = deltaTemp[i] - deltaTemp[i - 24];
                drawSq += draw * draw;
                dtempSq += dtemp * dtemp;
                sameSign += ((draw < 0) == (dtemp < 0) ? 1 : -1);
            }
            double stdDev = Math.Sqrt(drawSq / dtempSq);
            beta = (sameSign < 0 ? -1 : 1) * stdDev;
        }


        /*****************************************************************************************
         * 
         *           Estimation of average temperature compensation parameters
         * 
         *****************************************************************************************/

        private void estimateAvgRate(bool refresh)
        {
            aRatio = bRatio;
            this.recomputeAvgTemp(false);
            double prevError = avgSqError;
            double step = Math.Pow(10, Math.Ceiling(Math.Log10(bRatio / 10)));
            while (step >= 0.0002)
            {
                for (int i = 0; i < 10 && step < aRatio; i++)
                {
                    aRatio -= step;
                    this.recomputeAvgTemp(false);
                    if (avgSqError > prevError)
                    {
                        aRatio += 2 * step;
                        this.recomputeAvgTemp(false);
                        prevError = avgSqError;
                        break;
                    }
                    prevError = avgSqError;
                }
                step = step * 0.2;
            }
            if(refresh)
            {
                avgRatio.Text = (Math.Round(aRatio * 100000) / 100000).ToString();
            } else
            {
                this.recomputeAvgTemp(false);
            }
        }

        public void recomputeAvgTemp(bool refresh)
        {
            if (refresh) chart.DisableRedraw();
            if (refresh) avgTempData.clear();

            double ratio = aRatio * 0.01;
            double compt = temp[0];
            for (int i = 1; i < count; i++)
            {
                double dt = temp[i] - compt;
                compt += ratio * dt;
                avgTemp[i] = compt;
                if (refresh) avgTempData.AddPoint(new pointXY() { x = stamp[i], y = avgTemp[i] });
            }
            this.estimateAlpha();
            this.estimateOffset(refresh);

            if (refresh) chart.AllowRedraw();
        }

        private void estimateAlpha()
        {
            // Estimate avgScale by assuming that non-constant part of the residual error is due to it
            // (so their variance should be the same).
            double ratio = aRatio * 0.01;
            double errSumSq = 0, errSum = 0;
            double tempSumSq = 0, tempSum = 0;
            int sameSign = 0;
            double compt = temp[0];
            for (int i = 0; i < 25; i++)
            {
                double dt = temp[i] - compt;
                compt += ratio * dt;
            }
            for (int i = 25; i < learnCount; i++)
            {
                double dt = temp[i] - compt;
                compt += ratio * dt;
                double err = rawW[i] - beta * deltaTemp[i];
                errSumSq += err * err;
                errSum += err;
                tempSumSq += compt * compt;
                tempSum += compt;
                sameSign += ((err < 0) == (compt < 0) ? 1 : -1);
            }
            double errSq = errSumSq / (learnCount - 25);
            double errAvg = errSum / (learnCount - 25);
            double tempSq = tempSumSq / (learnCount - 25);
            double tempAvg = tempSum / (learnCount - 25);
            double errStdDev = Math.Sqrt(errSq - errAvg * errAvg);
            double tempStdDev = Math.Sqrt(tempSq - tempAvg * tempAvg);
            alpha = (sameSign < 0 ? -1 : 1) * errStdDev / tempStdDev;
        }

        /*****************************************************************************************
         * 
         *          Computation of tare offset, RMS error and compensation table parameters
         * 
         *****************************************************************************************/

        private void estimateOffset(bool refresh)
        {
            // Estimate tare by minimizing RMS error for current parameters
            autoOffset = 0;

            this.recomputeError(false);
            double dOffset = 0;
            for (int i = 1; i < learnCount; i++)
            {
                dOffset += rawW[i] - pred[i];
            }
            autoOffset = dOffset / (learnCount - 1);
            if(refresh) updateCompensationTable();
            this.recomputeError(refresh);
        }

        public void recomputeError(bool refresh)
        {
            double sumSq = 0;

            for (int i = 1; i < count; i++)
            {
                pred[i] = alpha * avgTemp[i] + beta * deltaTemp[i] + autoOffset;
                sumSq += (rawW[i] - pred[i]) * (rawW[i] - pred[i]);
            }
            avgSqError = sumSq / (count - 1);

            if (refresh)
            {
                rmsError.Text = (Math.Round(Math.Sqrt(avgSqError) * 10000) / 10000).ToString();
                chart.DisableRedraw();
                predData.clear();
                errorData.clear();
                if (deriv.Checked)
                {
                    for (int i = 25; i < count; i++)
                    {
                        predData.AddPoint(new pointXY() { x = stamp[i], y = pred[i] - pred[i - 24] });
                    }
                } else
                {
                    for (int i = 1; i < count; i++)
                    {
                        predData.AddPoint(new pointXY() { x = stamp[i], y = pred[i] });
                    }
                }
                for (int i = 1; i < count; i++)
                {
                    errorData.AddPoint(new pointXY() { x = stamp[i], y = rawW[i] - pred[i] });
                }
                chart.AllowRedraw();
            }
        }

        private void updateCompensationTable()
        {
            avgCompMin.Text = (Math.Round((autoOffset - 30 * alpha) * 1000) / 1000).ToString();
            avgCompZero.Text = (Math.Round(autoOffset * 1000) / 1000).ToString();
            avgCompMax.Text = (Math.Round((autoOffset + 100 * alpha) * 1000) / 1000).ToString();
            deltaCompMin.Text = (Math.Round((0 - 30 * beta) * 1000) / 1000).ToString();
            deltaCompZero.Text = "0";
            deltaCompMax.Text = (Math.Round((0 + 100 * beta) * 1000) / 1000).ToString();
        }

        /*****************************************************************************************
         * 
         *          Misc UI eventhandlers
         * 
         *****************************************************************************************/

        private void showTemp_CheckedChanged(object sender, EventArgs e)
        {
            tempData.disabled = !showTemp.Checked;
        }

        private void showRawW_CheckedChanged(object sender, EventArgs e)
        {
            rawWData.disabled = !showRawW.Checked;
        }

        private void showDelta_CheckedChanged(object sender, EventArgs e)
        {
            deltaTempData.disabled = !showDelta.Checked;
        }

        private void showAvg_CheckedChanged(object sender, EventArgs e)
        {
            avgTempData.disabled = !showAvg.Checked;
        }

        private void showPrediction_CheckedChanged(object sender, EventArgs e)
        {
            predData.disabled = !showPrediction.Checked;
        }

        private void showError_CheckedChanged(object sender, EventArgs e)
        {
            errorData.disabled = !showError.Checked;
        }

        private void deltaRatio_TextChanged(object sender, EventArgs e)
        {
            double newVal;
            if (disable_textChangeEvents) return;
            Double.TryParse(deltaRatio.Text, out newVal);
            if (newVal == 0) return;
            bRatio = newVal;
            int val = (int)(Math.Round(-20 * Math.Log(Math.Abs(bRatio))));
            if (val >= 0 && val <= 200) deltaRatioTrackBar.Value = 100 - val;
            this.recomputeDeltaTemp(true);
        }

        private void deltaRatioTrackBar_Scroll(object sender, EventArgs e)
        {
            int trackVal = deltaRatioTrackBar.Value;
            double absVal = 100 - trackVal;
            bRatio = Math.Round(Math.Exp(-0.05 * absVal) * 100000) / 100000;
            deltaRatio.Text = bRatio.ToString();
        }

        private void avgRatio_TextChanged(object sender, EventArgs e)
        {
            double newVal;
            if (disable_textChangeEvents) return;
            Double.TryParse(avgRatio.Text, out newVal);
            if (newVal == 0) return;
            aRatio = newVal;
            int val = (int)(Math.Round(-20 * Math.Log(Math.Abs(aRatio))));
            if(val >= 0 && val <= 200) avgRatioTrackBar.Value = 100 - val;
            this.recomputeAvgTemp(true);
        }

        private void avgRatioTrackBar_Scroll(object sender, EventArgs e)
        {
            int trackVal = avgRatioTrackBar.Value;
            double absVal = 100 - trackVal;
            aRatio = Math.Round(Math.Exp(-0.05 * absVal) * 100000) / 100000;
            avgRatio.Text = aRatio.ToString();
        }

        private void deriv_CheckedChanged(object sender, EventArgs e)
        {
            chart.DisableRedraw();
            rawWData.clear();
            if (deriv.Checked)
            {
                for (int i = 24; i < count; i++)
                {
                    rawWData.AddPoint(new pointXY() { x = stamp[i], y = rawW[i] - rawW[i - 24] });
                }
            } else
            {
                for (int i = 0; i < count; i++)
                {
                    rawWData.AddPoint(new pointXY() { x = stamp[i], y = rawW[i] });
                }

            }
            this.recomputeError(true);
            chart.AllowRedraw();
        }

        private void autoDelta_Click(object sender, EventArgs e)
        {
            this.optimizeDeltaRate();
        }

        private void autoAvg_Click(object sender, EventArgs e)
        {
            this.estimateAvgRate(true);
        }

        private void fileName_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] files = openFileDialog1.FileNames;
            this.loadFile(files[0]);
        }

        private void dialogButton_Click(object sender, EventArgs e)
        {
            if (tempChangeWorker.IsBusy)
            {
                tempChangeWorker.CancelAsync();
            }
            dialogPanel.Visible = false;
        }

        /*****************************************************************************************
         * 
         * Gradient descent method (not used anymore, does not significantly improve quality)
         * 
         *****************************************************************************************/

        private void gradientDescent_StartStop()
        {
            if (gradientDescentWorker.IsBusy)
            {
                gradientDescentWorker.CancelAsync();
            }
            else
            {
                autoOffset = 0;

                // Setup initial tare to minimize RMS error for current parameters
                this.recomputeError(false);
                double dOffset = 0;
                for (int i = 1; i < learnCount; i++)
                {
                    dOffset += rawW[i] - pred[i];
                }
                autoOffset = dOffset / (learnCount - 1);
                updateCompensationTable();
                this.recomputeError(true);

                prevProgress = -1;
                progressBar.Value = 0;
                progressBar.Visible = true;
                errorMessage.Visible = false;
                dialogTitle.Text = "Analyzing data...";
                dialogButton.Text = "Abort";
                dialogPanel.Visible = true;
                gradientDescentWorker.RunWorkerAsync();
            }
        }

        private void gradientDescent_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            double dOffset, dAvgScale, dDeltaScale;
            double descentFactor = learningRate / (learnCount - 1);
            int reportPeriod = nIterations / 256;

            // perform gradient descent on RMS error for deltaScale, avgScale and dOffset
            for (int j = 0; j < nIterations; j++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                if (j % reportPeriod == 0)
                {
                    worker.ReportProgress(j * 100 / nIterations);
                }
                this.recomputeError(false);
                dOffset = 0;
                dAvgScale = 0;
                dDeltaScale = 0;
                for (int i = 1; i < learnCount; i++)
                {
                    dOffset += pred[i] - rawW[i];
                    dAvgScale += (pred[i] - rawW[i]) * avgTemp[i];
                    dDeltaScale += (pred[i] - rawW[i]) * deltaTemp[i];
                }
                autoOffset -= descentFactor * dOffset;
                alpha -= descentFactor * dAvgScale;
                beta -= descentFactor * dDeltaScale;
            }
        }

        private void gradientDescent_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (prevProgress != e.ProgressPercentage)
            {
                prevProgress = e.ProgressPercentage;
                progressBar.Value = e.ProgressPercentage;
                rmsError.Text = (Math.Round(Math.Sqrt(avgSqError) * 10000) / 10000).ToString();
                if ((e.ProgressPercentage % 10) == 0)
                {
                    this.updateCompensationTable();
                }
            }
        }

        private void gradientDescent_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dialogPanel.Visible = false;
            this.updateCompensationTable();
            this.recomputeError(true);
        }

    }
}
