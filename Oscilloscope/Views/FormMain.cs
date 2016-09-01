using Oscilloscope;
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
using Oscilloscope.Properties;
using Oscilloscope.DataHandlers;
using Oscilloscope.Controllers;
using Oscilloscope.ServiceHandlers;
//using Client.ChatService;


namespace Oscilloscope.Views
{
    public partial class FormMain : Form
    {
        MainController controller = null;
        SharingController sharingController = null;
        private bool stopped = true;

        public FormMain()
        {
            controller = new MainController();

            sharingController = new SharingController();

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
                var scaledValue = controller.ScaleValue(value);

                chartMain.Series[0].Points.AddXY(i, scaledValue);
                chartMain.Series[1].Points.AddXY(i, controller.Offset);
            }

            double Max = controller.CurrentSample.GetMax();
            double Min = controller.CurrentSample.GetMin();
            labelSampleMax.Text = "Max: " + Max;
            labelSampleMin.Text = "Min: " + Min;
            labelSampleMinMaxDiff.Text = "Vpp " + (Max - Min);

            labelSampleRate.Text = "Samples per second: " + controller.CurrentSampleRate;
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

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            sharingController.Connect();

            btnSend.Enabled = true;
        }

        private void comboBoxTDiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBoxTDiv.Text);

            int tDiv;
            if (!int.TryParse(comboBoxTDiv.Text, out tDiv))
            {
                MessageBox.Show("Invalid sample rate selected.");
            }

            var sampleSizeByTDiv = new Dictionary<int, int>
            {
                { 1000, 12600 },
                { 500, 6300 },
                { 200, 2520 },
                { 100, 1260 },
                { 50, 630 },
                { 20, 252 },
                { 10, 126 },
                { 5, 63 },
                { 2, 25 },
                { 1, 12 },
            };

            controller.SampleSize = sampleSizeByTDiv[tDiv] * 6;
            chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = sampleSizeByTDiv[tDiv];
        }

        private void comboBoxSampleSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sampleSize;
            if (!int.TryParse(comboBoxSampleSize.Text, out sampleSize))
            {
                throw new Exception("Invalid sample size");
            }

            controller.SampleSize = sampleSize;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string selectedUser = listBoxUsers.Text;
            sharingController.SendMessage(selectedUser, controller.CurrentSample);

        }

        private void btnLoadReceivedSample_Click(object sender, EventArgs e)
        {
            var receivedSample = listBoxSamples.SelectedItem as ReceivedSample;

            var existingSeries = chartMain.Series.FirstOrDefault(series => series.Name.Equals(receivedSample.ToString()));
            if (null != existingSeries)
            {
                return;
            }

            Random random = new Random();
            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColor = colors[random.Next(colors.Length)];

            var newSeries = new Series
            {
                ChartType = SeriesChartType.FastLine,
                Name = receivedSample.ToString(),
                Color = Color.FromKnownColor(randomColor),
                //LabelForeColor=randomColor,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                IsValueShownAsLabel = true
            };

            for (int i = 0; i < receivedSample.Sample.Limit; ++i)
            {
                double value = receivedSample.Sample.Get(i);
                newSeries.Points.AddXY(i, value);
            }

            chartMain.Series.Add(newSeries);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtUserName.Text = sharingController.UserName;

            listBoxUsers.DataSource = sharingController.UsersConnected;
            listBoxSamples.DataSource = sharingController.ReceivedSamples;
        }

        private void comboBoxDataProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxSampleSize.SelectedIndex == 0)
            //{
            //    textBoxPort.Enabled = true;
            //}
            //else
            //{
            //    textBoxPort.Enabled = false;
            //}
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            sharingController.Disconnect();
        }

        private void listBoxSamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSamples.SelectedIndex != -1)
            {
                btnLoadReceivedSample.Enabled = true;
            }
            else
            {
                btnLoadReceivedSample.Enabled = false;
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1)
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }
        }
    }
}
