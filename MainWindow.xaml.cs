/*Mary Jeffries
 * Feb 26 2020
 * Program that displays parts of a computer and calculates the price
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

namespace _219076ComputerParts
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

        private void btnParts_Click(object sender, RoutedEventArgs e)
        {
            Double CPUPrice = 109.88;
            Double MotherboardPrice = 139.99;
            Double RAMPrice = 99.99;
            Double StoragePrice = 129.99;
            Double CasePrice = 209.99;
            Double PowerSupplyPrice = 79.99;
            Double OpticalDrivePrice = 79.99;
            //Assinging prices

            lblOutput.Content = "CPU: AMD Ryzen 3 2200G" + CPUPrice.ToString("$#.00") + Environment.NewLine
                + "Motherboard: ASRock B450M PRO4" + MotherboardPrice.ToString("$#.00") + Environment.NewLine
                + "RAM: Corsair Vengence LPX 16GB" + RAMPrice.ToString("$#.00") + Environment.NewLine
                + "Storage: WD Blue SN550 1TB Solid State Drive" + StoragePrice.ToString("$#.00") + Environment.NewLine
                + "Case: Corsair Obsidian Series 750D" + CasePrice.ToString("$#.00") + Environment.NewLine
                + "PowerSupply: be quiet! System Power U9" + PowerSupplyPrice.ToString("$#.00") + Environment.NewLine
                + "Optical Drive: LG (WH14NS40)" + OpticalDrivePrice.ToString("$#.00");
            //Output the information of each part

            btnCalculate.Visibility = Visibility.Visible;
            Tower.Visibility = Visibility.Collapsed; 
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Double Subtotal = 949.82; 
            lblOutput.Content = "The total price is " + Subtotal * 1.13;   
        }
    }
}
