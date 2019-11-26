using System;

namespace Vebinar1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое четное число N:");
            int n = int.Parse(Console.ReadLine());
            int p = n;

            if (n % 2 == 0)
            {
                for (int i = 0; i < n; i++, p--)
                {
                    for (int j = 0; j < p; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int m = 0; m < i * 2; m++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                for (int i = 0; i <= n; i++)
                {
                    Console.Write("**");
                }
                Console.ReadKey();
            }
            else if(n%2!=0)
            {
                Console.WriteLine("Не хочу рисовать такой треугольник!");
            }
        }
    }
}
