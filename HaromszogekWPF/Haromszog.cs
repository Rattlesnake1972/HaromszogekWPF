using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogekWPF
{
    class Haromszog
    {
        public int A { get; private set; }
        public int B { get; private set; }
        public int C { get; private set; }

        public Haromszog(string sor)
        {
            string[] darabok = sor.Split(' ');
            this.A = Convert.ToInt32(darabok[0]);
            this.B = Convert.ToInt32(darabok[1]);
            this.C = Convert.ToInt32(darabok[2]);
        }
    }
}
