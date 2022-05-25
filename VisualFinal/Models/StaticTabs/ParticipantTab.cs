using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class ParticipantTab : StaticTab
    {
        public ParticipantTab(string h = "", DbSet<Participant>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("TrackName");
            DataColumns.Add("RaceNumber");
            DataColumns.Add("RaceDate");
            DataColumns.Add("TrapNumber");
            DataColumns.Add("DogId");
            DataColumns.Add("Place");
            DataColumns.Add("Time");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Participant>? DBS { get; set; }
    }
}
