using System;

namespace Homework_4._8_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int a;
            int b;

            Console.WriteLine("Enter rows number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cols number:");
            b = int.Parse(Console.ReadLine());

            int[,] table = new int[a,b];

            Random rand = new Random();
            int sum = 0;

            for (i = 0; i < table.GetLength(0); i++) {
                for (j = 0; j < table.GetLength(1); j++) {
                    table[i, j] = rand.Next(100);
                    Console.Write($"{table[i,j], 3} ");
                    sum += table[i, j];
                }
                Console.WriteLine();
             }

            Console.WriteLine($"Sum of all table elements: {sum}");


            Console.ReadKey();
        }
    }
}
