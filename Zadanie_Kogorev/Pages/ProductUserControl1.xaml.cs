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
    /// Логика взаимодействия для ProductUserControl1.xaml
    /// </summary>
    public partial class ProductUserControl1 : UserControl
    {
        public ProductUserControl1(Product product)
        {
            InitializeComponent();
            ProductDescriptionTB.Text = product.GetDescription;
            ProductPriceTB.Text = product.GetRelevancePrice;
            OldProductPriceTB.Text = product.GetOldPrice;
            SaleTB.Text = product.GetSale;
            ReviewTB.Text = product.GetAverageFeedback;
            CountReviewTB.Text = product.GetReviewesAmount;
        }

    }
}
