using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Trainer
    {
        public Trainer()
        {
        }

        public long Id { get; set; }
        public string FullName { get; set; } = null!;
        public long DogCount { get; set; }
        public long FavoriteCount { get; set; }
    }
}
