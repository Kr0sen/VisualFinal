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
        public MyTab(string h = "")
        {
            Header = h;
        }
        public string Header { get; set; }
        public bool ButtonVisible { get; set; }
    }
}
