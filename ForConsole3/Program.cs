using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, n, s=1;
            Console.Write("Enther A=");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Enther N=");
            n = Double.Parse(Console.ReadLine());
            for (Double i = 1; i <= Math.Abs(n); i++)
            {
                s *= a;
            }
            if (n < 0)
            {
                s = 1.0 / s;
            }
            Console.WriteLine("A^n=" + s);
        }
    }
}
