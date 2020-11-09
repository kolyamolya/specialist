using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> PrintConsole = (value) =>
            {
                Console.WriteLine(value);
            };

            PrintConsole("Hello World :-)");
        }
    }
}
