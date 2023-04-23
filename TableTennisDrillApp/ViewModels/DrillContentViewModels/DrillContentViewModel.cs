using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.ViewModels.DrillContentViewModels
{
    public class DrillContentViewModel
    {
        private readonly Drill _drill;

        public List<string> Images => _drill.Images;
        public List<string> Description => _drill.Description;
        public TimeSpan DurationTime => _drill.DurationTime;

        public DrillContentViewModel(Drill drill)
        {
            _drill = drill;
        }

    }
}
