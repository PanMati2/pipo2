using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczby
{
    class Program
    {
        static void Main(string[] args)
        {
            var L1 = new liczby();
            var L2 = new liczby();
            L1.setA(1);
            L1.setB(2);
            L1.setC(3);
            L2.setA(4);
            L2.setB(5);
            L2.setC(6);

            var LL1 = new lepsze_liczby();
            LL1.setA(0);
            LL1.setB(1);
            LL1.setC(2);
            LL1.setD(3);

            Console.WriteLine(LL1.getA() + " " + LL1.getB() + " " + LL1.getC() + " " + LL1.getD());
            Console.ReadKey();
        }
    }
}
