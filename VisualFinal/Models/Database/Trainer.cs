using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Trainer
    {
        public Trainer()
        {
            Dogs = new HashSet<Dog>();
            TrainerStatistics = new HashSet<TrainerStatistic>();
        }

        public long Id { get; set; }
        public string FullName { get; set; } = null!;
        public long DogCount { get; set; }
        public long FavoriteCount { get; set; }

        public virtual ICollection<Dog> Dogs { get; set; }
        public virtual ICollection<TrainerStatistic> TrainerStatistics { get; set; }
    }
}
