using System;

namespace randomproga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слова: ");
            string[] words = Console.ReadLine().Split(' ');
            int num = 0;
            Console.Write("\nВведите номер слов которые хотите вывести: ");
            string[] nums = Console.ReadLine().Split(' ');
            for(int i = 0; i<nums.Length; i++)
            {
                num = Convert.ToInt32(nums[i]);
                Console.WriteLine(words[num-1]);
            }
            int l = 0;
            int index = 0;
            string w = "";
            for(int i=0; i<words.Length; i++)
            {
                if (words[i].Length > l)
                {
                    w = words[i];
                    l = words[i].Length;
                    index = i+1;
                }
            }
            Console.WriteLine("Саме длинное слово \"{0}\" которое состоит из {1} символов с номеров {2}",w,l,index);
            Console.ReadKey();

        }
    }
}
