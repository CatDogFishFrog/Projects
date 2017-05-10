using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Number 7
namespace Function
{
    class Program
    {
        static double yfunc(double a, double b, double x) //y
        {
            double niim1 = Math.Pow((Math.Sin(Math.Pow(((x * x) + a), 2))), 3);
            double niim2 = Math.Sqrt(x / b);
            return niim1 - niim2;
        }

        static double zfunc(double a, double b, double x)
        {
            double niil1 = ((x * x) / a);
            double niil2 = Math.Cos(Math.Pow((x + b), 3));
            return niil1 + niil2;
        }

        static void Main(string[] args)
        {
            double a = 1.1, b = 0.04, x = 0.2, y, z;
            y=yfunc(a, b, x);
            Console.WriteLine("y = " +y);
            z = zfunc(a, b, x);
            Console.WriteLine("z = " + z);
            Console.ReadLine();
        }
    }
}
