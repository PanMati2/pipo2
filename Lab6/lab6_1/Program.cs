using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Silnia liczba = new Silnia();
            String line;
            int n;

            Console.WriteLine("Podaj dla jakiej liczby obliczyc silnie:");
            line = Console.ReadLine();
            n = int.Parse(line);

            Console.WriteLine(n + "! = " + liczba.Oblicz(n));
            Console.ReadLine();
        }
    }
}
