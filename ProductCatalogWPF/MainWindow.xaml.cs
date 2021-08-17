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

namespace ProductCatalogWPF
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

        public Catalog Katalog = new Catalog();

        public int itemcount = -1;

        private void adproductbt_Click(object sender, RoutedEventArgs e)
        {
            itemcount++;
            Katalog.AddItem(new Product(Convert.ToSingle(ppricetb.Text), pnametb.Text));
            listboxone.Items.Add(Katalog.ListOfProducts[itemcount].ProductName);
            listboxtwo.Items.Add("CHF " + Katalog.ListOfProducts[itemcount].getPrice());





    }

    }
}
