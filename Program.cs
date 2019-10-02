using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, r;

            Console.WriteLine("Der ggt von zwei ganzen Zahlen soll berechnet werden");
            Console.WriteLine("Erste Zahl eingeben:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zweite Zahl eingeben:");
            b = Convert.ToInt32(Console.ReadLine());

        r = 1;
        while (r != 0)
        {
            r = a % b;
            a = b;
            b = r;
        }
            Console.WriteLine("Der ggT ist:{0}", a);
        }
    }
}




static int ggT(int a0, int b0)
{
     int r = 1;
     while (r != 0)
    {
         r = a0 % b0;
         a0 = b0;
         b0 = r;
    }
    return a0;
}




static int kgV(int a1, int b1)
{
    return a1 * b1 / ggT(a1, b1);
}