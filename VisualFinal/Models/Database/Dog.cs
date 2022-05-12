using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Dog
    {
        public Dog()
        {
            DogStatistics = new HashSet<DogStatistic>();
            Participants = new HashSet<Participant>();
        }

        public long Id { get; set; }
        public string Nickname { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public string? Sire { get; set; }
        public string? Dam { get; set; }
        public long Trainer { get; set; }
        public byte[] IsFavorite { get; set; } = null!;

        public virtual Trainer TrainerNavigation { get; set; } = null!;
        public virtual ICollection<DogStatistic> DogStatistics { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
    }
}
