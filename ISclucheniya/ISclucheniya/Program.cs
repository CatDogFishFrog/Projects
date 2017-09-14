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
                Console.WriteLine("Попытка деления на 0");
                Console.WriteLine(e.ToString());
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Вызод за переделы диаразона");
                Console.WriteLine(e.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine("Фатальная ошибка");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
            }
            int a = 5;
            int[] b = new int[10];
            try
            {
                for (int c = 0; c < a; c++)
                {
                    b[c] = c / (c - 5);
                    Console.WriteLine("x = {0}, f[x] = {1}", c, b[c]);
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Попытка деления на 0");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
            }
        }
    }
}
