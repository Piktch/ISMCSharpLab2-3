using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, d, v, x1, x2;
            Console.Write("Enther a:");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Enther b:");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Enther c:");
            c = Double.Parse(Console.ReadLine());
            d = b * b - 4 * a * c;
            Console.WriteLine("D=" + d);
            if (d > 0)
            {
                x1 = (b * (-1) - Math.Sqrt(d)) / (2 * a);
                x2 = (b * (-1) + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1="+x1+"\nx2="+x2);
            }
            else
                if (d == 0)
                {
                    x1 = (b * (-1)) / (2 * a);
                    Console.WriteLine("x1=" + x1);
                }
                else
                {
                    Console.WriteLine("Немаэ розв'язків.");
                }
        }
    }
}
