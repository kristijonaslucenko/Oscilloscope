namespace Oscilloscope.Views
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.labelSampleRate = new System.Windows.Forms.Label();
            this.labelSampleMinMaxDiff = new System.Windows.Forms.Label();
            this.labelSampleMax = new System.Windows.Forms.Label();
            this.labelSampleMin = new System.Windows.Forms.Label();
            this.trackBarScaleCoeff = new System.Windows.Forms.TrackBar();
            this.trackBarOffset = new System.Windows.Forms.TrackBar();
            this.comboBoxTDiv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.comboBoxSampleSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fft_btn = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.btnLoadReceivedSample = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxSamples = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxDataProvider = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScaleCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffset)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartMain.BackColor = System.Drawing.Color.Transparent;
            this.chartMain.BorderSkin.BackColor = System.Drawing.SystemColors.MenuBar;
            chartArea5.AxisX.InterlacedColor = System.Drawing.Color.ForestGreen;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LineColor = System.Drawing.Color.LimeGreen;
            chartArea5.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisX.MajorGrid.Interval = 2100D;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisX2.InterlacedColor = System.Drawing.Color.ForestGreen;
            chartArea5.AxisX2.Interval = 1D;
            chartArea5.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX2.IsInterlaced = true;
            chartArea5.AxisX2.LineColor = System.Drawing.Color.LimeGreen;
            chartArea5.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.InterlacedColor = System.Drawing.Color.ForestGreen;
            chartArea5.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.MajorGrid.Interval = 1D;
            chartArea5.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Red;
            chartArea5.AxisY.Maximum = 6D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.AxisY.MinorTickMark.Enabled = true;
            chartArea5.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Red;
            chartArea5.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Cyan;
            chartArea5.AxisY2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea5.AxisY2.InterlacedColor = System.Drawing.Color.Fuchsia;
            chartArea5.AxisY2.LineColor = System.Drawing.Color.Fuchsia;
            chartArea5.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea5.AxisY2.MajorTickMark.Interval = 1D;
            chartArea5.AxisY2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea5.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Yellow;
            chartArea5.AxisY2.Maximum = 3D;
            chartArea5.AxisY2.MinorTickMark.Enabled = true;
            chartArea5.AxisY2.MinorTickMark.Interval = 1D;
            chartArea5.AxisY2.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Gold;
            chartArea5.BackColor = System.Drawing.Color.Black;
            chartArea5.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea5.BorderColor = System.Drawing.Color.LimeGreen;
            chartArea5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea5.BorderWidth = 2;
            chartArea5.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            legend5.BorderColor = System.Drawing.Color.Black;
            legend5.Name = "Legend1";
            this.chartMain.Legends.Add(legend5);
            this.chartMain.Location = new System.Drawing.Point(4, 3);
            this.chartMain.Margin = new System.Windows.Forms.Padding(2);
            this.chartMain.Name = "chartMain";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Color = System.Drawing.Color.Red;
            series13.IsValueShownAsLabel = true;
            series13.LabelForeColor = System.Drawing.Color.DarkRed;
            series13.Legend = "Legend1";
            series13.Name = "Signal 1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Color = System.Drawing.Color.Yellow;
            series14.IsValueShownAsLabel = true;
            series14.Label = "Offset #VAL{D}";
            series14.LabelForeColor = System.Drawing.Color.Red;
            series14.Legend = "Legend1";
            series14.Name = "GND";
            series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series15.Legend = "Legend1";
            series15.Name = "Received";
            this.chartMain.Series.Add(series13);
            this.chartMain.Series.Add(series14);
            this.chartMain.Series.Add(series15);
            this.chartMain.Size = new System.Drawing.Size(656, 584);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStart.Location = new System.Drawing.Point(11, 27);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(92, 24);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chartTimer
            // 
            this.chartTimer.Interval = 80;
            this.chartTimer.Tick += new System.EventHandler(this.timerChart_Tick);
            // 
            // labelSampleRate
            // 
            this.labelSampleRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSampleRate.AutoSize = true;
            this.labelSampleRate.Location = new System.Drawing.Point(6, 20);
            this.labelSampleRate.Name = "labelSampleRate";
            this.labelSampleRate.Size = new System.Drawing.Size(109, 13);
            this.labelSampleRate.TabIndex = 4;
            this.labelSampleRate.Text = "Samples per second: ";
            // 
            // labelSampleMinMaxDiff
            // 
            this.labelSampleMinMaxDiff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSampleMinMaxDiff.AutoSize = true;
            this.labelSampleMinMaxDiff.Location = new System.Drawing.Point(6, 32);
            this.labelSampleMinMaxDiff.Name = "labelSampleMinMaxDiff";
            this.labelSampleMinMaxDiff.Size = new System.Drawing.Size(29, 13);
            this.labelSampleMinMaxDiff.TabIndex = 5;
            this.labelSampleMinMaxDiff.Text = "Vpp:";
            // 
            // labelSampleMax
            // 
            this.labelSampleMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSampleMax.AutoSize = true;
            this.labelSampleMax.Location = new System.Drawing.Point(5, 46);
            this.labelSampleMax.Name = "labelSampleMax";
            this.labelSampleMax.Size = new System.Drawing.Size(30, 13);
            this.labelSampleMax.TabIndex = 6;
            this.labelSampleMax.Text = "Max:";
            // 
            // labelSampleMin
            // 
            this.labelSampleMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSampleMin.AutoSize = true;
            this.labelSampleMin.Location = new System.Drawing.Point(5, 58);
            this.labelSampleMin.Name = "labelSampleMin";
            this.labelSampleMin.Size = new System.Drawing.Size(27, 13);
            this.labelSampleMin.TabIndex = 7;
            this.labelSampleMin.Text = "Min:";
            // 
            // trackBarScaleCoeff
            // 
            this.trackBarScaleCoeff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarScaleCoeff.LargeChange = 1;
            this.trackBarScaleCoeff.Location = new System.Drawing.Point(7, 143);
            this.trackBarScaleCoeff.Minimum = 1;
            this.trackBarScaleCoeff.Name = "trackBarScaleCoeff";
            this.trackBarScaleCoeff.Size = new System.Drawing.Size(197, 45);
            this.trackBarScaleCoeff.TabIndex = 10;
            this.trackBarScaleCoeff.Value = 1;
            this.trackBarScaleCoeff.Scroll += new System.EventHandler(this.trackBarScaleCoeff_Scroll);
            // 
            // trackBarOffset
            // 
            this.trackBarOffset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarOffset.Location = new System.Drawing.Point(7, 204);
            this.trackBarOffset.Maximum = 50;
            this.trackBarOffset.Name = "trackBarOffset";
            this.trackBarOffset.Size = new System.Drawing.Size(197, 45);
            this.trackBarOffset.TabIndex = 12;
            this.trackBarOffset.Scroll += new System.EventHandler(this.trackBarOffset_Scroll);
            // 
            // comboBoxTDiv
            // 
            this.comboBoxTDiv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxTDiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTDiv.FormattingEnabled = true;
            this.comboBoxTDiv.Items.AddRange(new object[] {
            "1000",
            "500",
            "200",
            "100",
            "50",
            "20",
            "10",
            "5",
            "2",
            "1"});
            this.comboBoxTDiv.Location = new System.Drawing.Point(12, 37);
            this.comboBoxTDiv.Name = "comboBoxTDiv";
            this.comboBoxTDiv.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTDiv.TabIndex = 13;
            this.comboBoxTDiv.SelectedIndexChanged += new System.EventHandler(this.comboBoxTDiv_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Offset";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "COM Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPort.Location = new System.Drawing.Point(118, 82);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(86, 20);
            this.textBoxPort.TabIndex = 16;
            // 
            // comboBoxSampleSize
            // 
            this.comboBoxSampleSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxSampleSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSampleSize.FormattingEnabled = true;
            this.comboBoxSampleSize.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.comboBoxSampleSize.Location = new System.Drawing.Point(118, 37);
            this.comboBoxSampleSize.Name = "comboBoxSampleSize";
            this.comboBoxSampleSize.Size = new System.Drawing.Size(86, 21);
            this.comboBoxSampleSize.TabIndex = 17;
            this.comboBoxSampleSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSampleSize_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "T/Div (ms)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Samples";
            // 
            // fft_btn
            // 
            this.fft_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fft_btn.Location = new System.Drawing.Point(118, 27);
            this.fft_btn.Name = "fft_btn";
            this.fft_btn.Size = new System.Drawing.Size(86, 24);
            this.fft_btn.TabIndex = 13;
            this.fft_btn.Text = "Analysis";
            this.fft_btn.UseVisualStyleBackColor = true;
            this.fft_btn.Click += new System.EventHandler(this.buttonAnalysis_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonConnect.Location = new System.Drawing.Point(114, 46);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(90, 24);
            this.buttonConnect.TabIndex = 15;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // btnLoadReceivedSample
            // 
            this.btnLoadReceivedSample.Enabled = false;
            this.btnLoadReceivedSample.Location = new System.Drawing.Point(114, 151);
            this.btnLoadReceivedSample.Name = "btnLoadReceivedSample";
            this.btnLoadReceivedSample.Size = new System.Drawing.Size(90, 24);
            this.btnLoadReceivedSample.TabIndex = 26;
            this.btnLoadReceivedSample.Text = "Load Sample";
            this.btnLoadReceivedSample.UseVisualStyleBackColor = true;
            this.btnLoadReceivedSample.Click += new System.EventHandler(this.btnLoadReceivedSample_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(76, 22);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(129, 20);
            this.txtUserName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "User Name:";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(114, 253);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 24);
            this.btnSend.TabIndex = 22;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(11, 204);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(194, 43);
            this.listBoxUsers.TabIndex = 21;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Scale coeff.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBoxSamples);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.btnLoadReceivedSample);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxUsers);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(656, 384);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(209, 284);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sharing";
            // 
            // listBoxSamples
            // 
            this.listBoxSamples.FormattingEnabled = true;
            this.listBoxSamples.Location = new System.Drawing.Point(11, 103);
            this.listBoxSamples.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSamples.Name = "listBoxSamples";
            this.listBoxSamples.Size = new System.Drawing.Size(194, 43);
            this.listBoxSamples.TabIndex = 26;
            this.listBoxSamples.SelectedIndexChanged += new System.EventHandler(this.listBoxSamples_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Received samples:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBoxDataProvider);
            this.groupBox2.Controls.Add(this.trackBarOffset);
            this.groupBox2.Controls.Add(this.trackBarScaleCoeff);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxPort);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxSampleSize);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxTDiv);
            this.groupBox2.Location = new System.Drawing.Point(656, 99);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(209, 280);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // comboBoxDataProvider
            // 
            this.comboBoxDataProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataProvider.Enabled = false;
            this.comboBoxDataProvider.Items.AddRange(new object[] {
            "Serial COM",
            "Random Data Gen"});
            this.comboBoxDataProvider.Location = new System.Drawing.Point(11, 81);
            this.comboBoxDataProvider.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDataProvider.Name = "comboBoxDataProvider";
            this.comboBoxDataProvider.Size = new System.Drawing.Size(93, 21);
            this.comboBoxDataProvider.TabIndex = 20;
            this.comboBoxDataProvider.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataProvider_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data provider";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonStart);
            this.groupBox3.Controls.Add(this.fft_btn);
            this.groupBox3.Location = new System.Drawing.Point(656, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(209, 81);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.labelSampleMax);
            this.groupBox4.Controls.Add(this.labelSampleRate);
            this.groupBox4.Controls.Add(this.labelSampleMinMaxDiff);
            this.groupBox4.Controls.Add(this.labelSampleMin);
            this.groupBox4.Location = new System.Drawing.Point(29, 587);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(150, 81);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistics";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 674);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Osciloskopas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScaleCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer chartTimer;
        private System.Windows.Forms.Label labelSampleRate;
        private System.Windows.Forms.Label labelSampleMinMaxDiff;
        private System.Windows.Forms.Label labelSampleMax;
        private System.Windows.Forms.Label labelSampleMin;
        private System.Windows.Forms.TrackBar trackBarScaleCoeff;
        private System.Windows.Forms.TrackBar trackBarOffset;
        private System.Windows.Forms.Button fft_btn;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxTDiv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ComboBox comboBoxSampleSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLoadReceivedSample;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxSamples;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxDataProvider;
        private System.Windows.Forms.Label label9;
    }
}

