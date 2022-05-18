using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class DogStatisticTab : StaticTab
    {
        public DogStatisticTab(string h = "", DbSet<DogStatistic>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("DogId");
            DataColumns.Add("TrackName");
            DataColumns.Add("RaceCount");
            DataColumns.Add("WinCount");
            DataColumns.Add("LongestWinningStreak");
            DataColumns.Add("LongestLosingStreak");
            DataColumns.Add("CurrentWinningStreak");
            DataColumns.Add("CurrentLosingStreak");
            DataColumns.Add("LastRaceDate");
        }

        new public DbSet<DogStatistic>? DBS { get; set; }
    }
}
