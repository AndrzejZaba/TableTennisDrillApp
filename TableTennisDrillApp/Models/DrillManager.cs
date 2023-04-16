using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTennisDrillApp.Models
{
    public class DrillManager
    {
        private readonly DrillLibrary _drillLibrary;

        public DrillManager(DrillLibrary drillLibrary)
        {
            _drillLibrary = drillLibrary;
        }

        public async Task<IEnumerable<Drill>> GetAllDrills()
        {
            return await _drillLibrary.GetAllDrills();
        }

    }
}
