using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0;
            Console.Write("Введите первое число: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n.......Проверяем на четность.......\n");
            int first=0, thecond=0;

            if ((a % 2) == 0)
                first = 1;
               
            if((b % 2) == 0)
                thecond = 1;
            
            string first_chetnost = first == 1 ? "четное." : "не четное.";
            string thecong_chetnost = thecond == 1 ? "четное." : "не четное.";

            if(first ==1 && thecond == 1)
            {
                Console.WriteLine("Оба числа четные.");
            }
            else if(first==0 && thecond == 0)
            {
                Console.WriteLine("Оба числа не четные.");
            }
            else
            {
                Console.WriteLine("Первое число " + first_chetnost + "\nВторое число " + thecong_chetnost);
            }
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
