using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    int number = random.Next(-40, 40);
            //    Console.WriteLine(number);
            //}

            //Console.ReadLine();

            Random random = new Random();
            int count = 0;

            for (int i = 0; i < 15; i++)
            {
                double number = random.NextDouble() * 50 - 20;
                Console.WriteLine(number);
                if (number > 0) count++;
            }

            Console.WriteLine($"Количество положительных чисел: {count}");

            Console.ReadLine();
        }
    }
}
