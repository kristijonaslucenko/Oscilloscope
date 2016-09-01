namespace Oscilloscope.Views
{
    partial class AnalysisForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fft = new System.Windows.Forms.Button();
            this.idft = new System.Windows.Forms.Button();
            this.comboBoxNbHarmonics = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.harmonicsTableTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFundamentalFrequency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAnalysis
            // 
            this.chartAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartAnalysis.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAnalysis.Legends.Add(legend2);
            this.chartAnalysis.Location = new System.Drawing.Point(16, 15);
            this.chartAnalysis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartAnalysis.Name = "chartAnalysis";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAnalysis.Series.Add(series2);
            this.chartAnalysis.Size = new System.Drawing.Size(659, 409);
            this.chartAnalysis.TabIndex = 0;
            this.chartAnalysis.Text = "chart1";
            // 
            // fft
            // 
            this.fft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fft.Location = new System.Drawing.Point(765, 13);
            this.fft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fft.Name = "fft";
            this.fft.Size = new System.Drawing.Size(93, 33);
            this.fft.TabIndex = 1;
            this.fft.Text = "FFT";
            this.fft.UseVisualStyleBackColor = true;
            this.fft.Click += new System.EventHandler(this.fftButton_Click);
            // 
            // idft
            // 
            this.idft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idft.Location = new System.Drawing.Point(765, 54);
            this.idft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idft.Name = "idft";
            this.idft.Size = new System.Drawing.Size(93, 32);
            this.idft.TabIndex = 2;
            this.idft.Text = "IDFT";
            this.idft.UseVisualStyleBackColor = true;
            this.idft.Click += new System.EventHandler(this.idftButton_Click);
            // 
            // comboBoxNbHarmonics
            // 
            this.comboBoxNbHarmonics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNbHarmonics.FormattingEnabled = true;
            this.comboBoxNbHarmonics.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxNbHarmonics.Location = new System.Drawing.Point(765, 137);
            this.comboBoxNbHarmonics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNbHarmonics.Name = "comboBoxNbHarmonics";
            this.comboBoxNbHarmonics.Size = new System.Drawing.Size(92, 24);
            this.comboBoxNbHarmonics.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(760, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "# of harmonics:";
            // 
            // harmonicsTableTextBox
            // 
            this.harmonicsTableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.harmonicsTableTextBox.Location = new System.Drawing.Point(16, 431);
            this.harmonicsTableTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.harmonicsTableTextBox.Name = "harmonicsTableTextBox";
            this.harmonicsTableTextBox.Size = new System.Drawing.Size(659, 212);
            this.harmonicsTableTextBox.TabIndex = 5;
            this.harmonicsTableTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fundamental frequency:";
            // 
            // labelFundamentalFrequency
            // 
            this.labelFundamentalFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFundamentalFrequency.AutoSize = true;
            this.labelFundamentalFrequency.Location = new System.Drawing.Point(828, 225);
            this.labelFundamentalFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFundamentalFrequency.Name = "labelFundamentalFrequency";
            this.labelFundamentalFrequency.Size = new System.Drawing.Size(0, 16);
            this.labelFundamentalFrequency.TabIndex = 7;
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 663);
            this.Controls.Add(this.labelFundamentalFrequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.harmonicsTableTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNbHarmonics);
            this.Controls.Add(this.idft);
            this.Controls.Add(this.fft);
            this.Controls.Add(this.chartAnalysis);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnalysisForm";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysis;
        private System.Windows.Forms.Button fft;
        private System.Windows.Forms.Button idft;
        private System.Windows.Forms.ComboBox comboBoxNbHarmonics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox harmonicsTableTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFundamentalFrequency;
    }
}