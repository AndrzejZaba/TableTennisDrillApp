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

        private readonly ObservableCollection<DrillsListItemViewModel>? _drills;
        private readonly DrillLibrary _drillLibrary;

        public IEnumerable<DrillsListItemViewModel>? Drills => _drills;
        public Drill? ActiveDrill { 
            get; 
            set; }
        public DrillsListViewModel(DrillLibrary drillLibrary)
        {
            _drills = new ObservableCollection<DrillsListItemViewModel>();
            _drillLibrary = drillLibrary;
            ActiveDrill = null;

            foreach (Drill drill in _drillLibrary.Drills)
            {
                _drills?.Add(new DrillsListItemViewModel(drill, this));
            }
        }
    }
}
