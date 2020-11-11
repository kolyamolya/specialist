using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            People Nick = new People("Nick", 27);
            Console.WriteLine(Nick);

            People Tom = new People("Tom", null);
            Console.WriteLine(Tom);
        }
    }

    public struct People 
    {
        public string Name;
        public int? Age;

        public People(string Name, int? Age = null) 
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            if (Age.HasValue)
            {
                return $"Name : {Name}\t Age : {Age.Value} ";
            }
            else 
            {
                return $"Name : {Name}";
            }
        }

    }

}
