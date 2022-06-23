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

        private void btn_Click(object sender, RoutedEventArgs e)
        {

            if(sender == sevenBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}7";
                
            }
            else if (sender == eightBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}8";
            }
            else if (sender == nineBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}9";
            }
            else if (sender == fourBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}4";
            }
            else if (sender == fiveBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}5";
            }
            else if (sender == sixBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}6";
            }
            else if (sender == threeBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}3";
            }
            else if (sender == twoBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}2";
            }
            else if (sender == oneBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}1";
            }
            else if (sender == dotBtn)
            {
                txtBlock1.Text = $"{txtBlock1.Text}.";
            }
            else if (sender == ceBtn)
            {
                txtBlock1.Text = "0";
            }
            else if (sender == deleteBtn)
            {
                var temp = txtBlock1.Text;
                var length = temp.Count();
                temp = txtBlock1.Text.Remove(length - 1);
                if (txtBlock1.Text != "0") { txtBlock1.Text = temp; }
            }
        }



        
    }

}
