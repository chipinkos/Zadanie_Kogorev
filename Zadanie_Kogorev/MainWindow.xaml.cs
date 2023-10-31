using System;
using System.Collections.Generic;
using System.IO;
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
using Zadanie_Kogorev.Pages;

namespace Zadanie_Kogorev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ModernNavigationSystem.mainWindow = this;
            ModernNavigationSystem.NextPage(new PageCmponent("Список товаров", new LOG()));
            //    foreach (var item in App.DB.Product.ToArray())
            //    {
            //        item.MainImage = File.ReadAllBytes(@item.Image_Path);
            //    }
            //    App.DB.SaveChanges();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            ModernNavigationSystem.BackPage();
        }

        private void CrashBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("АПХХАПХАХПХА, ЭТО ФАЛЬШИВКА. АХАХПХАХПАХ, ПОПАЛСЯ(АСЬ)");
            MessageBox.Show("ЕСЛИ ЭТО ЧИТАЕТ ОКСАНА НИКОЛАЕВНА, ТО Я ИЗВИНЯЮСЬ.");
        }
    }
}
