using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.Models
{
    public class Query
    {
        public Query(string n = "")
        {
            Name = n;
        }
        public string Name { get; set; }
    }
}
