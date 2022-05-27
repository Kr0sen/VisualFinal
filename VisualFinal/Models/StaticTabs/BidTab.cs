using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class BidTab : StaticTab
    {
        public BidTab(DbSet<Bid>? dBS = null)
        {
            Header = "Bid";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("TrackName");
            DataColumns.Add("RaceNumber");
            DataColumns.Add("RaceDate");
            DataColumns.Add("TrapNumber");
            DataColumns.Add("BidderId");
            DataColumns.Add("Size");
            DataColumns.Add("Gain");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Bid>? DBS { get; set; }
    }
}
