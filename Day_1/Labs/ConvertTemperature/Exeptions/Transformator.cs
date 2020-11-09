using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTemperature.Exeptions
{
    public class Transformator : Exception
    {
        public Transformator() { }
        public Transformator(string message) : base(message) { }
    }
}
