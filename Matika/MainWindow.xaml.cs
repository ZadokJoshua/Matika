using Calculations.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Matika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> SourceTemp { get; private set; } = new List<string>() { "Celsius", "Fahrenheit", "Kelvin"};

        public string SourceTempSelectedItem { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var temp = txtBox1.Text;
            var length = temp.Count();

            if (txtBox1.Text != "0")
            {
                if (length < 2)
                {
                    txtBox1.Text = "0";
                    txtBox2.Text = "0";
                }
                else
                {
                    temp = txtBox1.Text.Remove(length - 1);
                    txtBox1.Text = temp;
                }
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            var selectedValue = ((Button)sender).Content;

            if (selectedValue is "CE")
            {
                txtBox1.Text = "0";
                txtBox2.Text = "0";
            }
            else
            {
                if (txtBox1.Text == "0")
                {
                    txtBox1.Text = $"{selectedValue}";
                }
                else
                {
                    txtBox1.Text = $"{txtBox1.Text}{selectedValue}";
                }
            }

        }

        private void TextBox1_Changed(object sender, TextChangedEventArgs e)
        {
            ChangedEventHandler(comboBox1, comboBox2);
        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox1.Text.Contains("."))
            {
                // Do nothing
            }
            else
            {
                txtBox1.Text = $"{txtBox1.Text}.";
            }
        }

        private void plusOrMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            var temp = double.Parse(txtBox1.Text);
            var answer = temp * -1.0;
            txtBox1.Text = answer.ToString();
        }

        private void ChangedEventHandler(ComboBox comboBox1, ComboBox comboBox2)
        {
            double _output;
            var temperature = new Temperature();
            double.TryParse(txtBox1.Text, out _output);
            string item1 = comboBox1?.Text;
            string item2 = comboBox2?.Text;


            if (item1 is "Celsius" && item2 is "Fahrenheit")
            {
                _output = temperature.CelsiusToFahrenheit(_output);
            }

            if (item1 is "Celsius" && item2 is "Kelvin")
            {
                _output = temperature.CelsiusToKelvin(_output);
            }

            if (item1 is "Kelvin" && item2 is "Celsius")
            {
                _output = temperature.KelvinToCelsius(_output);
            }

            if (item1 is "Kelvin" && item2 is "Fahrenheit")
            {
                _output = temperature.KelvinToFahrenheit(_output);
            }

            if (item1 is "Fahrenheit" && item2 is "Celsius")
            {
                _output = temperature.FahrenheitToCelsius(_output);
            }

            if (item1 is "Fahrenheit" && item2 is "Kelvin")
            {
                _output = temperature.FahrenheitToKelvin(_output);
            }

            if (txtBox1.Text != "0")
            {
                txtBox2.Text = _output.ToString();
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ChangedEventHandler(comboBox1, comboBox2);
            //double _output;
            //var temperature = new Temperature();
            //double.TryParse(txtBox1.Text, out _output);
            //string item1 = comboBox1?.SelectedIndex.ToString();
            //string item2 = comboBox2?.SelectedIndex.ToString();

            //if (sender == comboBox1)
            //{
            //    if (item1 is "Celsius")
            //    {
            //        if(item2 is "Celsius")
            //        {
            //            _output = temperature.CelsiusToCelsius(_output);
            //            txtBox2.Text = _output.ToString();
            //        }

            //        if (item2 is "Fahrenheit")
            //        {
            //            _output = temperature.CelsiusToFahrenheit(_output);
            //            txtBox2.Text = _output.ToString();
            //        }

            //        if (item2 is "Kelvin")
            //        {
            //            _output = temperature.CelsiusToKelvin(_output);
            //        }
            //    }

            //    if (item1 is "Fahrenheit")
            //    {
            //        if (item2 is "Fahrenheit")
            //        {
            //            _output = temperature.FahrenheitToFahrenheit(_output);
            //        }

            //        if (item2 is "Celsius")
            //        {
            //            _output = temperature.FahrenheitToCelsius(_output);
            //        }

            //        if (item2 is "Kelvin")
            //        {
            //            _output = temperature.FahrenheitToKelvin(_output);
            //        }
            //    }

            //    if (item1 is "Kelvin")
            //    {
            //        if (item2 is "Kelvin")
            //        {
            //            _output = temperature.KelvinToKelvin(_output);
            //        }

            //        if (item2 is "Celsius")
            //        {
            //            _output = temperature.KelvinToCelsius(_output);
            //        }

            //        if (item2 is "Fahrenheit")
            //        {
            //            _output = temperature.KelvinToFahrenheit(_output);
            //        }
            //    }

            //if (txtBox1.Text != "0")
            //{
            //    txtBox2.Text = _output.ToString();
            //}
        //}
        }
    }

}
