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
        private DrillLibrary _drillLibrary;

        private int _numberOfSelectedDrills;
        public int NumberOfSelectedDrills 
        {
            get
            {
                return _numberOfSelectedDrills;
            }
            set
            {
                _numberOfSelectedDrills = value;
                OnPropertyChanged(nameof(NumberOfSelectedDrills));
            }
        }

        public ObservableCollection<DrillsListItemViewModel>? Drills
        {
            get
            {
                return _drills;
            }
            set
            {
                _drills = value;
                OnPropertyChanged(nameof(Drills));
            }
        }
        
        public DrillLibrary DrillLibrary 
        { 
            get 
            { 
                return _drillLibrary; 
            }
            set
            {
                _drillLibrary = value;
                OnPropertyChanged(nameof(DrillLibrary));
            }
        }

        public DrillsListViewModel(DrillLibrary drillLibrary)
        {
            _drills = new ObservableCollection<DrillsListItemViewModel>();
            _drillLibrary = drillLibrary;

            RefreshDrills();
            
        }

        public void RefreshDrills()
        {
            try
            {
                _drills.Clear();
            }
            finally
            {
                foreach (Drill drill in DrillLibrary.Drills)
                {
                    _drills?.Add(new DrillsListItemViewModel(drill, this));
                }
                NumberOfSelectedDrills = _drills.Count();
            }            
        }
    }
}
