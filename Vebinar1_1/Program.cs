using System;

namespace Vebinar1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите массив, размера от 0 до 20:");
            int n = int.Parse(Console.ReadLine());

            if (n >= 0 && n <= 20)
            {
                Console.Write("Введите диапазон чисел, например до 10:");
                int m = int.Parse(Console.ReadLine());

                int[] a = new int[n];
                Random random = new Random();
                Console.Write("Массив: ");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(m);
                    Console.Write("{0} ", a[i]);
                }

                // 1 сортировка (методом пузырька)

                int t;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] > a[j])
                        {
                            t = a[i];
                            a[i] = a[j];
                            a[j] = t;
                        }
                    }
                }

                // 1 вывод

                Console.WriteLine("Вывод отсортированного массива:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }

                Console.ReadLine();

                // 2 сортировка (методом пузырька) 

                int k;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] < a[j])
                        {
                            k = a[i];
                            a[i] = a[j];
                            a[j] = k;
                        }
                    }
                }

                // 2 вывод 

                Console.WriteLine("Вывод отсортированного массива:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }

                Console.ReadLine();

            }
            
            else if(n > 20)
            {
                Console.WriteLine("Не судьба, попробуйте ещё раз -_-");
            }

        }
    }
}
