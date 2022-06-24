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
            var temp = txtBlock1.Text;
            var length = temp.Count();
            temp = txtBlock1.Text.Remove(length - 1);

            if (txtBlock1.Text != "0") 
            { 
                txtBlock1.Text = temp; 
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
                txtBlock1.Text = "0";
            }


            if (txtBlock1.Text == "0")
            {
                txtBlock1.Text = $"{selectedValue}";
            }
            else
            {
                txtBlock1.Text = $"{txtBlock1.Text}{selectedValue}";
            }
        }

        private void TextBox_Changed(object sender, TextChangedEventArgs e)
        {
            //txtBlock2.Text = txtBlock1.Text;
        }
    }

}
