using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VisualFinal.Models
{
    public class MyTab
    {
        public MyTab(string h = "", List<object>? dbs = null)
        {
            Header = h;
            DatabaseSet = dbs;
        }
        public string Header { get; set; }
        public bool ButtonVisible { get; set; }

        public List<object>? DatabaseSet { get; set; }
    }
}
