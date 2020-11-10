using System;

namespace Crows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество ворон на ветке: ");
            
            int countCrows = int.Parse(Console.ReadLine());
            string nameCrow;

            int mod100 = countCrows % 100;

            if ((mod100 >= 11) && (mod100 <= 14))
                nameCrow = "ворон";
            else
            {
                int mod10 = countCrows % 10;
                switch (mod10)
                {
                    case 1: 
                        nameCrow = "ворона"; 
                        break;
                    case 2:
                        nameCrow = "вороны";
                        break;
                    case 3:
                        nameCrow = "вороны";
                        break;
                    case 4: 
                        nameCrow = "вороны"; 
                        break;
                    default: 
                        nameCrow = "ворон"; 
                        break;
                }
            }

            string result = string.Format($"На ветке {countCrows} {nameCrow}");
            Console.WriteLine(result);
        }
    }
}
