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


namespace Osciloskopas
{
     
    public struct TKomplex
    {
        public double real;
        public double imag;
    }
        public class TFftAlgorithm
        {
            public TKomplex res;
            public int N;
            public double[] xw;
            public TKomplex[] y, x;
            public TKomplex[] we;
 

            public TKomplex ksum(TKomplex a, TKomplex b)
            {
                res.real = a.real + b.real;
                res.imag = a.imag + b.imag;
                return (res);
            }

            public TKomplex kdiff(TKomplex a, TKomplex b)
            {
                res.real = a.real - b.real;
                res.imag = a.imag - b.imag;
                return (res);
            }

            public TKomplex kprod(TKomplex a, TKomplex b)
            {
                res.real = a.real * b.real - a.imag * b.imag;
                res.imag = a.real * b.imag + a.imag * b.real;
                return (res);
            }

            public TFftAlgorithm(int nbOfSamples)
            {
                int i;
                N = nbOfSamples;
                x = new TKomplex[N + 1];
                y = new TKomplex[N + 1];
                xw = new double[N + 1];
                we = new TKomplex[N / 2];
                for (i = 0; i < (N / 2); i++)  // Init look up table for sine and cosine values
                {
                    we[i].real = Math.Cos(2* Math.PI * (double)(i) / (double)(N));
                    we[i].imag = Math.Sin(2* Math.PI * (double)(i) / (double)(N));
                }
            }

            public void BitInvert(TKomplex[] a, int n)
            {  // invert bits for each index. n is number of samples and a the array of the samples
                int i, mv = n/2;
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


            public void CalcSubFFT(TKomplex[] a, int n)
            {
                int i, k, m;
                TKomplex w;
                TKomplex v;
                TKomplex h;
                k = 1;
                while (k <= n/2)
                {
                    m = 0;
                    while (m <= (n-2*k))
                    {
                        for (i = m; i < m + k; i++)
                        {
                            // sine and cosine values from look up table
                            w.real = we[((i-m)*N / k/ 2)].real;
                            w.imag = we[((i-m)*N / k / 2)].imag;
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

            public void CalcFFT()
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

            public void InvDFT()    // invers Fourier transformation
            {                       // rebuild the signal in real numbers
                int i, k;
                for (k = 0; k < N; k++)
                {
                    xw[k] = 0;
                    for (i = 0; i < 30; i++)    // we only take the first 30 fourier components
                    {
                        xw[k] = xw[k] + (y[i].real * Math.Cos(2.0 * Math.PI * (double)(i * k) / (double)(N)) +
                                         y[i].imag * Math.Sin(2.0 * Math.PI * (double)(i * k) / (double)(N)));
                    }
                }
            }

            
        }
}