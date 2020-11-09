using ConvertTemperature.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTemperature.Models
{
    public class KelvinTemperature : ITemperature<double>
    {
        private readonly double _value;

        public KelvinTemperature(double value)
        {
            this._value = value;
        }

        public KelvinTemperature(string value)
        {
            if (!double.TryParse(value, out _value))
            {
                throw new Transformator("Ошибка преобразования");
            }
        }

        public double Celsius
        {
            get { return _value - 273.15; }
        }

        public double Fahrenheit
        {
            get { return Celsius * 9 / 5 + 32; }
        }

        public double Kelvin
        {
            get { return _value; }
        }
    }
}
