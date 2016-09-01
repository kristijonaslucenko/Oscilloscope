using Oscilloscope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope.ServiceHandlers
{
    public class ReceivedSample
    {
        private DateTime dateCreated;

        private string username;

        public Sample Sample
        {
            get;
        }

        public ReceivedSample(string username, Sample sample)
        {
            dateCreated = DateTime.Now;
            this.username = username;
            Sample = sample;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", username, dateCreated.ToString("hh:mm:ss"));
        }
    }
}
