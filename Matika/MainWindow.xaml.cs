using Calculations.Converter;
using Matika.Pages;
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
            MainPage.Content = new TemperaturePage();
            PageDescriptionLabel.Content = "Temperature";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageDescriptionLabel.Content = "Temperature";

            MainPage.Content = new TemperaturePage();
            
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            PageDescriptionLabel.Content = "Angle";
            MainPage.Content = new AnglePage();

        }
    }

}
