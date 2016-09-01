using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oscilloscope.Algorithms;
using Oscilloscope.Models;

namespace Oscilloscope.Controllers
{
    internal class AnalysisController
    {
        private Sample currentSample;
        private int sampleRate;

        private IAlgorithm fftAlgoritm;
        private IAlgorithm idftAlgorithm;

        public AnalysisController(Sample currentSample, int sampleRate)
        {
            this.currentSample = currentSample;
            this.sampleRate = sampleRate;

            fftAlgoritm = new FFTAlgorithm();
            idftAlgorithm = new IDFTAlgorithm();
        }

        internal double[] CalculateIDFT(int noOfHarmonics, out string harmonicsTable, out int fundamentalFrequency)
        {
            return fftAlgoritm.Calculate(currentSample, noOfHarmonics, sampleRate, out harmonicsTable, out fundamentalFrequency);
        }

        internal double[] CalculateHarmonics(int noOfHarmonics, out string harmonicsTable, out int fundamentalFrequency)
        {
            return idftAlgorithm.Calculate(currentSample, noOfHarmonics, sampleRate, out harmonicsTable, out fundamentalFrequency);
        }

    }
}
