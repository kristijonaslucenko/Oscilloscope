using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oscilloscope.DataHandlers
{
    public class RandomDataHandler : BaseDataHandler
    {
        private Random random;

        public RandomDataHandler()
        {
            random = new Random();
        }

        protected override double ReadData()
        {
            Thread.Sleep(10);

            return random.Next(0, (int)Math.Pow(2, 10)) * 0.0049;
        }
    }
}
