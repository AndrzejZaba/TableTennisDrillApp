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
            set
            {
                OnPropertyChanged(nameof(DrillLibrary));
                _drillLibrary = value;
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
            }            
        }
    }
}
