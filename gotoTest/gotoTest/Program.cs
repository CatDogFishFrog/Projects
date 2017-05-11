using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Random rand = new Random();
            int i = 0;
            I:
            a[i] = rand.Next(1000);
            Console.WriteLine(a[i]);
            i++;
            if (i < 100) goto I;

            Console.ReadKey();
        }
    }
}
