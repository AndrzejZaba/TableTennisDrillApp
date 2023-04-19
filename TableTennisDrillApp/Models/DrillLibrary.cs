using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Services.DrillsProviders;

namespace TableTennisDrillApp.Models
{
    public class DrillLibrary
    {
        // IDrillsProvider 
        private readonly IDrillsProvider _drillsProvider;

        private readonly IEnumerable<Drill> _drills;

        public IEnumerable<Drill> Drills => _drills;
        public DrillLibrary(IDrillsProvider drillsProvider)
        {
            _drillsProvider = drillsProvider;         
            _drills = new List<Drill>();

            _drills = GetAllDrills().Result;
        }

        // Task GetAllDrills
        public async Task<IEnumerable<Drill>> GetAllDrills()
        {
            return await _drillsProvider.GetAllDrills();
        }


        // GetSelectedDrills -> być może 

    }
}
