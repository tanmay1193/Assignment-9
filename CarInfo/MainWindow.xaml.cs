/*Assignment 9_Group 1
 * Group Members :  1. Oleksandr Rudavka
 *                  2. Jonathan Nagata
 *                  3. Niral Gandhi
 *                  4. Tanmay Teckchandani
 *                  5. Priya Tharuman
 *                  6. Krishna Kanhaiya
 *                  7. Lucas Currah
*/
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

namespace CarInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        //create car button click event
        private void btnCreateCar(object sender, RoutedEventArgs e)
        {
            if (vm.Make != "")
            {
                vm.CreateCar();
            }
            else
            {
                MessageBox.Show("Please enter a Make for your vehicle!");
            }
        }

        //accelerate button click event
        private void btnAccelerate(object sender, RoutedEventArgs e)
        {
            bool success = vm.AccelerateCar();
            warnNoCar(success);
        }

        //deaccelerate button click event
        private void btnDecelerate(object sender, RoutedEventArgs e)
        {
            if (vm.Speed > 0)
            {
                bool success = vm.DecelerateCar();
                warnNoCar(success);
            }
            else
            {
                MessageBox.Show("Speed cannot be Negative !");
            }
        }
        private void warnNoCar(bool success)
        {
            if (!success)
            {
                MessageBox.Show("Please create a car before you can drive!");
            }
        }

        //textbox validation(only numeric value)
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
    }
}
