using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frazioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frazione f = new Frazione(4,16);
            int macd = f.Mcd();
            int nn; int dd;
            f.semplificafrazione(macd, out nn,out dd);  
            Frazione semplificata=new Frazione(nn,dd);
            Frazione pa= Frazione.Parse(semplificata.ToString());
            Console.WriteLine(pa);
            Console.ReadLine();
        }
    }
}
