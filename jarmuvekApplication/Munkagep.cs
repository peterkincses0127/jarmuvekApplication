using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmuvekApplication
{
    class Munkagep : Gepjarmu
    {
        public Munkagep(double uzemanyag, int kerekekszama, string rendszam) : base(uzemanyag, 8, rendszam)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
