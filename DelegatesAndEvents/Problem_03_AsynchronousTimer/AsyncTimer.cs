using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_03_AsynchronousTimer
{
    public class AsyncTimer
    {
        private readonly Action<int> method;
        private int ticks;
        private int interval;

        public AsyncTimer(Action<int> method,int ticks,int interval)
        {
            this.method = method;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ticks","Seconds should be bigger than 0 !");
                }
                this.ticks = value;
            }
        }

        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("interval", "Sleep time should be bigger than 0 !");
                }
                this.interval = value;
            }
        }


        public void ExecuteAction()
        {
            Thread parallelThread = new Thread(this.TicTak);
            parallelThread.Start();
        }

        private void TicTak()
        {
            for (int i = this.Ticks-1; i > 0; i--)
            {
                Thread.Sleep(this.Interval);

                this.method(i);
            }
            
        }

    }
}
