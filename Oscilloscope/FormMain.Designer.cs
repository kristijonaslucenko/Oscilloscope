namespace Osciloskopas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelSampleMinMaxDiff = new System.Windows.Forms.Label();
            this.labelSampleMax = new System.Windows.Forms.Label();
            this.labelSampleMin = new System.Windows.Forms.Label();
            this.trackBarSampleSize = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBarScaleCoeff = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBarOffset = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fft_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSampleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScaleCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartMain.BackColor = System.Drawing.Color.Transparent;
            this.chartMain.BorderSkin.BackColor = System.Drawing.SystemColors.MenuBar;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.ForestGreen;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.LimeGreen;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorGrid.Interval = 2100D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX2.InterlacedColor = System.Drawing.Color.ForestGreen;
            chartArea1.AxisX2.Interval = 1D;
            chartArea1.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX2.IsInterlaced = true;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.LimeGreen;
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.ForestGreen;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorGrid.Interval = 1D;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Cyan;
            chartArea1.AxisY2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.Fuchsia;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Fuchsia;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY2.MajorTickMark.Interval = 1D;
            chartArea1.AxisY2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Yellow;
            chartArea1.AxisY2.Maximum = 3D;
            chartArea1.AxisY2.MinorTickMark.Enabled = true;
            chartArea1.AxisY2.MinorTickMark.Interval = 1D;
            chartArea1.AxisY2.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Gold;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.LimeGreen;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(0, 4);
            this.chartMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Red;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.DarkRed;
            series1.Legend = "Legend1";
            series1.Name = "Signal 1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Yellow;
            series2.IsValueShownAsLabel = true;
            series2.Label = "Offset #VAL{D}";
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "GND";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Received";
            this.chartMain.Series.Add(series1);
            this.chartMain.Series.Add(series2);
            this.chartMain.Series.Add(series3);
            this.chartMain.Size = new System.Drawing.Size(821, 619);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStart.Location = new System.Drawing.Point(707, 82);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(92, 31);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerChart
            // 
            this.chartTimer.Interval = 80;
            this.chartTimer.Tick += new System.EventHandler(this.timerChart_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Samples per second: ";
            // 
            // label2
            // 
            this.labelSampleMinMaxDiff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSampleMinMaxDiff.AutoSize = true;
            this.labelSampleMinMaxDiff.Location = new System.Drawing.Point(717, 181);
            this.labelSampleMinMaxDiff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSampleMinMaxDiff.Name = "label2";
            this.labelSampleMinMaxDiff.Size = new System.Drawing.Size(36, 16);
            this.labelSampleMinMaxDiff.TabIndex = 5;
            this.labelSampleMinMaxDiff.Text = "Vpp:";
            // 
            // label3
            // 
            this.labelSampleMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSampleMax.AutoSize = true;
            this.labelSampleMax.Location = new System.Drawing.Point(716, 197);
            this.labelSampleMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSampleMax.Name = "label3";
            this.labelSampleMax.Size = new System.Drawing.Size(36, 16);
            this.labelSampleMax.TabIndex = 6;
            this.labelSampleMax.Text = "Max:";
            // 
            // label4
            // 
            this.labelSampleMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSampleMin.AutoSize = true;
            this.labelSampleMin.Location = new System.Drawing.Point(716, 213);
            this.labelSampleMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSampleMin.Name = "label4";
            this.labelSampleMin.Size = new System.Drawing.Size(32, 16);
            this.labelSampleMin.TabIndex = 7;
            this.labelSampleMin.Text = "Min:";
            // 
            // trackBar1
            // 
            this.trackBarSampleSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarSampleSize.LargeChange = 100;
            this.trackBarSampleSize.Location = new System.Drawing.Point(692, 233);
            this.trackBarSampleSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarSampleSize.Maximum = 12000;
            this.trackBarSampleSize.Minimum = 1;
            this.trackBarSampleSize.Name = "trackBar1";
            this.trackBarSampleSize.Size = new System.Drawing.Size(272, 45);
            this.trackBarSampleSize.TabIndex = 8;
            this.trackBarSampleSize.TickFrequency = 100;
            this.trackBarSampleSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarSampleSize.Value = 1;
            this.trackBarSampleSize.Scroll += new System.EventHandler(this.trackBarSampleSize_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBar2.Location = new System.Drawing.Point(689, 295);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar2.Maximum = 300;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(275, 45);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBarChartTimer_Scroll);
            // 
            // trackBar3
            // 
            this.trackBarScaleCoeff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarScaleCoeff.LargeChange = 1;
            this.trackBarScaleCoeff.Location = new System.Drawing.Point(692, 358);
            this.trackBarScaleCoeff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarScaleCoeff.Minimum = 1;
            this.trackBarScaleCoeff.Name = "trackBar3";
            this.trackBarScaleCoeff.Size = new System.Drawing.Size(272, 45);
            this.trackBarScaleCoeff.TabIndex = 10;
            this.trackBarScaleCoeff.Value = 1;
            this.trackBarScaleCoeff.Scroll += new System.EventHandler(this.trackBarScaleCoeff_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBar4.Location = new System.Drawing.Point(692, 406);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 128);
            this.trackBar4.TabIndex = 11;
            // 
            // trackBar5
            // 
            this.trackBarOffset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarOffset.Location = new System.Drawing.Point(771, 406);
            this.trackBarOffset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarOffset.Maximum = 50;
            this.trackBarOffset.Name = "trackBar5";
            this.trackBarOffset.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarOffset.Size = new System.Drawing.Size(45, 128);
            this.trackBarOffset.TabIndex = 12;
            this.trackBarOffset.Scroll += new System.EventHandler(this.trackBarOffset_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1s",
            "500ms",
            "200ms",
            "100ms",
            "50ms",
            "20ms",
            "10ms",
            "5ms",
            "2ms",
            "1ms"});
            this.comboBox1.Location = new System.Drawing.Point(816, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(813, 458);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Offset";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(813, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "COM Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPort.Location = new System.Drawing.Point(903, 60);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(56, 22);
            this.textBoxPort.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.comboBox2.Location = new System.Drawing.Point(903, 23);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 24);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(828, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "T/Div";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(901, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Samples";
            // 
            // fft_btn
            // 
            this.fft_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fft_btn.Location = new System.Drawing.Point(836, 119);
            this.fft_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fft_btn.Name = "fft_btn";
            this.fft_btn.Size = new System.Drawing.Size(128, 36);
            this.fft_btn.TabIndex = 13;
            this.fft_btn.Text = "Analysis";
            this.fft_btn.UseVisualStyleBackColor = true;
            this.fft_btn.Click += new System.EventHandler(this.buttonAnalysis_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(707, 119);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sharing";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 181);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(847, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "test";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 780);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fft_btn);
            this.Controls.Add(this.trackBarOffset);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBarScaleCoeff);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBarSampleSize);
            this.Controls.Add(this.labelSampleMin);
            this.Controls.Add(this.labelSampleMax);
            this.Controls.Add(this.labelSampleMinMaxDiff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.chartMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Osciloskopas";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSampleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScaleCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer chartTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSampleMinMaxDiff;
        private System.Windows.Forms.Label labelSampleMax;
        private System.Windows.Forms.Label labelSampleMin;
        private System.Windows.Forms.TrackBar trackBarSampleSize;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBarScaleCoeff;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBarOffset;
        private System.Windows.Forms.Button fft_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}

