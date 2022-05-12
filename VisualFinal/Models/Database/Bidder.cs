using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Bidder
    {
        public long Id { get; set; }
        public string FullName { get; set; } = null!;
    }
}
