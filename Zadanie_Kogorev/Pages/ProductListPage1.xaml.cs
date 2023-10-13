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
    }
}
