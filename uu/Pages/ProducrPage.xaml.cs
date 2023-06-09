﻿using System;
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
using uu.Models;

namespace uu.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProducrPage.xaml
    /// </summary>
    public partial class ProducrPage : Page
    {
        public ProducrPage()
        {
            InitializeComponent();
        }
        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProdPage(new Product()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGProducts.ItemsSource = App.db.Product.ToList();
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BEdit_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedProd = DGProducts.SelectedItem as Product;
            if (selectedProd == null)
            {
                MessageBox.Show("Select");
                return;
            }
            NavigationService.Navigate(new ProdPage(selectedProd));
        }
    }
}
