using Oscilloscope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope.Algorithms
{
    public class IDFTAlgorithm : FFTAlgorithm
    {
        private double[] xw;

        public override double[] Calculate(Sample currentSample, int noOfHarmonics, int sampleRate, out string harmonicsTable, out int fundamentalFrequency)
        {
            base.Calculate(currentSample, noOfHarmonics, sampleRate, out harmonicsTable, out fundamentalFrequency);
            InvDFT();

            return xw;
        }

        /// <summary>
        /// invers Fourier transformation
        /// rebuild the signal in real numbers
        /// </summary>
        private void InvDFT()
        {
            xw = new double[N + 1];

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
