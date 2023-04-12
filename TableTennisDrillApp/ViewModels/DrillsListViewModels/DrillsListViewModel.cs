using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;
using TableTennisDrillApp.Services.DrillsProviders;

namespace TableTennisDrillApp.ViewModels.DrillsListViewModels
{
    public class DrillsListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<DrillsListItemViewModel>? _drills;
        private IDrillsProvider _drillsProvider;

        public IEnumerable<DrillsListItemViewModel>? Drills => _drills;
        public DrillsListViewModel()
        {
            _drills = new ObservableCollection<DrillsListItemViewModel>();
            _drillsProvider = new DatabaseDrillsProvider();
            IEnumerable<Drill> list = _drillsProvider.GetAllDrills();
            foreach (Drill drill in list)
            {
                _drills?.Add(new DrillsListItemViewModel(drill));
            }
        }
    }
}
