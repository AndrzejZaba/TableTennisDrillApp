using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Stores;
using TableTennisDrillApp.ViewModels.DrillContentViewModels;

namespace TableTennisDrillApp.Commands
{
    public class UpdateDrillContentCommand : CommandBase
    {
        private ActiveDrillStore _activeDrillStore;
        public ActiveDrillStore ActiveDrillStore { get => _activeDrillStore; set => _activeDrillStore = value; }

        public UpdateDrillContentCommand(ActiveDrillStore activeDrillStore)
        {
            _activeDrillStore = activeDrillStore;
        }

        public override void  Execute(object? parameter)
        {
            _activeDrillStore.ActiveDrillViewModel = new DrillContentViewModel(ActiveDrillStore.ActiveDrill);
            //ActiveDrillStore.ActiveDrillViewModel = new DrillContentViewModel(ActiveDrillStore.ActiveDrill);
        }


    }
}
