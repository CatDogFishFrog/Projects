using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicheskieOperatory
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -16, i1 = 10, i2 = 16;
            bool b = true;
            int j = 4;
            Console.WriteLine("Операция НЕ - Not\n");
            Console.WriteLine("Операнд = {0}", b);
            Console.WriteLine("Not(Операнд) = {0}", !b);
            Console.WriteLine("\nОперация ИЛИ - OR");
            i = i1 | i2;
            Console.WriteLine("\nОперанды = {0}, {1}", i1, i2);
            Console.WriteLine("(Оп1)OR(Оп2) = {0}", i);
            Console.WriteLine("\nОперация И - AND");
            i = i1 & i2;
            Console.WriteLine("\nОперанды = {0}, {1}", i1, i2);
            Console.WriteLine("(Оп1)AND(Оп2) = {0}", i);
            Console.WriteLine("\nОерации исключающие ИЛИ - XOR\n");
            i = i1 ^ i2;
            Console.WriteLine("Операнды = {0}, {1}", i1, i2);
            Console.WriteLine("(Оп1)XOR(Оп2) = {0}", i);
            Console.WriteLine("\nЛогический сдвиг");
            Console.WriteLine("\nИсходное число = {0}", i);
            i = i1 >> j;
            Console.WriteLine("Сдвиг вправо на 4 бита = {0}", i);
            i = i1 << j;
            Console.WriteLine("Сдвиг влево на 4 бита = {0}", i);
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();

        }
    }
}
