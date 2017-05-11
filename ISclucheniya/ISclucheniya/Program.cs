using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISclucheniya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k в преелах 0...10");
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            double[] f = new double[10];
            try
            {
                for(int x=0; x<k; x++)
                {
                    f[x] = (double)1 / (x - 5);
                    Console.WriteLine("x={0}, f[x]={1}", x, f[x]);
                }
            }
            catch(DivideByZeroException e)
            {

            }
        }
    }
}
