using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b,p=1,t;
            Console.Write("Enther A=");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Enther B=");
            b = Double.Parse(Console.ReadLine());
            if (b < a)
            {
                t = a;
                a = b;
                b = t;
            }
            for (Double i = a; i <= b; i++)
            {
                p = p * i;
            }
            Console.WriteLine("P="+p);
        }
    }
}
