using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osciloskopas
{
    public partial class AnalysisForm : Form
    {
        public int qLimit;
        public Sample<double> queue1 = new Sample<double> { }; 
        private int noOfHarmonics;
        public double[] HanWindow;
        public double[] WindowedSignal;
        public double[] idftSignal;

        private Sample<double> currentSample;
        public int sampleRate;

        public AnalysisForm(Sample<double> currentSample, int sampleRate)
        {
            InitializeComponent();

            this.currentSample = currentSample;
            this.sampleRate = sampleRate;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            noOfHarmonics = Int32.Parse(comboBox1.SelectedItem.ToString());

            TFftAlgorithm FFT_transform = new TFftAlgorithm(qLimit);
            BuildHanWindow();
            ApplyWindow();

            idftSignal = new double[qLimit];

            for (int i = 0; i < qLimit; i++)
            {
                FFT_transform.y[i].real = WindowedSignal[i];
                FFT_transform.y[i].imag = 0;
            }

            FFT_transform.CalcFFT();
            FFT_transform.InvDFT();

            chart1.Series[0].Points.Clear();
            //chart1.Series[1].Points.Clear();

            String harmonics = String.Format("{0,5} {1,20} {2,20} {3,20}\n\n", "#", "Real part", "Imaginary part", "Magnitude");

             

            for (int i = 0; i < FFT_transform.N; i++)
            {
                if(i < noOfHarmonics)
                {
                    harmonics += String.Format("{0,5} {1,20} {2,20} {3,20}\n", i, Math.Round(FFT_transform.y[i].real,6), Math.Round(FFT_transform.y[i].imag,6), 
                    Math.Round(Math.Sqrt(Math.Pow(FFT_transform.y[i].real, 2) + Math.Pow(FFT_transform.y[i].imag, 2)),6));

                    chart1.Series[0].Points.AddXY(i, 10 * Math.Log10(Math.Pow(CalcMagnitude(FFT_transform.y[i].real, FFT_transform.y[i].imag), 2)));
                }

                //chart1.Series[0].Points.AddXY(i, CalcMagnitude(FFT_transform.y[i].real, FFT_transform.y[i].imag));
               idftSignal[i] = FFT_transform.xw[i];
                //
            }


            double[] magnitudes = new double[queue1.Limit];

            for (int i = 0; i < magnitudes.Length/2; i++)
            {
                magnitudes[i] = Math.Sqrt(Math.Pow(FFT_transform.y[i].real, 2) + Math.Pow(FFT_transform.y[i].imag, 2));
            }

            int max = FindMaxIndex(magnitudes);

            int max_freq = (int)((float)sampleRate * (float)max / (float)queue1.Limit);

            HarmonicsTextBox1.Text = harmonics;
            label3.Text = max_freq.ToString();
        }

        private static double CalcMagnitude(double real, double imag)
        {
            return Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imag, 2));
        }
        private static int FindMaxIndex(double[] data)
        {

            int max = 0;
            //Find the maximum point

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > data[max])
                {
                    max = i;
                }
            }
            return max;
        }
        public void BuildHanWindow()
        {
            HanWindow = new double[queue1.Limit];
            for (int i = 0; i < queue1.Limit; i++)
            {
                HanWindow[i] = .5 * (1 - Math.Cos(2 * Math.PI * i / (queue1.Limit - 1.0)));
            }
        }
        public void ApplyWindow()
        {
            WindowedSignal = new double[queue1.Limit];

            for (int i = 0; i < queue1.Limit; i++)
            {
                WindowedSignal[i] = queue1.Get(i);
                WindowedSignal[i] *= HanWindow[i];
            }
            
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            noOfHarmonics = Int32.Parse(comboBox1.SelectedItem.ToString());
        }

        private void idft_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < qLimit; i++)
            {
                  //chart1.Series[0].Points.AddXY(i, CalcMagnitude(FFT_transform.y[i].real, FFT_transform.y[i].imag));

                chart1.Series[0].Points.AddXY(i, idftSignal[i]);
                //
            }
        }
        }
    }

