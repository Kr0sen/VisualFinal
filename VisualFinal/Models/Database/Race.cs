using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Race
    {
        public Race()
        {
        }

        public string TrackName { get; set; } = null!;
        public long Number { get; set; }
        public string Date { get; set; } = null!;
    }
}
