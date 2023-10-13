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
    /// Логика взаимодействия для ProductUserControl1.xaml
    /// </summary>
    public partial class ProductUserControl1 : UserControl
    {
        public ProductUserControl1(Product product)
        {
            InitializeComponent();
            SaleTB.Text = product.Discount.ToString() + " %";
            ProductDescriptionTB.Text = product.Description;
            ReviewTB.Text = "1";
            ProductPriceTB.Text = product.Cost.ToString();
        }
    }
}
