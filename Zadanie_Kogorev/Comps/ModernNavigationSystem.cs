using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Zadanie_Kogorev.Comps
{
    internal class ModernNavigationSystem
    {
        private static List<PageCmponent> list = new List<PageCmponent>();
        public static MainWindow mainWindow;

        public static void NextPage(PageCmponent page)
        {
            list.Add(page);
            Update(page);
        }
        public static void BackPage()
        {
            if (list.Count > 1)
            {
                list.RemoveAt(list.Count - 1);
                Update(list[list.Count - 1]);
            }
        }

        private static void Update(PageCmponent page)
        {
            mainWindow.Title = page.PageTitle;

            mainWindow.BackBTN.Visibility = list.Count() > 1 ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
            mainWindow.MainFrame.Navigate(page.PagesLink);
        }

        public static void ClearStoryList()
        {
            list.Clear();   

        }
    }
}
internal class PageCmponent
{
    public string PageTitle { get; set; }
    public Page PagesLink { get; set; }
    public PageCmponent(string pageTitle, Page pagesLink)
    {
        PageTitle = pageTitle;
        PagesLink = pagesLink;
    }
}
