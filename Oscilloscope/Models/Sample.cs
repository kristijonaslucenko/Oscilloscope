using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope.Models
{
    public class Sample
    {
        ConcurrentQueue<double> q = new ConcurrentQueue<double>();
        public List<double> Q
        {
            get
            {
                return q.ToList();
            }
            set
            {
                q = new ConcurrentQueue<double>(value);
            }
        }

        public int Limit { get; set; }

        public Sample()
        {
        }

        public void Enqueue(double obj)
        {
            q.Enqueue(obj);
            lock (this)
            {
                double overflow;
                while (q.Count > Limit && q.TryDequeue(out overflow)) ;
            }
        }
        public double GetMax()
        {
            return q.Max();
        }
        public double GetMin()
        {
            return q.Min();
        }
        public double Get(int index)
        {
            return q.ElementAtOrDefault(index);
        }
    }
}
