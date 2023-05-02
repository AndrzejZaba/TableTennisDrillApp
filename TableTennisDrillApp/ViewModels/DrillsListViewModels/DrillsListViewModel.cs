using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;
using TableTennisDrillApp.Services.DrillsProviders;
using TableTennisDrillApp.Stores;

namespace TableTennisDrillApp.ViewModels.DrillsListViewModels
{
    public class DrillsListViewModel : ViewModelBase
    {

        private ObservableCollection<DrillsListItemViewModel>? _drills;
        private readonly DrillLibrary _drillLibrary;
        private ActiveDrillStore _activeDrillStore;

        public ObservableCollection<DrillsListItemViewModel>? Drills
        {
            get
            {
                return _drills;
            }
            set
            {
                OnPropertyChanged(nameof(Drills));
                _drills = value;    
            }
        }
        
        public DrillLibrary DrillLibrary 
        { 
            get 
            { 
                return _drillLibrary; 
            } 
        }
        public ActiveDrillStore ActiveDrillStore 
        { 
            get
            {
                return _activeDrillStore;
            }
            set
            {
                _activeDrillStore = value;
            }
        }
        public DrillsListViewModel(DrillLibrary drillLibrary, ActiveDrillStore activeDrillStore)
        {
            _drills = new ObservableCollection<DrillsListItemViewModel>();
            _activeDrillStore = activeDrillStore;
            _drillLibrary = drillLibrary;


            RefreshDrills();
            
        }

        public void RefreshDrills()
        {
            foreach (Drill drill in _drillLibrary.Drills)
            {
                _drills?.Add(new DrillsListItemViewModel(drill, this));
            }
        }
    }
}
