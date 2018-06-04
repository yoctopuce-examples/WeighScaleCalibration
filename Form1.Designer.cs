namespace HiSpeed2D
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showRawW = new System.Windows.Forms.CheckBox();
            this.showAvg = new System.Windows.Forms.CheckBox();
            this.showDelta = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.autoDelta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deltaRatioTrackBar = new System.Windows.Forms.TrackBar();
            this.deltaRatio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.autoAvg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.avgRatio = new System.Windows.Forms.TextBox();
            this.avgRatioTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.showPrediction = new System.Windows.Forms.CheckBox();
            this.showError = new System.Windows.Forms.CheckBox();
            this.showTemp = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deriv = new System.Windows.Forms.CheckBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.avgCompMax = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.deltaCompMax = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.avgCompZero = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.deltaCompZero = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.avgCompMin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.deltaCompMin = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rmsError = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.gradientDescentWorker = new System.ComponentModel.BackgroundWorker();
            this.tempChangeWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dialogPanel = new System.Windows.Forms.Panel();
            this.dialogTitle = new System.Windows.Forms.Label();
            this.dialogButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaRatioTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avgRatioTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.dialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1223, 709);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // showRawW
            // 
            this.showRawW.AutoSize = true;
            this.showRawW.Checked = true;
            this.showRawW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showRawW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRawW.Location = new System.Drawing.Point(10, 42);
            this.showRawW.Margin = new System.Windows.Forms.Padding(4);
            this.showRawW.Name = "showRawW";
            this.showRawW.Size = new System.Drawing.Size(155, 21);
            this.showRawW.TabIndex = 3;
            this.showRawW.Text = "Measured Zero drift";
            this.showRawW.UseVisualStyleBackColor = true;
            this.showRawW.CheckedChanged += new System.EventHandler(this.showRawW_CheckedChanged);
            // 
            // showAvg
            // 
            this.showAvg.AutoSize = true;
            this.showAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAvg.Location = new System.Drawing.Point(10, 89);
            this.showAvg.Margin = new System.Windows.Forms.Padding(4);
            this.showAvg.Name = "showAvg";
            this.showAvg.Size = new System.Drawing.Size(164, 21);
            this.showAvg.TabIndex = 5;
            this.showAvg.Text = "Average temperature";
            this.showAvg.UseVisualStyleBackColor = true;
            this.showAvg.CheckedChanged += new System.EventHandler(this.showAvg_CheckedChanged);
            // 
            // showDelta
            // 
            this.showDelta.AutoSize = true;
            this.showDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDelta.Location = new System.Drawing.Point(10, 68);
            this.showDelta.Margin = new System.Windows.Forms.Padding(4);
            this.showDelta.Name = "showDelta";
            this.showDelta.Size = new System.Drawing.Size(163, 21);
            this.showDelta.TabIndex = 7;
            this.showDelta.Text = "Temperature change";
            this.showDelta.UseVisualStyleBackColor = true;
            this.showDelta.CheckedChanged += new System.EventHandler(this.showDelta_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.autoDelta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deltaRatioTrackBar);
            this.groupBox1.Controls.Add(this.deltaRatio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(227, 716);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 89);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Temperature change compensation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "%";
            // 
            // autoDelta
            // 
            this.autoDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoDelta.Location = new System.Drawing.Point(334, 20);
            this.autoDelta.Name = "autoDelta";
            this.autoDelta.Size = new System.Drawing.Size(60, 28);
            this.autoDelta.TabIndex = 18;
            this.autoDelta.Text = "Reset";
            this.autoDelta.UseVisualStyleBackColor = true;
            this.autoDelta.Click += new System.EventHandler(this.autoDelta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thermal inertia (adaptation ratio):";
            // 
            // deltaRatioTrackBar
            // 
            this.deltaRatioTrackBar.AutoSize = false;
            this.deltaRatioTrackBar.Location = new System.Drawing.Point(6, 44);
            this.deltaRatioTrackBar.Maximum = 100;
            this.deltaRatioTrackBar.Minimum = -100;
            this.deltaRatioTrackBar.Name = "deltaRatioTrackBar";
            this.deltaRatioTrackBar.Size = new System.Drawing.Size(398, 39);
            this.deltaRatioTrackBar.TabIndex = 14;
            this.deltaRatioTrackBar.TickFrequency = 5;
            this.deltaRatioTrackBar.Scroll += new System.EventHandler(this.deltaRatioTrackBar_Scroll);
            // 
            // deltaRatio
            // 
            this.deltaRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltaRatio.Location = new System.Drawing.Point(233, 22);
            this.deltaRatio.Name = "deltaRatio";
            this.deltaRatio.Size = new System.Drawing.Size(69, 22);
            this.deltaRatio.TabIndex = 7;
            this.deltaRatio.Text = "0.06";
            this.deltaRatio.TextChanged += new System.EventHandler(this.deltaRatio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temp. change comp.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.autoAvg);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.avgRatio);
            this.groupBox2.Controls.Add(this.avgRatioTrackBar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(227, 805);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 88);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Average temperature compensation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "%";
            // 
            // autoAvg
            // 
            this.autoAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoAvg.Location = new System.Drawing.Point(334, 23);
            this.autoAvg.Name = "autoAvg";
            this.autoAvg.Size = new System.Drawing.Size(60, 25);
            this.autoAvg.TabIndex = 19;
            this.autoAvg.Text = "Reset";
            this.autoAvg.UseVisualStyleBackColor = true;
            this.autoAvg.Click += new System.EventHandler(this.autoAvg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thermal inertia (adaptation ratio):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 15;
            // 
            // avgRatio
            // 
            this.avgRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgRatio.Location = new System.Drawing.Point(233, 24);
            this.avgRatio.Name = "avgRatio";
            this.avgRatio.Size = new System.Drawing.Size(69, 22);
            this.avgRatio.TabIndex = 6;
            this.avgRatio.TextChanged += new System.EventHandler(this.avgRatio_TextChanged);
            // 
            // avgRatioTrackBar
            // 
            this.avgRatioTrackBar.AutoSize = false;
            this.avgRatioTrackBar.Location = new System.Drawing.Point(6, 46);
            this.avgRatioTrackBar.Maximum = 100;
            this.avgRatioTrackBar.Minimum = -100;
            this.avgRatioTrackBar.Name = "avgRatioTrackBar";
            this.avgRatioTrackBar.Size = new System.Drawing.Size(398, 36);
            this.avgRatioTrackBar.TabIndex = 7;
            this.avgRatioTrackBar.TickFrequency = 5;
            this.avgRatioTrackBar.Scroll += new System.EventHandler(this.avgRatioTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Avg. temp. comp";
            // 
            // showPrediction
            // 
            this.showPrediction.AutoSize = true;
            this.showPrediction.Checked = true;
            this.showPrediction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPrediction.Location = new System.Drawing.Point(10, 118);
            this.showPrediction.Margin = new System.Windows.Forms.Padding(4);
            this.showPrediction.Name = "showPrediction";
            this.showPrediction.Size = new System.Drawing.Size(118, 21);
            this.showPrediction.TabIndex = 10;
            this.showPrediction.Text = "Prodicted drift";
            this.showPrediction.UseVisualStyleBackColor = true;
            this.showPrediction.CheckedChanged += new System.EventHandler(this.showPrediction_CheckedChanged);
            // 
            // showError
            // 
            this.showError.AutoSize = true;
            this.showError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showError.Location = new System.Drawing.Point(10, 138);
            this.showError.Margin = new System.Windows.Forms.Padding(4);
            this.showError.Name = "showError";
            this.showError.Size = new System.Drawing.Size(120, 21);
            this.showError.TabIndex = 11;
            this.showError.Text = "Residual error";
            this.showError.UseVisualStyleBackColor = true;
            this.showError.CheckedChanged += new System.EventHandler(this.showError_CheckedChanged);
            // 
            // showTemp
            // 
            this.showTemp.AutoSize = true;
            this.showTemp.Checked = true;
            this.showTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTemp.Location = new System.Drawing.Point(10, 22);
            this.showTemp.Margin = new System.Windows.Forms.Padding(4);
            this.showTemp.Name = "showTemp";
            this.showTemp.Size = new System.Drawing.Size(174, 21);
            this.showTemp.TabIndex = 12;
            this.showTemp.Text = "Measured temperature";
            this.showTemp.UseVisualStyleBackColor = true;
            this.showTemp.CheckedChanged += new System.EventHandler(this.showTemp_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.deriv);
            this.groupBox3.Controls.Add(this.showPrediction);
            this.groupBox3.Controls.Add(this.showTemp);
            this.groupBox3.Controls.Add(this.showRawW);
            this.groupBox3.Controls.Add(this.showDelta);
            this.groupBox3.Controls.Add(this.showAvg);
            this.groupBox3.Controls.Add(this.showError);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 716);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 177);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show graphs";
            // 
            // deriv
            // 
            this.deriv.AutoSize = true;
            this.deriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deriv.Location = new System.Drawing.Point(147, 118);
            this.deriv.Margin = new System.Windows.Forms.Padding(4);
            this.deriv.Name = "deriv";
            this.deriv.Size = new System.Drawing.Size(37, 21);
            this.deriv.TabIndex = 16;
            this.deriv.Text = "f\'";
            this.deriv.UseVisualStyleBackColor = true;
            this.deriv.CheckedChanged += new System.EventHandler(this.deriv_CheckedChanged);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(346, 12);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(572, 130);
            this.logBox.TabIndex = 14;
            this.logBox.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.fileName);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.rmsError);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(643, 719);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(583, 177);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Result";
            // 
            // fileName
            // 
            this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(58, 22);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(198, 15);
            this.fileName.TabIndex = 29;
            this.fileName.Text = "<click to open>";
            this.fileName.Click += new System.EventHandler(this.fileName_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "File:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.avgCompMax);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.deltaCompMax);
            this.groupBox8.Location = new System.Drawing.Point(9, 137);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox8.Size = new System.Drawing.Size(546, 32);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            // 
            // avgCompMax
            // 
            this.avgCompMax.AutoSize = true;
            this.avgCompMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgCompMax.Location = new System.Drawing.Point(430, 12);
            this.avgCompMax.Name = "avgCompMax";
            this.avgCompMax.Size = new System.Drawing.Size(16, 17);
            this.avgCompMax.TabIndex = 26;
            this.avgCompMax.Text = "0";
            this.avgCompMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(30, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "100 °C";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // deltaCompMax
            // 
            this.deltaCompMax.AutoSize = true;
            this.deltaCompMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltaCompMax.Location = new System.Drawing.Point(264, 12);
            this.deltaCompMax.Name = "deltaCompMax";
            this.deltaCompMax.Size = new System.Drawing.Size(16, 17);
            this.deltaCompMax.TabIndex = 16;
            this.deltaCompMax.Text = "0";
            this.deltaCompMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.avgCompZero);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.deltaCompZero);
            this.groupBox7.Location = new System.Drawing.Point(9, 111);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox7.Size = new System.Drawing.Size(546, 30);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            // 
            // avgCompZero
            // 
            this.avgCompZero.AutoSize = true;
            this.avgCompZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgCompZero.Location = new System.Drawing.Point(430, 12);
            this.avgCompZero.Name = "avgCompZero";
            this.avgCompZero.Size = new System.Drawing.Size(16, 17);
            this.avgCompZero.TabIndex = 26;
            this.avgCompZero.Text = "0";
            this.avgCompZero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "0 °C";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // deltaCompZero
            // 
            this.deltaCompZero.AutoSize = true;
            this.deltaCompZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltaCompZero.Location = new System.Drawing.Point(264, 12);
            this.deltaCompZero.Name = "deltaCompZero";
            this.deltaCompZero.Size = new System.Drawing.Size(16, 17);
            this.deltaCompZero.TabIndex = 16;
            this.deltaCompZero.Text = "0";
            this.deltaCompZero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.avgCompMin);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.deltaCompMin);
            this.groupBox6.Location = new System.Drawing.Point(9, 85);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox6.Size = new System.Drawing.Size(546, 30);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            // 
            // avgCompMin
            // 
            this.avgCompMin.AutoSize = true;
            this.avgCompMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgCompMin.Location = new System.Drawing.Point(430, 12);
            this.avgCompMin.Name = "avgCompMin";
            this.avgCompMin.Size = new System.Drawing.Size(16, 17);
            this.avgCompMin.TabIndex = 26;
            this.avgCompMin.Text = "0";
            this.avgCompMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "-30 °C";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // deltaCompMin
            // 
            this.deltaCompMin.AutoSize = true;
            this.deltaCompMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltaCompMin.Location = new System.Drawing.Point(264, 12);
            this.deltaCompMin.Name = "deltaCompMin";
            this.deltaCompMin.Size = new System.Drawing.Size(16, 17);
            this.deltaCompMin.TabIndex = 16;
            this.deltaCompMin.Text = "0";
            this.deltaCompMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(9, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(546, 46);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Temperature";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(264, -2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Temperature compensation";
            // 
            // rmsError
            // 
            this.rmsError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rmsError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmsError.Location = new System.Drawing.Point(500, 20);
            this.rmsError.Name = "rmsError";
            this.rmsError.ReadOnly = true;
            this.rmsError.Size = new System.Drawing.Size(75, 15);
            this.rmsError.TabIndex = 21;
            this.rmsError.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "RMS error:";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(43, 104);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(696, 45);
            this.progressBar.TabIndex = 22;
            this.progressBar.Visible = false;
            // 
            // gradientDescentWorker
            // 
            this.gradientDescentWorker.WorkerReportsProgress = true;
            this.gradientDescentWorker.WorkerSupportsCancellation = true;
            this.gradientDescentWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.gradientDescent_DoWork);
            this.gradientDescentWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.gradientDescent_ProgressChanged);
            this.gradientDescentWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.gradientDescent_RunWorkerCompleted);
            // 
            // tempChangeWorker
            // 
            this.tempChangeWorker.WorkerReportsProgress = true;
            this.tempChangeWorker.WorkerSupportsCancellation = true;
            this.tempChangeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tempChangeWorker_DoWork);
            this.tempChangeWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.tempChangeWorker_ProgressChanged);
            this.tempChangeWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.tempChangeWorker_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dialogPanel
            // 
            this.dialogPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogPanel.Controls.Add(this.errorMessage);
            this.dialogPanel.Controls.Add(this.dialogButton);
            this.dialogPanel.Controls.Add(this.dialogTitle);
            this.dialogPanel.Controls.Add(this.progressBar);
            this.dialogPanel.Location = new System.Drawing.Point(237, 209);
            this.dialogPanel.Name = "dialogPanel";
            this.dialogPanel.Size = new System.Drawing.Size(776, 250);
            this.dialogPanel.TabIndex = 23;
            this.dialogPanel.Visible = false;
            // 
            // dialogTitle
            // 
            this.dialogTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogTitle.Location = new System.Drawing.Point(89, 22);
            this.dialogTitle.Name = "dialogTitle";
            this.dialogTitle.Size = new System.Drawing.Size(598, 49);
            this.dialogTitle.TabIndex = 23;
            this.dialogTitle.Text = "DialogTitle";
            this.dialogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dialogButton
            // 
            this.dialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogButton.AutoSize = true;
            this.dialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogButton.Location = new System.Drawing.Point(679, 186);
            this.dialogButton.Name = "dialogButton";
            this.dialogButton.Size = new System.Drawing.Size(69, 35);
            this.dialogButton.TabIndex = 23;
            this.dialogButton.Text = "Abort";
            this.dialogButton.UseVisualStyleBackColor = true;
            this.dialogButton.Click += new System.EventHandler(this.dialogButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.Location = new System.Drawing.Point(89, 101);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(598, 49);
            this.errorMessage.TabIndex = 24;
            this.errorMessage.Text = "errorMessage";
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 900);
            this.Controls.Add(this.dialogPanel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Yoctopuce Load Cell Temperature Compensation Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaRatioTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avgRatioTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.dialogPanel.ResumeLayout(false);
            this.dialogPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.CheckBox showRawW;
    private System.Windows.Forms.CheckBox showAvg;
        private System.Windows.Forms.CheckBox showDelta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox showPrediction;
        private System.Windows.Forms.CheckBox showError;
        private System.Windows.Forms.CheckBox showTemp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox deltaRatio;
        private System.Windows.Forms.TextBox avgRatio;
        private System.Windows.Forms.TrackBar deltaRatioTrackBar;
        private System.Windows.Forms.TrackBar avgRatioTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.CheckBox deriv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button autoDelta;
        private System.Windows.Forms.Button autoAvg;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox rmsError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker gradientDescentWorker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label avgCompMax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label deltaCompMax;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label avgCompZero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label deltaCompZero;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label avgCompMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label deltaCompMin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker tempChangeWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Panel dialogPanel;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button dialogButton;
        private System.Windows.Forms.Label dialogTitle;
    }
}

