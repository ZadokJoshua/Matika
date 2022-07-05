using Calculations.Converter.Angle;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Matika.Pages
{
    /// <summary>
    /// Interaction logic for AnglePage.xaml
    /// </summary>
    public partial class AnglePage : Page
    {
        public AnglePage()
        {
            InitializeComponent();
        }

        private ICollection<string> _unit = new Collection<string>() { "Degrees", "Radians", "Gradians" };
        public ICollection<string> Unit
        {
            get { return _unit; }
            set 
            { 
                _unit = value; 
                OnPropertyChanged(nameof(Unit)); 
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
            else if (selectedValue is ".")
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

        private void plusOrMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            var temp = double.Parse(txtBox1.Text);
            var answer = temp * -1.0;
            txtBox1.Text = answer.ToString();
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

        private void TextBox1_Changed(object sender, TextChangedEventArgs e)
        {
            ChangedEventHandler();

        }
        private void ChangedEventHandler()
        {
            //if (txtBox2 != null)
            //{
            //    var angle = new Angle();
            //    txtBox2.Text = angle.ChangedHandler(txtBox1.Text, comboBox1SelectedItem, comboBox2SelectedItem);
            //}
        }


        private string comboBox1SelectedItem = "Degrees";
        public string ComboBox1SelectedItem
        {
            get { return comboBox1SelectedItem; }
            set
            {
                comboBox1SelectedItem = value;
                OnPropertyChanged(nameof(ComboBox1SelectedItem));
                OnSelectedChanged();
            }
        }

        private string comboBox2SelectedItem = "Radians";
        public string ComboBox2SelectedItem
        {
            get { return comboBox2SelectedItem; }
            set
            {
                comboBox2SelectedItem = value;
                OnPropertyChanged(nameof(ComboBox2SelectedItem));
                OnSelectedChanged();
            }
        }
        private void OnSelectedChanged()
        {
            ChangedEventHandler();
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
