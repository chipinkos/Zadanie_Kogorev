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

namespace Zadanie_Kogorev.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductUserControl1.xaml
    /// </summary>
    public partial class ProductUserControl1 : UserControl
    {
        private Product product;
        public ProductUserControl1(Product product)
        {
            InitializeComponent();
            this.product = product;
            IconIMG.Source = GetimageSources(product.MainImage);
            ProductDescriptionTB.Text = product.GetDescription;
            ProductPriceTB.Text = product.GetRelevancePrice;
            OldProductPriceTB.Text = product.GetOldPrice;
            SaleTB.Text = product.GetSale;
            ReviewTB.Text = product.GetAverageFeedback;
            CountReviewTB.Text = product.GetReviewesAmount;
            if (App.isAdmin)
                return;
            else
            {
                DelBTN.Visibility = Visibility.Hidden;
                EditBTN.Visibility = Visibility.Hidden;
                AnalysBTN.Visibility = Visibility.Hidden;
            }
        }
        private BitmapImage GetimageSources(byte[] byteImage)
        {
            if (byteImage != null)
            {
                MemoryStream memoryStream = new MemoryStream(byteImage);
                BitmapImage image = new BitmapImage(); image.BeginInit();
                image.StreamSource = memoryStream; image.EndInit();
                return image;
            }
            else return new BitmapImage(new Uri(@"\Resource\analys.png", UriKind.Relative));
        }
        private void EditBTN_Click(object sender, RoutedEventArgs e)
        {
            ModernNavigationSystem.NextPage(new PageCmponent("Изменение товара", new ProductEditPage(product)));
        }
        private void DelBTN_Click(object sender, RoutedEventArgs e)
        {
            App.DB.Product.Remove(product);
            App.DB.SaveChanges(); ModernNavigationSystem.NextPage(new PageCmponent("Список услуг", new ProductListPage1()));
        }
    }
}