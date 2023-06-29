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

            // Ustawienie DataContext na kategorię
            DataContext = kategoria;

            // Ustawienie ItemsSource dla DataGrid
            var produkty = kategoria.Element("Produkty").Elements("Produkt");
            dataGrid.ItemsSource = produkty;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Możesz dodać tutaj kod obsługi zdarzenia SelectionChanged, jeśli jest potrzebny
        }
    }
}
