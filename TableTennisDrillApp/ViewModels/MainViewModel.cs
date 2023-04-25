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
        private ActiveDrillStore _activeDrillStore;

        public ViewModelBase? CurrentViewModel { get; set; }
        public ViewModelBase ActiveDrillContentViewModel => _activeDrillStore.ActiveDrillViewModel;

        public MainViewModel(ActiveDrillStore activeDrillStore)
        {
            _activeDrillStore = activeDrillStore;

            _activeDrillStore.ActiveDrillViewModelChanged += OnCurrentDrillViewModelChanged;
        }

        private void OnCurrentDrillViewModelChanged()
        {
            OnPropertyChanged(nameof(ActiveDrillContentViewModel));
        }
    }
}
