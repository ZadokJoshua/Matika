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

        private double CelsiusToCelsius(double temperature)
        {
            _output = temperature;
            return _output;
        }

        private double KelvinToKelvin(double temperature)
        {
            _output = temperature;
            return _output;
        }

        private double FahrenheitToFahrenheit(double temperature)
        {
            _output = temperature;
            return _output;
        }

        private double CelsiusToKelvin(double temperature)
        {
            _output = temperature + 273.15;
            return Math.Round(_output, 2);
        }

        private double CelsiusToFahrenheit(double temperature)
        {
            _output = (temperature * 9 / 5) + 32;
            return Math.Round(_output, 2);
        }

        private double KelvinToFahrenheit(double temperature)
        {
            _output = ((temperature - 273.15) * (9 / 5)) + 32;
            return Math.Round(_output, 2);
        }

        private double KelvinToCelsius(double temperature)
        {
            _output = temperature - 273.15;
            return Math.Round(_output, 2);
        }

        private double FahrenheitToCelsius(double temperature)
        {
            _output = (temperature - 32) * 5 / 9;
            return Math.Round(_output, 2);
        }

        private double FahrenheitToKelvin(double temperature)
        {
            _output = ((temperature - 32) * (5 / 9)) + 273.15;
            return Math.Round(_output, 2);
        }

        public string ChangedHandler(string inputNum, string comboBox1SelectedItem, string comboBox2SelectedItem)
        {
            double _output;
            double.TryParse(inputNum, out _output);
            string item1 = comboBox1SelectedItem;
            string item2 = comboBox2SelectedItem;
            if (item1 is "Celsius" && item2 is "Fahrenheit")
            {
                _output = CelsiusToFahrenheit(_output);
            }

            if (item1 is "Celsius" && item2 is "Kelvin")
            {
                _output = CelsiusToKelvin(_output);
            }

            if (item1 is "Kelvin" && item2 is "Celsius")
            {
                _output = KelvinToCelsius(_output);
            }

            if (item1 is "Kelvin" && item2 is "Fahrenheit")
            {
                _output = KelvinToFahrenheit(_output);
            }

            if (item1 is "Fahrenheit" && item2 is "Celsius")
            {
                _output = FahrenheitToCelsius(_output);
            }

            if (item1 is "Fahrenheit" && item2 is "Kelvin")
            {
                _output = FahrenheitToKelvin(_output);
            }

            var sample = string.IsNullOrEmpty(inputNum) ? "0" : _output.ToString();
            return sample;
        }

    }
}
