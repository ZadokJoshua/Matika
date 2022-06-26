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
                if(length < 2)
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
            int selectedValue = 0;

            if(sender == sevenBtn)
            {
                selectedValue = 7;
            }
            if (sender == eightBtn)
            {
                selectedValue = 8;
            }
            if (sender == nineBtn)
            {
                selectedValue = 9;
            }
            if (sender == fourBtn)
            {
                selectedValue = 4;
            }
            if (sender == fiveBtn)
            {
                selectedValue = 5;
            }
            if (sender == sixBtn)
            {
                selectedValue = 6;
            }
            if (sender == threeBtn)
            {
                selectedValue = 3;
            }
            if (sender == twoBtn)
            {
                selectedValue = 2;
            }
            if (sender == oneBtn)
            {
                selectedValue = 1;
            }
            if (sender == ceBtn)
            {
                txtBox1.Text = "0";
                txtBox2.Text = "0";
            }


            if (txtBox1.Text == "0")
            {
                txtBox1.Text = $"{selectedValue}";
            }
            else
            {
                txtBox1.Text = $"{txtBox1.Text}{selectedValue}";
            }
        }

        private void TextBox1_Changed(object sender, TextChangedEventArgs e)
        {
            double _output;
            var temperature = new Temperature();
            double.TryParse(txtBox1.Text, out _output);
            string temp = comboBox1?.Text;
            string temp1 = comboBox2?.Text;

            if (temp is "Celsius" && temp1 is "Fahrenheit")
            {
                _output = temperature.CelsiusToFahrenheit(_output);
            }

            if (temp is "Kelvin" && temp1 is "Fahrenheit")
            {
                _output = temperature.KelvinToFahrenheit(_output);
            }



            if (txtBox1.Text != "0")
            {
                //string temp = txtBox1.Text;
                txtBox2.Text = _output.ToString(); 
            }
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
    }

}
