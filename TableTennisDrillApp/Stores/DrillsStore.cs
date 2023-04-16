using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.Stores
{
    public class DrillsStore
    {
        private readonly DrillManager _drillManager;
        private readonly List<Drill> _drills;
        private readonly Lazy<Task> _initializeLazy;
        public IEnumerable<Drill> Drills => _drills;

        public DrillsStore(DrillManager drillManager)
        {
            _drillManager = drillManager;
            _initializeLazy = new Lazy<Task>(Initialize);
            
            _drills = new List<Drill>();

        }

        public async Task Load()
        {
            await _initializeLazy.Value;
        }

        private async Task Initialize()
        {
            IEnumerable<Drill> drills = await _drillManager.GetAllDrills();

            _drills.Clear();
            _drills.AddRange(drills);
        }
    }
}
