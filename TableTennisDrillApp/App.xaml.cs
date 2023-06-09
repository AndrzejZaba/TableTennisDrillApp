﻿using System;
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

        public App()
        {
            _drillsProvider = new DatabaseDrillsProvider();
            _drillLibrary = new DrillLibrary(_drillsProvider);
            ActiveDrillStore.GetStore();

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var vm = new MainViewModel();
            vm.MenuViewModel = CreateLibraryViewModel();
            
            
            //vm.ActiveDrillStore = _activeDrillStore;

            //vm.ActiveDrillContentViewModel = ActiveDrillStore.GetStore().ActiveDrillViewModel;
            
            
            // Try to implemetn event taht will be fired when _activeDrillStore.ActiveDrillViewModel is changed. Then MainViewModel will be updated.
            // Because now MainViewModel work as it's ActiveDrillContentViewModel doesn't refere to _activeDrillStore.ActiveDrillViewModel
            MainWindow = new MainWindow()
            {
                DataContext = vm
            };


            MainWindow.Show();

        }

        private DrillsListViewModel CreateDrillsListViewModel()
        {
            return new DrillsListViewModel(_drillLibrary);
        }

        private DrillsLibraryMenuViewModel CreateLibraryViewModel()
        {
            return new DrillsLibraryMenuViewModel(CreateDrillsListViewModel());
        }

    }
}
