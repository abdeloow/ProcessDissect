using ProcessMVVM.Models.Helpers;
using ProcessMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProcessMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new HomeViewModel(NetstatOutputHelper.GetNetstatOutput())
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
