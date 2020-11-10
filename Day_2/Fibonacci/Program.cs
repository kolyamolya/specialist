using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество итерация для последовательности Фибоначи: ");

            int countIterations = int.Parse(Console.ReadLine());

            Fibonacci(countIterations);
        }

        static void Fibonacci(int n)
        {

            if (n == 0 || n == 1)
            {
                Console.WriteLine(n);
                return;
            }

            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
                Console.WriteLine($"Интерация {i} имеет значение {b}");
            }
        }

    }
}
