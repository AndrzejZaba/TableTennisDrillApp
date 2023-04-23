using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;
using TableTennisDrillApp.ViewModels;
using TableTennisDrillApp.ViewModels.DrillContentViewModels;

namespace TableTennisDrillApp.Stores
{
    public class ActiveDrillStore
    {
        private Drill? _activeDrill ;
        private ViewModelBase _activeDrillViewModel;
        public Drill ActiveDrill
        {
            get { return _activeDrill; }
            set { _activeDrill = value; }
        }

        public ViewModelBase ActiveDrillViewModel
        {
            get => _activeDrillViewModel;
            set => _activeDrillViewModel = value;
        }
        public ActiveDrillStore()
        {
            _activeDrill = new Drill();
            _activeDrillViewModel = new DrillContentViewModel(_activeDrill);
        }

        public ActiveDrillStore(Drill activeDrill)
        {
            _activeDrill = activeDrill;
            _activeDrillViewModel = new DrillContentViewModel(_activeDrill);
        }
    }
}
