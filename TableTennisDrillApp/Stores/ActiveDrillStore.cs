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
        private static ActiveDrillStore _instance = null;
        private static object _instanceLock = new object();

        private Drill? _activeDrill ;
        private ViewModelBase _activeDrillViewModel;

        public Drill ActiveDrill
        {
            get 
            { 
                return _activeDrill; 
            }
            set 
            { 
                _activeDrill = value; 
                OnActiveDrillChanged();
            }
        }

        public ViewModelBase ActiveDrillViewModel
        {
            get => _activeDrillViewModel;
            set
            {
                _activeDrillViewModel = value;
            }
        }
        private ActiveDrillStore()
        {
            _activeDrill = new Drill();
            _activeDrillViewModel = new DrillContentViewModel(_activeDrill);
            ActiveDrillChanged += UpdateDrillStore;
        }

        public static ActiveDrillStore GetStore()
        {
            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new ActiveDrillStore();
                }
            }
            return _instance;
        }

        public event Action? ActiveDrillChanged;

        private void OnActiveDrillChanged()
        {
            ActiveDrillChanged?.Invoke();
        }

        public void UpdateDrillStore()
        {
            _activeDrillViewModel = new DrillContentViewModel(ActiveDrill);
        }
    }
}
