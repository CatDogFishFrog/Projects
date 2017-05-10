using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chtoto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int user = 1;
            Console.Write("Ваш номер = ");
            user = Convert.ToInt32(Console.ReadLine());
            switch (user)
            {
                case 1: Console.WriteLine("Здравствуйте Userl"); break;
                case 2: Console.WriteLine("Здравствуйте User2"); break;
                case 3: Console.WriteLine("Здравствуйте User3"); break;
                default: Console.WriteLine("Здравствуйте новичок"); break;
            }
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey(); // Пауза 
        }
       

    }
}
