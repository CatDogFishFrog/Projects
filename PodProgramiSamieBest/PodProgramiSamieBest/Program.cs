using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodProgramiSamieBest
{
    class Program
    {
        static int NOD (int x, int y)
        {
            if (x != 0)
                return NOD((y % x), x);
            else
                return y;
        }

        static int NOK (int x, int y)
        {
            return (x / NOD(x, y)) * y;
        }

        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введиет 3 целых числа:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nНаименьшее общее делимое двух целых чисел:");
            Console.WriteLine("NOK {0}, {1} = {2}", a, b, NOK(a, b));
            Console.WriteLine("NOK {0}, {1} = {2}", a, c, NOK(a, c));
            Console.WriteLine("NOK {0}, {1} = {2}", b, c, NOK(b, c));
            Console.WriteLine("\nНаибольшие общие делители двух целых чисел:");
            Console.WriteLine("NOD {0}, {1} = {2}", a, b, NOD(a, b));
            Console.WriteLine("NOD {0}, {1} = {2}", a, c, NOD(a, c));
            Console.WriteLine("NOD {0}, {1} = {2}", b, c, NOD(b, c));
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
