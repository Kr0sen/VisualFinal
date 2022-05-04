using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.Models
{
    public class StaticTab : MyTab
    {
        public StaticTab(string h = "") : base(h)
        {
            ButtonVisible = false;
        }
    }
}
