using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Track
    {
        public Track()
        {
        }

        public string Name { get; set; } = null!;
        public double? Distance { get; set; }
    }
}
