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
    /// Логика взаимодействия для LOG.xaml
    /// </summary>
    public partial class LOG : Page
    {
        public LOG()
        {
            InitializeComponent();
        }
        private void EnterBTS_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTB.Text == "000")
                App.isAdmin = true;

            ModernNavigationSystem.NextPage(new PageCmponent("Список услуг", new ProductListPage1()));
        }
    }
}
