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

        public double CelsiusToCelsius(double temperature)
        {
            _output = temperature;
            return _output;
        }

        public double KelvinToKelvin(double temperature)
        {
            _output = temperature;
            return _output;
        }

        public double FahrenheitToFahrenheit(double temperature)
        {
            _output = temperature;
            return _output;
        }

        public double CelsiusToKelvin(double temperature)
        {
            _output = temperature + 273.15;
            return Math.Round(_output, 2);
        }

        public double CelsiusToFahrenheit(double temperature)
        {
            _output = (temperature * 9 / 5) + 32;
            return Math.Round(_output, 2);
        }

        public double KelvinToFahrenheit(double temperature)
        {
            _output = ((temperature - 273.15) *  (9 / 5)) + 32;
            return Math.Round(_output, 2);
        }

        public double KelvinToCelsius(double temperature)
        {
            _output = temperature - 273.15;
            return Math.Round(_output, 2);
        }

        public double FahrenheitToCelsius(double temperature)
        {
            _output = (temperature - 32) * 5 / 9;
            return Math.Round(_output, 2);
        }

        public double FahrenheitToKelvin(double temperature)
        {
            _output = ((temperature - 32) * (5 / 9)) + 273.15;
            return Math.Round(_output, 2);
        }

    }
}
