using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a = a + 1;
            a += 1;
            a++;

            int b = ++a;
            int c = a++;

            Console.WriteLine($"a : {a} \n" +
                              $"b : {b} \n" +
                              $"c : {c}");
            Console.ReadLine();
        }
    }
}
