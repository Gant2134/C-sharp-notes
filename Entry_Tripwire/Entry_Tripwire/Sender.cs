using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Entry_Tripwire
{

    public delegate void ArrivedHandler(string Name);


    class Sender
    {
        
        protected Timer tmr;
        public event ArrivedHandler Arrived;
        public string name;

        public Sender(Random rand, string name)
        {
            this.name = name;
            tmr = new Timer();
            tmr.Interval = rand.Next(1000, 10000);
            tmr.Elapsed += tmr_Elapsed;
            tmr.Start();
        }

        void tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmr.Stop();
            if (Arrived != null)
            {
                Arrived(name);
            }
        }


    }
}
