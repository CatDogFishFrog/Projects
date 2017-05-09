using System;
namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Random randomnum = new Random();
            for (int i = 0; i < 10; i++)
            {
                
                a = randomnum.Next(1, 16);
                switch (a)
                {
                    case 10:
                        Console.WriteLine("Вы выиграли! Ваш номер 10");
                        break;
                    case 15:
                        Console.WriteLine("Супер джекпот!!! Ваш номер 15");
                        break;
                    default:
                        Console.WriteLine("Вы проиграли. Номер вашего билера равен " + a);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
