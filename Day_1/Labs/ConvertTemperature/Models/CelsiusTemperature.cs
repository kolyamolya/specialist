using ConvertTemperature.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTemperature.Models
{
    public class CelsiusTemperature : ITemperature<double>
    {

        private readonly double _value;

        public CelsiusTemperature(double value)
        {
            this._value = value;
        }

        public CelsiusTemperature(string value)
        {
            if (!double.TryParse(value, out _value))
            {
                throw new Transformator("Ошибка преобразования");
            }
        }

        public double Celsius
        {
            get { return _value; }
        }

        public double Fahrenheit
        {
            get { return _value * 9 / 5 + 32; }
        }

        public double Kelvin
        {
            get { return _value + 273.15; }
        }
    }
}
