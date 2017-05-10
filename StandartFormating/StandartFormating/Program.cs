using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartFormating
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = -12.345678956789;
            int i = 123456789;
            Console.Write("Числр с плавающей точкой   ");
            Console.WriteLine(d);
            Console.Write("\nG формат - общий        \t");
            Console.WriteLine("{0,8:G}", d);
            Console.Write("F формат - с фиксю точкой \t");
            Console.WriteLine("{0,8:F}", d);
            Console.Write("N формат - числовой       \t");
            Console.WriteLine("{0,8:N}", d);
            Console.Write("E формат - научный        \t");
            Console.WriteLine("{0,8:E}", d);   
            Console.Write("C формат - денежный       \t");
            Console.WriteLine("{0,8:C}", d);
            Console.Write("Р формат - процентный     \t");
            Console.WriteLine("{0,8:P}", d);

            Console.WriteLine("\nЧисло целое          "+i+"\n");
            Console.Write("D формат - десятичный     \t");
            Console.WriteLine("{0,8:D}", i);
            Console.Write("С формат - денежный       \t");
            Console.WriteLine("{0,8:С}", i);     
            Console.Write("Р формат - процентный     \t");
            Console.WriteLine("{0,8:P}", i);
            Console.Write("X формат - 16-ричный      \t");
            Console.WriteLine("{0,8:X}\n", i);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();




        }
    }
}
