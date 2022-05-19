using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Dog
    {
        public Dog()
        {
        }

        public long Id { get; set; }
        public string Nickname { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public string? Sire { get; set; }
        public string? Dam { get; set; }
        public long Trainer { get; set; }
        public bool? IsFavorite { get; set; } = null!;
    }
}
