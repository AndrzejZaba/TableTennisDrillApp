using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.Stores
{
    public class ActiveDrillStore
    {
        private Drill _activeDrill;
        public Drill ActiveDrill
        {
            get { return _activeDrill; }
            set { _activeDrill = value; }
        }

        public ActiveDrillStore(Drill activeDrill)
        {
            _activeDrill = activeDrill;
        }
    }
}
