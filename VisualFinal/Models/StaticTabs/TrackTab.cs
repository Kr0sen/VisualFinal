using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class TrackTab : StaticTab
    {
        public TrackTab(DbSet<Track>? dBS = null)
        {
            Header = "Track";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Name");
            DataColumns.Add("Distance");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Track>? DBS { get; set; }
    }
}
