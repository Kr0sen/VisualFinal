using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class DogTab : StaticTab
    {
        public DogTab(DbSet<Dog>? dBS = null)
        {
            Header = "Dog";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("Nickname");
            DataColumns.Add("Sex");
            DataColumns.Add("Sire");
            DataColumns.Add("Dam");
            DataColumns.Add("Trainer");
            DataColumns.Add("IsFavorite");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Dog>? DBS { get; set; }
    }
}
