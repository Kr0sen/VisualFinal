using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class BidderTab : StaticTab
    {
        public BidderTab(DbSet<Bidder>? dBS = null)
        {
            Header = "Bidder";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("FullName");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Bidder>? DBS { get; set; }
    }
}
