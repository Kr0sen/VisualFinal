using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class DogStatistic
    {
        public long DogId { get; set; }
        public string TrackName { get; set; } = null!;
        public long RaceCount { get; set; }
        public long WinCount { get; set; }
        public long LongestWinningStreak { get; set; }
        public long LongestLosingStreak { get; set; }
        public long CurrentWinningStreak { get; set; }
        public long CurrentLosingStreak { get; set; }
        public byte[]? LastRaceDate { get; set; }

        public virtual Dog Dog { get; set; } = null!;
        public virtual Track TrackNameNavigation { get; set; } = null!;
    }
}
