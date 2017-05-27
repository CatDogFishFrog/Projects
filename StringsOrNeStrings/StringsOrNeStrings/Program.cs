using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsOrNeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Basic,C++,C#";
            string s2 = "C++,C#";
            Console.WriteLine("Сравниваемые строки:\ns1 = {0}\ns2 = {1}\n", s1, s2);
            Console.ReadKey();

            int r = s2.CompareTo(s1);
            Console.WriteLine("\nСравниваем s2 с s1:\nРезультат = {0}\nНажмите любую клавишу...\n",r.ToString());
            Console.ReadKey();

            r = s2.CompareTo(s2);
            Console.WriteLine("\nСравниваем s2 с s2:\nРезультат = {0}\nНажмите любую клавишу...\n", r.ToString());
            Console.ReadKey();

            r = s1.CompareTo(s2);
            Console.WriteLine("\nСравниваем s1 с s2:\nРезультат = {0}\nНажмите любую клавишу...\n", r.ToString());
            Console.ReadKey();

            Console.WriteLine("Прямо на этом моменте, не на каком другом, именно н этом, начинается самая новая программа в этом мире!!! Вот она уже началась...\n\n");
            string surname ="Басков";
            char simvol='!';
            Console.WriteLine(surname + simvol+"\nНажмите любую клавишу...");
            Console.ReadKey();

        }
    }
}
