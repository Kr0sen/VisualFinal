using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Participant
    {
        public Participant()
        {
            Bids = new HashSet<Bid>();
        }

        public string TrackName { get; set; } = null!;
        public long RaceNumber { get; set; }
        public byte[] RaceDate { get; set; } = null!;
        public long TrapNumber { get; set; }
        public long? DogId { get; set; }
        public long Place { get; set; }
        public byte[] Time { get; set; } = null!;

        public virtual Dog? Dog { get; set; }
        public virtual Race Race { get; set; } = null!;
        public virtual ICollection<Bid> Bids { get; set; }
    }
}
