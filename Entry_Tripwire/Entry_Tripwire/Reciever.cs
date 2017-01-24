using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry_Tripwire
{
    class Reciever
    {
        protected Random rand;
        Sender s1, s2, s3;

        public Reciever()
        {
            rand = new Random();
            s1 = new Sender(rand, "josh");
            s2 = new Sender(rand, "Wade");
            s3 = new Sender(rand, "Aimon");
            s1.Arrived += s1_Arrived;
            s2.Arrived += s1_Arrived;
            s3.Arrived += s1_Arrived;
        }

        void s1_Arrived(string Name)
        {
            Console.WriteLine(Name + " walked their late ass in");

        }

    }
}
