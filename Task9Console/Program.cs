using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9Console
{
    class Program
    {
        static void Main(string[] args)
        {
                int n,i;
                float v=0;
                float[] x=new float[1005];
                float[] y=new float[1005];
                n=int.Parse(Console.ReadLine());
                for(i=0;i<n;i++)
                {
                    x[i]=float.Parse(Console.ReadLine());
                    y[i]=float.Parse(Console.ReadLine());
                }
                x[i]=x[0];
                y[i]=y[0];
                for(i=0;i<n;i++)
                {
                    v+=(y[i]+y[i+1])/2*(x[i+1]-x[i]);
                    //cout<<(y[i]+y[i+1])/2*(x[i+1]-x[i])<<endl;
                }
                //cout<<endl;
                Console.WriteLine("S="+v);
        }
    }
}
