using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.Services.DrillsProviders
{
    public class DatabaseDrillsProvider : IDrillsProvider
    {
        public Task<IEnumerable<Drill>> GetAllDrills()
        {
            throw new NotImplementedException();
        }
    }
}
