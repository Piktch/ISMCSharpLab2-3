using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n, p = 0;
            Console.Write("Enther N=");
            n = Double.Parse(Console.ReadLine());
            while (n == 0)
            {
                Console.WriteLine("Incorrect input");
            }
            for (Double i = 1; i <= n; i++)
            {
                p = p + 1.0 / i;
            }
            Console.WriteLine("S=" + p);
        }
    }
}
