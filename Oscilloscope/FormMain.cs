using Osciloskopas;
using System;
//using Client;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.ServiceModel;
using Osciloskopas.Properties;
//using Client.ChatService;


namespace Osciloskopas
{
    public partial class FormMain : Form
    {
        MainController controller = null;
        private bool stopped = true;

        public FormMain()
        {
            controller = new MainController();

            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            chartTimer.Interval = 30;

            chartMain.Series[0].BorderWidth = 2;
            chartMain.Series[1].BorderWidth = 2;

            if (Settings.Default.LastCom != null)
            {
                textBoxPort.Text = Settings.Default.LastCom;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (stopped)
            {
                int port;
                if (int.TryParse(textBoxPort.Text, out port))
                {
                    stopped = false;
                    buttonStart.Text = "Stop";
                    chartTimer.Enabled = true;
                    timer1.Enabled = true;
                    Settings.Default.LastCom = textBoxPort.Text;

                    controller.Start(port);
                }
                else
                {
                    MessageBox.Show("Please enter valid port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                stopped = true;
                buttonStart.Text = "Start";
                chartTimer.Enabled = false;

                controller.Stop();
            }
        }

        private void timerChart_Tick(object sender, EventArgs e)
        {
            chartMain.Series[0].Points.Clear();
            chartMain.Series[1].Points.Clear();

            for (int i = 0; i < controller.CurrentSample.Limit; ++i)
            {
                double value = controller.CurrentSample.Get(i);

                chartMain.Series[0].Points.AddXY(i, value);
                chartMain.Series[1].Points.AddXY(i, controller.Offset);
            }

            double Max = controller.CurrentSample.GetMax();
            double Min = controller.CurrentSample.GetMin();
            labelSampleMax.Text = "Max: " + Max;
            labelSampleMin.Text = "Min: " + Min;
            labelSampleMinMaxDiff.Text = "Vpp " + (Max - Min);
        }

        private void trackBarSampleSize_Scroll(object sender, EventArgs e)
        {
            controller.SampleSize = trackBarSampleSize.Value;
        }

        private void trackBarChartTimer_Scroll(object sender, EventArgs e)
        {
        }

        private void trackBarOffset_Scroll(object sender, EventArgs e)
        {
            controller.Offset = trackBarOffset.Value / 10;
            label5.Text = "Offset " + controller.Offset + " V";
        }

        private void trackBarScaleCoeff_Scroll(object sender, EventArgs e)
        {
            controller.ScaleCoeff = (Double)trackBarScaleCoeff.Value / 2;
        }

        private void buttonAnalysis_Click(object sender, EventArgs e)
        {
            controller.ShowAnalysis();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    f2.TopLevel = false;
        //    f2.AutoScroll = true;
        //    f2.FormBorderStyle = FormBorderStyle.None;
        //    timer1.Enabled = true;
        //    panel1.Controls.Add(f2);
        //    f2.Show();
        //    f2.queue_main = queue;
        //    f2.queue_main.Limit = queue.Limit;
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Console.WriteLine(comboBox1.Text);
        //    switch (comboBox1.Text)
        //    {
        //        case "1s":
        //            queue.Limit = 12600 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 12600D;
        //            break;
        //        case "500ms":
        //            queue.Limit = 6300 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 6300D;
        //            break;
        //        case "200ms":
        //            queue.Limit = 2520 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 2520D;
        //            break;
        //        case "100ms":
        //            queue.Limit = 1260 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 1260D;
        //            break;
        //        case "50ms":
        //            queue.Limit = 630 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 630D;
        //            break;
        //        case "20ms":
        //            queue.Limit = 252 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 252D;
        //            break;
        //        case "10ms":
        //            queue.Limit = 126 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 126D;
        //            break;
        //        case "5ms":
        //            queue.Limit = 63 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 63D;
        //            break;
        //        case "2ms":
        //            queue.Limit = 25 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 25D;
        //            break;
        //        case "1ms":
        //            queue.Limit = 12 * 6;
        //            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 12D;
        //            break;
        //    }
        //    if (comboBox1.SelectedIndex == -1)
        //    {
        //    }
        //    else
        //    {
        //        comboBox2.SelectedIndex = -1;
        //    }
        //}

        //void makeNewSeries(String name, string data)
        //{
        //    KnownColor randomColorName = names[randomGen.Next(names.Length)];
        //    Color randomColor = Color.FromKnownColor(randomColorName);


        //    chartMain.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series
        //    {
        //        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine,
        //        Name = name,
        //        Color = randomColor,
        //        //LabelForeColor=randomColor,
        //        IsVisibleInLegend = true,
        //        IsXValueIndexed = true,
        //        IsValueShownAsLabel = true

        //    });

        //}



        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox2.SelectedIndex == -1)
        //    {
        //    }
        //    else
        //    {
        //        queue.Limit = Convert.ToInt32(comboBox2.Text);
        //        chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = Convert.ToInt32(comboBox2.Text) / 6;
        //        comboBox1.SelectedIndex = -1;
        //    }


        //}

        //private void label5_Click(object sender, EventArgs e)
        //{
        //    makeNewSeries("newname", "sdfsdf");
        //}
    }
}
