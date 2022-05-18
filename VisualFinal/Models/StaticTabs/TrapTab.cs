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
        public TrapTab(string h = "", DbSet<Trap>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("TrackName");
            DataColumns.Add("TrapNumber");
            DataColumns.Add("RaceCount");
            DataColumns.Add("WinnerCount");
        }

        new public DbSet<Trap>? DBS { get; set; }
    }
}
