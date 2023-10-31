using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Zadanie_Kogorev.Comps;

namespace Zadanie_Kogorev
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HardwareShop_KogEntities1 DB = new HardwareShop_KogEntities1();
        public static bool isAdmin = false;

    }
}
