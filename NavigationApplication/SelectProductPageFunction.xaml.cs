using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace NavigationApplication
{
    /// <summary>
    /// Interaction logic for SelectProductPageFunction.xaml
    /// </summary>

    public partial class SelectProductPageFunction
    {

        public SelectProductPageFunction()
        {
            InitializeComponent();
            lstProducts.ItemsSource =
                new ObservableCollection<Product> {
                    new Product("Ice"),
                    new Product("Snow"),
                    new Product("Gold")
                };
        }
         

        private void lnkOK_Click(object sender, RoutedEventArgs e)
        {
            // Return the selection information.
            // ListBoxItem item = (ListBoxItem)lstProducts.SelectedItem;
            Product product = (Product)lstProducts.SelectedItem;
            OnReturn(new ReturnEventArgs<Product>(product));
        }

        private void lnkCancel_Click(object sender, RoutedEventArgs e)
        {
            // Indicate that nothing was selected.
            OnReturn(null);
        }
    }

    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Product(string name)
        {
            Name = name;
        }
    }    
}

