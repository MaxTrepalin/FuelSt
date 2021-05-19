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

namespace FuelSt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double allSumm = 0;
        double qFuel = 0;
        double fuelPrice=0;
        double costFuel =0;


        public MainWindow()
        {
           
            InitializeComponent();
        }

        private void ComboBox_Fuel_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ComboBox_Fuel.Items.Add("92");
            ComboBox_Fuel.Items.Add("95");
            ComboBox_Fuel.Items.Add("100");
            ComboBox_Fuel.Items.Add("DT");

          
        }

        private void Button_AllSum_Click(object sender, RoutedEventArgs e)
        {
            qFuel = Convert.ToDouble (Liters.Text);
            costFuel = qFuel * fuelPrice;
            allSumm = costFuel;

            if (Check_burger.IsChecked == true)
            { allSumm += 200; }
            if (Check_Tea.IsChecked == true)
            { allSumm += 20; }
            if (Check_cofe.IsChecked == true)
            { allSumm += 50; }
            if (Check_cola.IsChecked == true)
            { allSumm += 60; }
            if (Check_hotDog.IsChecked == true)
            { allSumm += 130; }

            TextBoxAllSumm.Text = Convert.ToString(allSumm) + " руб.";
            FuelSumm.Text = Convert.ToString(costFuel);
        }

        private void ComboBox_Fuel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox_Fuel.SelectedItem == "92")
            {
                fuelPrice = 43;
            }
            if (ComboBox_Fuel.SelectedItem == "95")
            {
                fuelPrice = 49;
            }
            if (ComboBox_Fuel.SelectedItem == "100")
            {
                fuelPrice = 51;
            }
            if (ComboBox_Fuel.SelectedItem == "DT")
            {
                fuelPrice = 50;
            }

        }

       
    }
}
