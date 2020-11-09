using System;

namespace ConsoleApp_AspNetCore
{
    
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Параметры командной строки</param>
        static void Main(string[] args)
        {
            /*
             * Это блочный комменатрий
             */
#if Release
            // строчный комментарий
            Console.WriteLine("Hello World!");
#endif
            Console.WriteLine("Debug");
            Console.ReadLine();
        }
    }
}
