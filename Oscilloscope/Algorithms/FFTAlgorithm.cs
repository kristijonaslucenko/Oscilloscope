using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;
using System.Diagnostics;
using Oscilloscope.Models;

namespace Oscilloscope.Algorithms
{

    public struct TKomplex
    {
        public double real;
        public double imag;
    }

    public class FFTAlgorithm : IAlgorithm
    {
        private TKomplex res;
        protected int N;
        protected TKomplex[] y, x;
        private TKomplex[] we;

        public FFTAlgorithm()
        {
        }

        public virtual double[] Calculate(Sample currentSample, int noOfHarmonics, int sampleRate, out string harmonicsTable, out int fundamentalFrequency)
        {
            Initialize(currentSample);

            CalcFFT();

            harmonicsTable = String.Format("{0,5} {1,20} {2,20} {3,20}\n\n", "#", "Real part", "Imaginary part", "Magnitude");
            double[] harmonics = new double[noOfHarmonics];

            for (int i = 0; i < currentSample.Limit; i++)
            {
                if (i < noOfHarmonics)
                {
                    harmonicsTable += String.Format("{0,5} {1,20} {2,20} {3,20}\n", i, Math.Round(y[i].real, 6), Math.Round(y[i].imag, 6),
                    Math.Round(Math.Sqrt(Math.Pow(y[i].real, 2) + Math.Pow(y[i].imag, 2)), 6));

                    harmonics[i] = 10 * Math.Log10(Math.Pow(CalcMagnitude(y[i].real, y[i].imag), 2));
                }
            }

            fundamentalFrequency = CalculateFundamentalFrequency(currentSample, sampleRate);

            return harmonics;
        }

        private void Initialize(Sample currentSample)
        {
            N = currentSample.Limit;
            x = new TKomplex[N + 1];
            y = new TKomplex[N + 1];
            we = new TKomplex[N / 2];
            for (int i = 0; i < (N / 2); i++)  // Init look up table for sine and cosine values
            {
                we[i].real = Math.Cos(2 * Math.PI * (double)(i) / (double)(N));
                we[i].imag = Math.Sin(2 * Math.PI * (double)(i) / (double)(N));
            }

            var windowedSignal = BuildHanWindow(currentSample);

            for (int i = 0; i < currentSample.Limit; i++)
            {
                y[i].real = windowedSignal[i];
                y[i].imag = 0;
            }
        }

        private TKomplex ksum(TKomplex a, TKomplex b)
        {
            res.real = a.real + b.real;
            res.imag = a.imag + b.imag;
            return (res);
        }

        private TKomplex kdiff(TKomplex a, TKomplex b)
        {
            res.real = a.real - b.real;
            res.imag = a.imag - b.imag;
            return (res);
        }

        private double CalcMagnitude(double real, double imag)
        {
            return Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imag, 2));
        }

        private TKomplex kprod(TKomplex a, TKomplex b)
        {
            res.real = a.real * b.real - a.imag * b.imag;
            res.imag = a.real * b.imag + a.imag * b.real;
            return (res);
        }

        private void BitInvert(TKomplex[] a, int n)
        {  // invert bits for each index. n is number of samples and a the array of the samples
            int i, mv = n / 2;
            int k, rev = 0;
            TKomplex b;
            for (i = 1; i < n; i++) // run tru all the indexes from 1 to n
            {
                k = i;
                mv = n / 2;
                rev = 0;
                while (k > 0) // invert the actual index
                {
                    if ((k % 2) > 0)
                        rev = rev + mv;
                    k = k / 2;
                    mv = mv / 2;
                }

                {  // switch the actual sample and the bitinverted one
                    if (i < rev)
                    {
                        b = a[rev];
                        a[rev] = a[i];
                        a[i] = b;
                    }
                }
            }
        }

        private void CalcSubFFT(TKomplex[] a, int n)
        {
            int i, k, m;
            TKomplex w;
            TKomplex v;
            TKomplex h;
            k = 1;
            while (k <= n / 2)
            {
                m = 0;
                while (m <= (n - 2 * k))
                {
                    for (i = m; i < m + k; i++)
                    {
                        // sine and cosine values from look up table
                        w.real = we[((i - m) * N / k / 2)].real;
                        w.imag = we[((i - m) * N / k / 2)].imag;
                        // classic calculation of sine and cosine values
                        //w.real = Math.Cos( Math.PI * (double)(i-m) / (double)(k));
                        //w.imag = Math.Sin( Math.PI * (double)(i-m) / (double)(k));
                        h = kprod(a[i + k], w);
                        v = a[i];
                        a[i] = ksum(a[i], h);
                        a[i + k] = kdiff(v, h);
                    }
                    m = m + 2 * k;
                }
                k = k * 2;
            }
        }

        private void CalcFFT()
        {
            int i;
            BitInvert(y, N);
            CalcSubFFT(y, N);
            for (i = 0; i < N; i++)
            {
                y[i].imag = y[i].imag / (double)N * 2.0;
                y[i].real = y[i].real / (double)N * 2.0;
            }
            y[0].imag = y[0].imag / 2.0;
            y[0].real = y[0].real / 2.0;
        }

        private double[] BuildHanWindow(Sample currentSample)
        {
            var hanWindow = new double[currentSample.Limit];
            for (int i = 0; i < currentSample.Limit; i++)
            {
                hanWindow[i] = .5 * (1 - Math.Cos(2 * Math.PI * i / (currentSample.Limit - 1.0)));
            }

            double[] hindowedSignal = new double[currentSample.Limit];
            for (int i = 0; i < currentSample.Limit; i++)
            {
                hindowedSignal[i] = currentSample.Get(i);
                hindowedSignal[i] *= hanWindow[i];
            }

            return hindowedSignal;
        }

        private int CalculateFundamentalFrequency(Sample currentSample, int sampleRate)
        {
            double[] magnitudes = new double[currentSample.Limit];

            for (int i = 0; i < magnitudes.Length / 2; i++)
            {
                magnitudes[i] = Math.Sqrt(Math.Pow(y[i].real, 2) + Math.Pow(y[i].imag, 2));
            }

            int max = FindMaxIndex(magnitudes);

            int max_freq = (int)((float)sampleRate * (float)max / (float)currentSample.Limit);
            return max_freq;
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
    }
}