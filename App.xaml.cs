using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PeriodicTableV1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            MessageBox.Show("Welcome To The Periodic table!\n\nMade by Christian Gibson (2022)", "Periodic Table", MessageBoxButton.OK, MessageBoxImage.Asterisk);


        }
    }
}
