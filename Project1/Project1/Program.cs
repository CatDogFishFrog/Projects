using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cns = 768;
            Console.WriteLine(cns);
            Console.WriteLine("Hello world!");
            int first = Convert.ToInt32(Console.ReadLine());
            int thecond = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum is: " + (first + thecond) + "\nMultiply is: " + (first * thecond));
            Console.ReadKey();
        }
    }
}
