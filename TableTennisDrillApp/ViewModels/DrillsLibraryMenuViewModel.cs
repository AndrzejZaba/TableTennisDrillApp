using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.KeyWords;
using TableTennisDrillApp.Stores;
using TableTennisDrillApp.ViewModels.CategoriesViewModels;
using TableTennisDrillApp.ViewModels.DrillsListViewModels;
using TableTennisDrillApp.ViewModels.SearachViewModels;

namespace TableTennisDrillApp.ViewModels
{
    public class DrillsLibraryMenuViewModel : ViewModelBase
    {
        public CategoryListViewModel CategoryListVM { get; }
        public DrillsListViewModel DrillsListVM { get; }
        public DrillsSearchViewModel DrillsSearchVM { get; }

        public DrillsLibraryMenuViewModel(DrillsListViewModel drillsListViewModel)
        {
            DrillsListVM = drillsListViewModel;
            CategoryListVM = new CategoryListViewModel(DrillsListVM);
            DrillsSearchVM = new DrillsSearchViewModel();
        }
    }
}
