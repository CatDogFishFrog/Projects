using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndSame
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 0;
            double x = 0.1;

            for (i = 1; i < 100; i++)
            {
                Console.WriteLine((Math.Pow((-1), i) * (Math.Pow((2 * x), (2 * i)) / facter(2, i))));
            }
            Console.ReadKey();
        }
       static public double facter(int numb, double a)
        {
            double res=1;
            for(double i=numb*a; i>0; i--)
            {
                res *= i;
            }
            return res*a;
            
        }
    }
}
