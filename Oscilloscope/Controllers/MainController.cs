using Oscilloscope.DataHandlers;
using Oscilloscope.Models;
using Oscilloscope.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oscilloscope.Controllers
{
    internal class MainController
    {
        public BaseDataHandler DataHandler
        {
            get;
            private set;
        }

        public Sample CurrentSample
        {
            get
            {
                return DataHandler.CurrentSample;
            }
        }

        public int CurrentSampleRate
        {
            get;
            private set;
        }

        public double ScaleCoeff { get; set; }
        public double Offset { get; set; }

        public int SampleSize
        {
            get
            {
                return DataHandler.CurrentSample.Limit;
            }
            set
            {
                DataHandler.CurrentSample.Limit = value;
            }
        }

        public MainController()
        {
            //DataHandler = new SerialDataHandler();
            DataHandler = new RandomDataHandler();
            DataHandler.SampleRateUpdated += SerialHandler_SampleRateUpdated;

            ScaleCoeff = 1;
            Offset = 0;
            SampleSize = 4096;
        }

        public void Start(int port)
        {
            DataHandler.Open(port);
        }

        public void Stop()
        {
            DataHandler.Close();
        }


        public void ShowAnalysis()
        {
            AnalysisForm analysisForm = new AnalysisForm(DataHandler.CurrentSample, DataHandler.SampleRate);
            analysisForm.ShowDialog();
        }

        private void SerialHandler_SampleRateUpdated(object sender, SampleRateUpdatedEventArgs e)
        {
            CurrentSampleRate = e.SampleRate;
        }

        public double ScaleValue(double value)
        {
            return value * ScaleCoeff + Offset;
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

        //}


    }
}
