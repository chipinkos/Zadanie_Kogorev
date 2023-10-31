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
using Zadanie_Kogorev.Comps;

namespace Zadanie_Kogorev.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductListPage1.xaml
    /// </summary>
    public partial class ProductListPage1 : Page
    {
        public ProductListPage1()
        {
            InitializeComponent();
            IEnumerable<Product> productsList = App.DB.Product;

            foreach (var item in productsList)
            {
                ProductWrap.Children.Add(new ProductUserControl1(item));
            }
        }
        private void Refresh()
        {
            IEnumerable<Product> servicesSortList = App.DB.Product;
            if (PriceSortCB.SelectedIndex > 0)
            {
                if (PriceSortCB.SelectedIndex == 1)
                    servicesSortList = servicesSortList.OrderBy(x => x.GetRelevancePrice);
                else if (PriceSortCB.SelectedIndex == 2)
                    servicesSortList = servicesSortList.OrderByDescending(x => x.GetRelevancePrice);
            }

            if (DiscountSortCB.SelectedIndex > 0)
            {
                if (DiscountSortCB.SelectedIndex == 1)
                    servicesSortList = servicesSortList.Where(x => x.Discount <= 5);
                else if (DiscountSortCB.SelectedIndex == 2)
                    servicesSortList = servicesSortList.Where(x => x.Discount > 5 && x.Discount <= 15);
                else if (DiscountSortCB.SelectedIndex == 3)
                    servicesSortList = servicesSortList.Where(x => x.Discount > 15 && x.Discount <= 30);
                else if (DiscountSortCB.SelectedIndex == 4)
                    servicesSortList = servicesSortList.Where(x => x.Discount > 30 && x.Discount <= 70);
                else if (DiscountSortCB.SelectedIndex == 5)
                    servicesSortList = servicesSortList.Where(x => x.Discount > 70);
            }

            if (SearchTextBox.Text != "" || SearchTextBox.Text != null)
                servicesSortList = servicesSortList.Where(x =>
                    x.Title.ToLower().Contains(SearchTextBox.Text.ToLower()) ||
                    x.Description.ToLower().Contains(SearchTextBox.Text.ToLower()));

            ProductWrap.Children.Clear();
            foreach (var item in servicesSortList)
            {
                ProductWrap.Children.Add(new ProductUserControl1(item));
            }
            CountDataText.Text = $"{servicesSortList.Count()} из {App.DB.Product.Count()}";
        }

        private void PriceSortCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void DiscountSortCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            ModernNavigationSystem.NextPage(new PageCmponent("Добавление товара", new ProductEditPage(new Product())));
        }
    }
}
