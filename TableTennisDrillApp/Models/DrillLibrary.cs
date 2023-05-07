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

        private List<Drill> _drills;

        public List<Drill> Drills
        {
            get
            {
                return _drills;
            }
            set
            {
                _drills = value;
            }
        }
        
        public DrillLibrary(IDrillsProvider drillsProvider)
        {
            _drillsProvider = drillsProvider;         
            _drills = new List<Drill>();

            _drills = GetAllDrills().Result;
        }

        // Task GetAllDrills
        public async Task<List<Drill>> GetAllDrills()
        {
            return await _drillsProvider.GetAllDrillsAsync();
        }


        // GetSelectedDrills -> być może 
        public async Task<List<Drill>> GetSelectedDrillsAsync(List<string> selectedCategories)
        {
            return await Task.Run(() => _drillsProvider.GetSelectedDrillsAsync(selectedCategories));
        }
    }
}
