using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Windows;
using TableTennisDrillApp.Models;
using TableTennisDrillApp.Services.DrillsProviders;
using TableTennisDrillApp.Stores;
using TableTennisDrillApp.ViewModels;
using TableTennisDrillApp.ViewModels.CategoriesViewModels;
using TableTennisDrillApp.ViewModels.DrillsListViewModels;

namespace TableTennisDrillApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       // private DrillsLibraryMenuViewModel _drillsLibraryMenuViewModel;
        private readonly DrillLibrary _drillLibrary;
        private readonly IDrillsProvider _drillsProvider;
        private ActiveDrillStore _activeDrillStore;

        public App()
        {
            _drillsProvider = new DatabaseDrillsProvider();
            _drillLibrary = new DrillLibrary(_drillsProvider);
            _activeDrillStore = new ActiveDrillStore();

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var vm = new MainViewModel();
            vm.CurrentViewModel = CreateLibraryViewModel();
            vm.ActiveDrillContentViewModel = _activeDrillStore.ActiveDrillViewModel;
            MainWindow = new MainWindow()
            {
                DataContext = vm
            };


            MainWindow.Show();

            var n = 1;
        }

        private DrillsListViewModel CreateDrillsListViewModel()
        {
            return new DrillsListViewModel(_drillLibrary, _activeDrillStore);
        }

        private DrillsLibraryMenuViewModel CreateLibraryViewModel()
        {
            return new DrillsLibraryMenuViewModel(CreateDrillsListViewModel());
        }

    }
}
