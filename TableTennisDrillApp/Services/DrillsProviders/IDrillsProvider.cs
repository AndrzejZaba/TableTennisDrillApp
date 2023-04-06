using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.Services.DrillsProviders
{
    public interface IDrillsProvider
    {
        IEnumerable<Drill> GetAllDrills();
    }
}
