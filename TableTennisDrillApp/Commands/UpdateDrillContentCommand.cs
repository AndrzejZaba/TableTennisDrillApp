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
        public UpdateDrillContentCommand() {}

        public override void Execute(object? parameter)
        {
            ActiveDrillStore.GetStore().UpdateDrillStore();
        }
    }
}
