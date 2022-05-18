using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class TrainerStatisticTab : StaticTab
    {
        public TrainerStatisticTab(string h = "", DbSet<TrainerStatistic>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("TrainerId");
            DataColumns.Add("TrackName");
            DataColumns.Add("WinnerCount");
            DataColumns.Add("WinnerFavoriteCount");
        }

        new public DbSet<TrainerStatistic>? DBS { get; set; }
    }
}
