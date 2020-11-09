using ConvertTemperature.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTemperature.Models
{
    public class FahrenheitTemperature : ITemperature<double>
    {
        private readonly double _value;

        public FahrenheitTemperature(double value)
        {
            this._value = value;
        }

        public FahrenheitTemperature(string value)
        {
            if (!double.TryParse(value, out _value))
            {
                throw new Transformator("Ошибка преобразования");
            }
        }

        public double Celsius
        {
            get { return (_value - 32) * 5 / 9; }
        }

        public double Fahrenheit
        {
            get { return _value; }
        }

        public double Kelvin
        {
            get { return Celsius + 273.15; }
        }
    }
}