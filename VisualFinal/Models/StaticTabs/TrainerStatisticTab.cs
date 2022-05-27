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
        public TrainerStatisticTab(DbSet<TrainerStatistic>? dBS = null)
        {
            Header = "TrainerStatistic";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("TrainerId");
            DataColumns.Add("TrackName");
            DataColumns.Add("WinnerCount");
            DataColumns.Add("WinnerFavoriteCount");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<TrainerStatistic>? DBS { get; set; }
    }
}
