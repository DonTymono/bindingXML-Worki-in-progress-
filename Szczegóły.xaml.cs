﻿using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace bindingXML
{
    public partial class Szczegóły : Window
    {
        private XDocument xmlDoc;

        public Szczegóły(XElement kategoria, XDocument xmlDoc)
        {
            InitializeComponent();
            this.xmlDoc = xmlDoc;

            // Ustawienie DataContext na kategorię
            DataContext = kategoria;

            // Ustawienie ItemsSource dla DataGrid
            var produkty = kategoria.Element("Produkty").Elements("Produkt");

            dataGrid.ItemsSource = produkty;


        }
    }
}
