using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.Models
{
    public class DynamicTab : MyTab
    {
        public DynamicTab(string h = "") : base(h)
        {
            ButtonVisible = true;
        }
    }
}
