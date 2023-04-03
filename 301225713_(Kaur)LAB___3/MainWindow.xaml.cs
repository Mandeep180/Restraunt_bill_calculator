using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace _301225713__Kaur_LAB___3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Invoice myInvoice = new Invoice();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Beverage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItemName = "";
            double selectedItemPrice = 0;
            if (Beverage.SelectedItem != null)
            {
                ComboBoxItem cbi = (ComboBoxItem)Beverage.SelectedItem;
                selectedItemName = cbi.Content.ToString();

                selectedItemPrice = Convert.ToDouble(cbi.Tag);
            }

            Item newItem = new Item(selectedItemName, "Beverage", selectedItemPrice);

            myInvoice.AddItem(newItem);

            grid.ItemsSource = null;
            grid.ItemsSource = myInvoice.getData();

            subtotal.Content = "Sub Total: $" + myInvoice.Total();
            tax.Content = "Tax: $" + myInvoice.Tax();
            total.Content = "Total: $" + (myInvoice.Total() + myInvoice.Tax());
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Appetizer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItemName = "";
            double selectedItemPrice = 0;
            if (Beverage.SelectedItem != null)
            {
                ComboBoxItem cbi = (ComboBoxItem)Appetizer.SelectedItem;
                selectedItemName = cbi.Content.ToString();

                selectedItemPrice = Convert.ToDouble(cbi.Tag);
            }

            Item newItem = new Item(selectedItemName, "Appetizer", selectedItemPrice);

            myInvoice.AddItem(newItem);

            grid.ItemsSource = null;
            grid.ItemsSource = myInvoice.getData();

            subtotal.Content = "Sub Total: $" + myInvoice.Total();
            tax.Content = "Tax: $" + myInvoice.Tax();
            total.Content = "Total: $" + (myInvoice.Total() + myInvoice.Tax());

        }

        private void Dessert_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItemName = "";
            double selectedItemPrice = 0;
            if (Beverage.SelectedItem != null)
            {
                ComboBoxItem cbi = (ComboBoxItem)Dessert.SelectedItem;
                selectedItemName = cbi.Content.ToString();

                selectedItemPrice = Convert.ToDouble(cbi.Tag);
            }

            Item newItem = new Item(selectedItemName, "Dessert", selectedItemPrice);

            myInvoice.AddItem(newItem);

            grid.ItemsSource = null;
            grid.ItemsSource = myInvoice.getData();

            subtotal.Content = "Sub Total: $" + myInvoice.Total();
            tax.Content = "Tax: $" + myInvoice.Tax();
            total.Content = "Total: $" + (myInvoice.Total() + myInvoice.Tax());

        }

        private void Main_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItemName = "";
            double selectedItemPrice = 0;
            if (Beverage.SelectedItem != null)
            {
                ComboBoxItem cbi = (ComboBoxItem)Main.SelectedItem;
                selectedItemName = cbi.Content.ToString();

                selectedItemPrice = Convert.ToDouble(cbi.Tag);
            }

            Item newItem = new Item(selectedItemName, "Main Course", selectedItemPrice);

            myInvoice.AddItem(newItem);

            grid.ItemsSource = null;
            grid.ItemsSource = myInvoice.getData();

            subtotal.Content = "Sub Total: $" + myInvoice.Total();
            tax.Content = "Tax: $" + myInvoice.Tax();
            total.Content = "Total: $" + (myInvoice.Total() + myInvoice.Tax());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myInvoice.Clear();

            grid.ItemsSource = null;

            grid.ItemsSource = myInvoice.getData();

            subtotal.Content = "Sub Total: $" + myInvoice.Total();
            tax.Content = "Tax: $" + myInvoice.Tax();
            total.Content = "Total: $" + (myInvoice.Total() + myInvoice.Tax());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "https://www.centennialcollege.ca";
            Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }
    }

}
