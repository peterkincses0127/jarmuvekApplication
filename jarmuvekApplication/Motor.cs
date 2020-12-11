using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmuvekApplication
{
    class Motor : Gepjarmu
    {
        public Motor(double uzemanyag, int kerekekszama, string rendszam) : base (uzemanyag,2,rendszam)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
