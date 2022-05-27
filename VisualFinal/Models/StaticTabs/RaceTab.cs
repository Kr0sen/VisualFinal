using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class RaceTab : StaticTab
    {
        public RaceTab(DbSet<Race>? dBS = null)
        {
            Header = "Race";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("TrackName");
            DataColumns.Add("Number");
            DataColumns.Add("Date");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Race>? DBS { get; set; }
    }
}
