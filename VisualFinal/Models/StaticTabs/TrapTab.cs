using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class TrapTab : StaticTab
    {
        public TrapTab(DbSet<Trap>? dBS = null)
        {
            Header = "Trap";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("TrackName");
            DataColumns.Add("TrapNumber");
            DataColumns.Add("RaceCount");
            DataColumns.Add("WinnerCount");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Trap>? DBS { get; set; }
    }
}
