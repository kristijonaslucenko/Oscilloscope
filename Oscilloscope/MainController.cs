using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Osciloskopas
{
    public delegate void SampleRateUpdatedDelagate (int sampleRate);

    internal class MainController
    {
        private frmClient f2 = new frmClient();
        private Random randomGen = new Random();
        private KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        // static KnownColor randomColorName = names[randomGen.Next(names.Length)];

        private SerialHandler serialHandler;

        private int SampleCounter;
        private int SampleRate;

        private Timer sampleRateMeasureTimer;

        public Sample<double> CurrentSample { get; set; }

        public double ScaleCoeff { get; set; }
        public double Offset { get; set; }

        public int SampleSize
        {
            get
            {
                return CurrentSample.Limit;
            }
            set
            {
                CurrentSample.Limit = value;
            }
        }

        private Thread readThread;

        public MainController()
        {
            serialHandler = new SerialHandler("COM6");
            ScaleCoeff = 1;
            Offset = 0;
            SampleSize = 4096;
            SampleCounter = 0;
        }

        private static void SampleRateCounterTimerTickCallback(object state)
        {
            var controller = state as MainController;

            controller.SampleRate = controller.SampleCounter;

            controller.SampleCounter = 0;

            //// Instantiation
            //SampleRateUpdatedDelagate sampleRateUpdatedDelegate = new SampleRateUpdatedDelagate(MyFunc);

            //// Invocation
            //simpleDelegate(controller.SampleRate);
        }

        public void Start(int port)
        {
            StartSerialConnection(port);
            StartSampleRateMeasure();
        }

        public void Stop()
        {
            StopSerialConnection();
        }

        private bool stopped;
        private void StartSerialConnection(int port)
        {
            serialHandler = new SerialHandler("COM" + port);
            serialHandler.Open();

            if (serialHandler._continue == true)
            {
                stopped = false;

                readThread = new Thread(DoRead);
                readThread.Start();
            }
        }

        private void StopSerialConnection()
        {
            stopped = false;

            serialHandler.Close();
        }

        private void StartSampleRateMeasure()
        {
            sampleRateMeasureTimer = new Timer(SampleRateCounterTimerTickCallback, this, 0, 1000);
        }

        private void StopSampleRateMeasure()
        {
            sampleRateMeasureTimer.Change(Timeout.Infinite, Timeout.Infinite);
        }


        private void DoRead()
        {
            while (!stopped)
            {
                double value = serialHandler.ReadData();
                value = value * ScaleCoeff + Offset;

                SampleCounter++;

                CurrentSample.Enqueue(value);
            }
        }

        public void ShowAnalysis()
        {
            AnalysisForm analysisForm = new AnalysisForm(CurrentSample, SampleRate);
            analysisForm.ShowDialog();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (f2.readyFlag == true)
        //    {
        //        makeNewSeries(f2.lastName, "");
        //        chartMain.Series.FindByName(f2.lastName).Points.Clear();
        //        queue.Limit = 4096;
        //        chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = 4096 / 6;
        //        for (int i = 0; i < f2.queue_received.Limit; ++i)
        //        {
        //            double value = f2.queue_received.Get(i);

        //            chartMain.Series[2].Points.AddXY(i, value);
        //        }
        //        f2.readyFlag = false;
        //    }
        //    if (!stopped)
        //    {
        //        label1.Text = "Samples per second: " + sampleCounter.ToString();
        //        sampleCounter = 0;
        //    }
        //}


    }
}
