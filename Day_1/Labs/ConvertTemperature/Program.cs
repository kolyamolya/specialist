using ConvertTemperature.Models;
using System;
using System.Collections.Generic;

namespace ConvertTemperature
{
    class Program
    {

        private static IList<string> namesTemperature;


        static void Main(string[] args)
        {

            SetUp();

            Console.WriteLine("Выберите единицу измерения для конвертации: ");

            PrintNamesInConsole();

            var indexTypeConvertation = Console.ReadLine();

            var index = CheckedInputValue(indexTypeConvertation);

            Console.WriteLine("Введите значение для конвертации: ");

            Type type = TypeTemperature(index);

            var valueConvertation = Console.ReadLine();
            
            var instance = CreateInstance(type, valueConvertation);

            Console.WriteLine("Во что будем конвертировать? -_^");

            PrintMethodConvertion();

            var chooseMethod = Console.ReadLine();

            var indexMethods = int.Parse(chooseMethod);

            PrintResult(indexMethods, instance);
        }

        public static void SetUp() 
        {
            namesTemperature = new List<string>()
            {
                nameof(CelsiusTemperature),
                nameof(FahrenheitTemperature),
                nameof(KelvinTemperature)
            };
        }

        public static int CheckedInputValue(string value) 
        {
            int selectedNumber;

            if (!int.TryParse(value, out selectedNumber))
            {
                Console.WriteLine($"Некорректное значение {value}. Попробуйте еще раз");
                CloseApplication();
            }

            if (selectedNumber >= namesTemperature.Count)
            {
                Console.WriteLine($"Значение {selectedNumber} выходит за передел диапазона.");
                CloseApplication();
            }

            return selectedNumber;
        }

        public static void PrintNamesInConsole() 
        {
            int counter = 0;

            foreach(var names in namesTemperature) 
            {
                Console.WriteLine($"Номер {counter} : {names}");
                counter++;
            }
        }

        public static void CloseApplication() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Приложение будет закрыто");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static ITemperature<double> CreateInstance(Type type, string valueConvertation)
        {
           if (type != null)
                return (ITemperature<double>)Activator.CreateInstance(type, valueConvertation);

            return null;
        }

        public static Type TypeTemperature(int index)
        {
            var name = namesTemperature[index];

            var fullName = "ConvertTemperature.Models." + name;

            Type type = Type.GetType(fullName);

            return type;
        }

        public static void PrintMethodConvertion()
        {
            var counter = 0;
            var properties = typeof(ITemperature<double>).GetProperties();

            foreach (var prop in properties)
            {

                object[] attrs = prop.GetCustomAttributes(typeof(PrintAttribute), false);

                foreach (object attr in attrs)
                {
                    PrintAttribute authAttr = attr as PrintAttribute;
                    
                    if (authAttr != null)
                    {
                        string propName = prop.Name;
                        Console.WriteLine($"Номер {counter} : { propName.Replace("get_", "В " ) }");
                        counter++;
                    }
                }
            }

        }

        public static void PrintResult(int index, ITemperature<double> temperature) 
        {
            var counter = 0;
            var properties = typeof(ITemperature<double>).GetProperties();

            foreach (var prop in properties)
            {

                object[] attrs = prop.GetCustomAttributes(typeof(PrintAttribute), false);

                foreach (object attr in attrs)
                {
                    PrintAttribute authAttr = attr as PrintAttribute;

                    if (authAttr != null)
                    {
                        if (counter == index)
                        {
                           var method = prop.GetGetMethod();
                           Console.WriteLine(method.Invoke(temperature, null));
                        }
                        counter++;
                    }
                }
            }
        }

    }
}
