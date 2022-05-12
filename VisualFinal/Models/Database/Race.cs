using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Race
    {
        public Race()
        {
            Participants = new HashSet<Participant>();
        }

        public string TrackName { get; set; } = null!;
        public long Number { get; set; }
        public byte[] Date { get; set; } = null!;

        public virtual Track TrackNameNavigation { get; set; } = null!;
        public virtual ICollection<Participant> Participants { get; set; }
    }
}
