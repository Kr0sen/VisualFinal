using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Bid
    {
        public string TrackName { get; set; } = null!;
        public long RaceNumber { get; set; }
        public string RaceDate { get; set; } = null!;
        public long TrapNumber { get; set; }
        public long BidderId { get; set; }
        public double Size { get; set; }
        public double Gain { get; set; }
    }
}
