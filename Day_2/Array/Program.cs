using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");

            int lengthArray = int.Parse(Console.ReadLine());

            int[] array = new int[lengthArray];

            Console.WriteLine("Заполните массив числами: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Max : {array.Max<int>()}");
            Console.WriteLine($"Min : {array.Min<int>()}");
            Console.WriteLine($"Mean : {array.Mean()}");
        }

        
    }

    public static class Extension 
    {
        public static double Mean(this int[] array)
        {
            int sum = 0;

            foreach (var value in array)
            {
                sum += value;
            }

            return sum / array.Length;
        }
    }

}
