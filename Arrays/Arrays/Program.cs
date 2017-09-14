using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            long[,,] array = new long[1000, 100, 100];
            Random rand = new Random();
            prisvoitznacenie(array, rand);
            watcharray(array);
            watcharraykakoytodrugoysposob(array);
            Console.ReadKey();
        }

        private static void prisvoitznacenie(long[,,] array, Random rand)
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int x = 0; x < 100; x++)
                    {
                        array[i, j, x] = rand.Next(1, 100000);
                    }
                }
            }
        }

        private static void watcharraykakoytodrugoysposob(long[,,] array)
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int x = 0; x < 100; x++)
                    {
                        if (x == 9)
                            Console.WriteLine(array[i, j, x]);
                        else
                            Console.Write(array[i, j, x] + ",\t");
                    }
                }
                Console.WriteLine("\n\n");
            }
        }

        private static void watcharray(long[,,] array)
        {
            foreach (long el in array)
            {
                Console.WriteLine(el);
            }
        }
    }
}
