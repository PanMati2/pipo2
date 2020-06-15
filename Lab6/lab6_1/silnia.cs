using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    public class Silnia
    {
        public int Oblicz(int n)
        {
            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik *= i;
            }
            return wynik;
        }
    }
}
