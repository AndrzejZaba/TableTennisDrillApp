using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TableTennisDrillApp.Services.DrillsProviders;

namespace TableTennisDrillApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IDrillsProvider _drillsProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            _drillsProvider = new DatabaseDrillsProvider();
            var drills = _drillsProvider.GetAllDrills();

            var n = 1;
        }
    }
}
