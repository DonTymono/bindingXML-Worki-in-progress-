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
using System.Xml;
using System.Xml.Linq;

namespace bindingXML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCategoriesFromXml();
        }

        private void LoadCategoriesFromXml()
        {
            XDocument xmlDoc = XDocument.Load("produkty.xml");
            var categories = xmlDoc.Descendants("Kategoria");
            ListaKategorii.ItemsSource = categories;
        }

        private void OtwórzSzczegółyKategorii(object sender, RoutedEventArgs e)
        {
            new Szczegóły(
               (XElement)ListaKategorii.SelectedItem
                ).Show();
        }
    }
}