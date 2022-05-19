using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Participant
    {
        public Participant()
        {
        }

        public string TrackName { get; set; } = null!;
        public long RaceNumber { get; set; }
        public string RaceDate { get; set; } = null!;
        public long TrapNumber { get; set; }
        public long? DogId { get; set; }
        public long Place { get; set; }
        public string Time { get; set; } = null!;
    }
}
