using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Converter
{
    public class Temperature
    {
        private double _output; 

        public double CelsiusToKelvin(double temperature)
        {
            _output = temperature + 273.15;
            return _output;
        }

        public double CelsiusToFahrenheit(double temperature)
        {
            _output = (temperature * (9 / 5))  + 32;
            return _output;
        }

        public double KelvinToFahrenheit(double temperature)
        {
            _output = ((temperature - 273.15) *  (9 / 5)) + 32;
            return _output;
        }

        public double KelvinToCelsius(double temperature)
        {
            _output = temperature - 273.15;
            return _output;
        }

        public double FahrenheitToCelsius(double temperature)
        {
            _output = (temperature - 32) * 5 / 9;
            return _output;
        }

        public double FahrenheitToKelvin(double temperature)
        {
            _output = ((temperature - 32) * (5 / 9)) + 273.15;
            return _output;
        }

    }
}
