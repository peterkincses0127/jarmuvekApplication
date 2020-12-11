using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmuvekApplication
{
    class Szemelyauto : Gepjarmu
    {
        public Szemelyauto(double uzemanyag, int kerekekszama, string rendszam) : base(uzemanyag, 4, rendszam)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
