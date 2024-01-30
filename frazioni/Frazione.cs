using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frazioni
{
    internal class Frazione { 
        public int numeratore { get; set; }
        public int denominatore { get; set; }
        public Frazione() { }
        public Frazione(int num, int den) { 
            numeratore= num;
            denominatore = den;
        }
        public int Mcd()
        { int c = 1;
            int mcd = 1;
            while (c <= numeratore && c <= denominatore)
            {
                if (numeratore % c == 0 && denominatore % c == 0)
                { mcd = c; }
                c++;
            }
            return mcd; 
        }
        public void semplificafrazione(int macd, out int nn, out int dd)
        {   nn=numeratore/macd;
            dd = denominatore /macd;
            return;
        }
        public override string ToString() {
            return String.Format("{0},{1}", numeratore, denominatore);
        }
        public static Frazione Parse(string fraz) {
            int a = int.Parse(fraz.Substring(0,1));
            int b = int.Parse((fraz.Substring(2,1)));
            Frazione p= new Frazione(a,b);
            return p;

        }

    }
}
