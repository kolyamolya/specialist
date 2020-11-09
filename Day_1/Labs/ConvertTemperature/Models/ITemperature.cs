using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTemperature.Models
{
    public interface ITemperature<T> where T : struct
    {
        [Print]
        public T Celsius { get; }
        [Print]
        public T Fahrenheit { get; }
        [Print]
        public T Kelvin { get; }
    }
}
