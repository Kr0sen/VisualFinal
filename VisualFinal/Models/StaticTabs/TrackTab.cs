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
        public TrackTab(string h = "", DbSet<Track>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Name");
            DataColumns.Add("Distance");
        }

        new public DbSet<Track>? DBS { get; set; }
    }
}
