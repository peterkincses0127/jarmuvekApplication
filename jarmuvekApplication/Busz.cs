using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmuvekApplication
{
    class Busz : Gepjarmu
    {
        public Busz(double uzemanyag, int kerekekszama, string rendszam) : base(uzemanyag, 6, rendszam)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
