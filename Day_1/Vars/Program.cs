using System;

namespace Vars
{
    class Program
    {
        static int defaultValue;
        static void Main(string[] args)
        {
            int age;
            string userName;

            age = 27;
            userName = "Nick";

            int ageInMonths = age * 12;

            /*
             * Анонимный класс
             */
            var anonymousClass = new { Age = age,
                                       Name = userName };

            Console.WriteLine(anonymousClass);

            /*
             * Переменная defaultValue -- иммет нулевой байт,
             * если переменная не инициализирована,
             * то по будет иметь значение 0.
             */
            Console.WriteLine(defaultValue);

            Console.WriteLine($"Name: {userName }\n" +
                              $"Age: {age}\n" +
                              $"Age In Months: {ageInMonths}");

            Console.ReadLine();
        }

        public static void Scope() 
        {
            {
                var test = 10;
                Console.WriteLine(test);
            }
            {
                var test = "10";
                Console.WriteLine(test);
            }

            /*
             * Error 
             */
            {
                var test = 10;
                Console.WriteLine(test);
                {
                    var test = "10";
                    Console.WriteLine(test);
                }
            }
        }
    }
}