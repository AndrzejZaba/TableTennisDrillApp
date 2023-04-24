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
        public ActiveDrillStore ActiveDrillStore
        {
            get { return _activeDrillStore; }
            set 
            { 
                _activeDrillStore = value;
                OnPropertyChanged(nameof(ActiveDrillStore));
                ActiveDrillContentViewModel = ActiveDrillStore.ActiveDrillViewModel;
            }
        }
        public ViewModelBase? CurrentViewModel 
        { 
            get; 
            set; 
        }
        public ViewModelBase? ActiveDrillContentViewModel 
        { 
            get; 
            set; 
        }

        public MainViewModel()
        {
            //CurrentViewModel = new DrillsLibraryMenuViewModel();
        }

    }
}
