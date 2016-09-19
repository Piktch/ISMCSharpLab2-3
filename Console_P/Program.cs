using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P
{
    class Program
    {
        static void Main(string[] args)
        {
            Double p=0.5,v,f;
            int it=100000000;
           //------------------   1   ----------------------------
            p = Math.Sqrt(p);
            v = p;
            for (int i = 0; i < it; i++)
            {
                v = Math.Sqrt(v / 2 + 0.5);
                p = p * v;

            }
            p = 2 / p;
            Console.WriteLine("P1="+p);

            //-------------------  2  ----------------------
            p = 1;
            for (double i = 1; i <= it*2; i+=2)
            {
                v = (i * (i + 2)) / ((i + 1) * (i + 1));
                p = p * v;
                //Console.WriteLine(i + "    "  +v);
            }
            p = 2 / p;
            Console.WriteLine("P2=" + p);
            //------------------  3   ------------------------
            v = (it*2+3)/2; p = 0;
            for (double i = it*2-1; i >2; i-=2 )
            {
                p = 2 + (i * i) / v;
                v = p;
                //Console.WriteLine(i + "    "  +v);
            }

            p = 1 + 1 / v;

            p =4 / p;
            Console.WriteLine("P3=" + p);
            //------------------  4  --------------------------
            p = 0;
            for (double i = 1; i <= it*4; i +=4)
            {
                v = 1 / i;
                f = 1 / (i + 2);
                v-=f;
                p += v;
                //Console.WriteLine(i + "    "  +v);
            }
            p = p*4;
            Console.WriteLine("P4=" + p);
            Console.ReadLine();
            return;
            Console.ReadLine();
        }
    }
}
