using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTennisDrillApp.DTOs
{
    public class DrillDTO
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public TimeSpan DurationTime { get; set; }
        public TimeSpan BreakTime { get; set; }
        public int PlayersNumber { get; set; }
        public int AdvancementLevel { get; set; }
        public string? KeyWords { get; set; }
        public string? Description { get; set; }
        public string? Images { get; set; }
        public string? Videos { get; set; }
    }
}
