using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Track
    {
        public Track()
        {
            DogStatistics = new HashSet<DogStatistic>();
            Races = new HashSet<Race>();
            TrainerStatistics = new HashSet<TrainerStatistic>();
            Traps = new HashSet<Trap>();
        }

        public string Name { get; set; } = null!;
        public double? Distance { get; set; }

        public virtual ICollection<DogStatistic> DogStatistics { get; set; }
        public virtual ICollection<Race> Races { get; set; }
        public virtual ICollection<TrainerStatistic> TrainerStatistics { get; set; }
        public virtual ICollection<Trap> Traps { get; set; }
    }
}
