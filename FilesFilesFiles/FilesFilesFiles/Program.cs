using System;
using System.IO;

namespace FilesFilesFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = "C:\\Users\\vadim\\Desktop\\1234.txt";
            FileStream f = new FileStream(fullname, FileMode.Create);
            StreamWriter str = new StreamWriter(f);
            int strrrr = 4;
            for (int i = 1; i <= strrrr; i++)
            {
                Console.Write("Строка {0} = ", i);
                string s = Console.ReadLine();
                str.WriteLine(s);
            }
            str.Close();
            f.Close();
            Console.WriteLine("\nПроверьте создание файла\a");
            Console.ReadKey();
            Console.WriteLine();
            FileStream f1 = new FileStream(fullname, FileMode.Append);
            StreamWriter str1 = new StreamWriter(f1);
            for (int i = 1; i <= strrrr; i++)
            {
                Console.Write("Строка {0} = ", i + strrrr);
                string s = Console.ReadLine();
                str1.WriteLine(s);
            }
            str1.Close();
            f1.Close();
            Console.WriteLine("\nПроверьте файл\a");
            Console.ReadKey();
        }
    }
}
