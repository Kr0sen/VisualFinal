using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class TrainerTab : StaticTab
    {
        public TrainerTab(string h = "", DbSet<Trainer>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("FullName");
            DataColumns.Add("DogCount");
            DataColumns.Add("FavoriteCount");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Trainer>? DBS { get; set; }
    }
}
