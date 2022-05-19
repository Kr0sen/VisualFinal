using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Trap
    {
        public string TrackName { get; set; } = null!;
        public long TrapNumber { get; set; }
        public long RaceCount { get; set; }
        public long WinnerCount { get; set; }
    }
}
