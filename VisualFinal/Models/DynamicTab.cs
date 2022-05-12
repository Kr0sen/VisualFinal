using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.Models
{
    public class DynamicTab : MyTab
    {
        public DynamicTab(string h = "", List<object>? dbs = null) : base(h, dbs)
        {
            ButtonVisible = true;
        }
        public Query BindedQuery { get; set; }
    }
}
