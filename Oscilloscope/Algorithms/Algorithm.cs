using Oscilloscope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope.Algorithms
{
    interface IAlgorithm
    {
        double[] Calculate(Sample currentSample, int noOfHarmonics, int sampleRate, out string harmonicsTable, out int fundamentalFrequency);
    }
}
