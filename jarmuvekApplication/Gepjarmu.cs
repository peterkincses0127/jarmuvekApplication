using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmuvekApplication
{
    abstract class Gepjarmu
    {
        private double uzemanyag;
        private int kerekekszama;
        private string rendszam;

        protected Gepjarmu(double uzemanyag, int kerekekszama, string rendszam)
        {
            this.uzemanyag = uzemanyag;
            this.kerekekszama = kerekekszama;
            this.rendszam = rendszam;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", uzemanyag,kerekekszama,rendszam);
        }
    }
}
