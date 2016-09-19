using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n, b, p = 1, t=0;
            Console.Write("Enther N=");
            n = Double.Parse(Console.ReadLine());
            for (Double i = 1; i <= n; i++)
            {
                b = 1;
                for (int j = 1; j <=i; j++)
                {
                    b = b * j;
                }
                t += b;
            }
            Console.WriteLine("S=" + t);
        }
    }
}
