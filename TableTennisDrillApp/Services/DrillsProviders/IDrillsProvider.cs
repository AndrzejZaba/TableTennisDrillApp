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
        Task<List<Drill>> GetAllDrillsAsync();
        Task<List<Drill>> GetSelectedDrillsAsync(List<string> selectedCategories);
    }
}
