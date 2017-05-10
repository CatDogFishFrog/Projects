using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Преобразуем int в другие цельные типы:");

            int i = 200;
            Int16 i1 = (Int16)i;
            Int32 i2 = i;
            Int64 i3 = i;
            Byte i4 = (Byte)i;
            sbyte i5 = (sbyte)i;
            Console.WriteLine();
            Console.WriteLine("Типы \t{0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", "int", "int16", "int32", "int64", "Byte", "sbyte");
            Console.WriteLine("Значения{0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", i, i1, i2, i3, i4, i5);
            Console.WriteLine("Байты \t{0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", sizeof(int), sizeof(Int16), sizeof(Int32), sizeof(Int64), sizeof(Byte), sizeof(sbyte));
            Console.WriteLine("\nНажмите любую клафишу...\n");
            Console.ReadKey();

            Console.WriteLine("\nПреобразуем int в типы с плавающей точкой:\n");
            double d = i;
            Single s = i;
            Console.WriteLine("Типы\t{0,8}{1,8}{2,8}", "int", "double", "Single");
            Console.WriteLine("Байты\t{0,8}{1,8}{2,8}\n\nНажмите любую клафишу...", sizeof(int), sizeof(double), sizeof(Single));
            Console.ReadKey();
            Console.WriteLine("\nПреобразуем double в Single и int");
            d = 25.34;
            Console.WriteLine();
            i = (int)d;
            s = (Single)d;
            Console.WriteLine("Типы\t{0,8}{1,8}{2,8}", "int", "double", "Single");
            Console.WriteLine("Байты\t{0,8}{1,8}{2,8}", sizeof(int), sizeof(double), sizeof(Single));
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
