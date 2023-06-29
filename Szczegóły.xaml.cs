using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace bindingXML
{
    public partial class Szczegóły : Window
    {
        public Szczegóły(XElement kategoria)
        {
            InitializeComponent();

            DataContext = kategoria;
           
            var produkty = kategoria.Element("Produkty").Elements("Produkt");
            dataGrid.ItemsSource = produkty;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
