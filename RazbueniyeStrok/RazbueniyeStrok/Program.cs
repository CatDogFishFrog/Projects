using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazbueniyeStrok
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Basic,C++,C#";
            string[] s2;
            Console.WriteLine("Исходная строка:\n" + s1);
            s2 = s1.Split(',');
            string output = "";
            int ctr = 1;
            foreach(string substring in s2)
            {
                output += ctr++;
                output += ": ";
                output += substring;
                output += "\n";
            }
            Console.WriteLine("Выделеные строки:\n{0}\nНажмите любую клавишу...", output);
            Console.ReadKey();

            Console.WriteLine("Сейчас начнается новая программа\n\n");
            Console.Write("Введите текст ");
            string[] text = Console.ReadLine().Split(' ');
            string newText = null;
            for (int i = 0; i < text.Length; i++)
                if (i != 0)
                    newText += text[i] + ' ';
            newText += text[0];
            Console.WriteLine("Измененный текст: {0}",newText);
            Console.ReadLine();

            Console.WriteLine("Опять новая программа\n введите словаіі");
            string[] words = Console.ReadLine().Split(' ');
            Console.WriteLine("First: {0}\nLast: {1}",words[0],words[words.Length - 1]);
            Console.ReadKey();

            
        }
    }
}
