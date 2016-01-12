using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osciloskopas
{
    public class Sample<T>
    {
        ConcurrentQueue<T> q = new ConcurrentQueue<T>();

        public int Limit { get; set; }
        public void Enqueue(T obj)
        {
            q.Enqueue(obj);
            lock (this)
            {
                T overflow;
                while (q.Count > Limit && q.TryDequeue(out overflow)) ;
            }
        }
        public T GetMax()
        {
            return q.Max();
        }
        public T GetMin()
        {
            return q.Min();
        }
        public T Get(int index)
        {
            return q.ElementAtOrDefault(index);
        }
    }
}
