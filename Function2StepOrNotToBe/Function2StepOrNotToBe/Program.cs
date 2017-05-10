using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5 задание
namespace Function2StepOrNotToBe
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 2.3;
            for (double x = 0.2; x < 3; x += 0.4) {
                if (x <= 1)
                {
                    Console.WriteLine("When x = "+x+",\t y = "+(1.5 * Math.Pow(Math.Cos(x), 2)));
                }
                if (x<1 && x<2)
                {
                    Console.WriteLine("When x = " + x + ",\t y = " + (Math.Pow((x - 2), 2) + 6));
                }
                if (x > 2)
                {
                    Console.WriteLine("When x = " + x + ",\t y = " + (3 * Math.Tan(x)));
                }   
            }
            Console.ReadLine();
        }
    }
}
