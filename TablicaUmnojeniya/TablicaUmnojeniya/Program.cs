using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaUmnojeniya
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a=1; a<16; a++)
            {
                for(int b=1; b<16; b++)
                {
                    if (b == 15)
                    {
                        Console.WriteLine(a * b+"\n");
                    }
                    else
                    {
                        Console.Write(a * b+"\t");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
