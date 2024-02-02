using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuliaTiaStoian_ClassesWithLight
{
    internal class Candelabru
    {
        private BecReglabil[] _becuri;

        public bool Aprins
        {
            get
            {
                foreach (BecReglabil bec in _becuri) { if (bec.Aprins) { return true; } }
                return false;
            }
        }

        public int PutereCurenta
        {
            get
            {
                int sum = 0;
                foreach (BecReglabil bec in _becuri) { sum += bec.CurrentPower;  }
                return sum;
            }
        }

        public int PutereMaxima
        {
            get
            {
                int sum = 0;
                foreach (BecReglabil bec in _becuri) { sum += bec.MaxPower; }
                return sum;
            }
        }

        public Candelabru(params int[] maxPowers)
        {
            _becuri = new BecReglabil[maxPowers.Length];

            for (int i = 0; i < maxPowers.Length; ++i) { _becuri[i] = new BecReglabil(0, maxPowers[i]); }
        }

        public void Aprinde() { foreach (BecReglabil bec in _becuri) { bec.Aprinde(); } }
        public void Stinge() { foreach (BecReglabil bec in _becuri) { bec.Stinge(); } }
        public void MaresteLumina(int value) { foreach(BecReglabil bec in _becuri) { bec.MaresteLumina(value); } }
        public void ReduceLumina(int value) { foreach(BecReglabil bec in _becuri) { bec.ReduceLumina(value); } }
}
}
