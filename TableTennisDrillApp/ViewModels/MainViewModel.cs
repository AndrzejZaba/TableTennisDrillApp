using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Stores;

namespace TableTennisDrillApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase? CurrentViewModel { get; set; }
        public ViewModelBase ActiveDrillContentViewModel => ActiveDrillStore.GetStore().ActiveDrillViewModel;

        public MainViewModel()
        {
            ActiveDrillStore.GetStore().ActiveDrillChanged += OnCurrentDrillViewModelChanged;
        }

        private void OnCurrentDrillViewModelChanged()
        {
            OnPropertyChanged(nameof(ActiveDrillContentViewModel));
        }
    }
}
