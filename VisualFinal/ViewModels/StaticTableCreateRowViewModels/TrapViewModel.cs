using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class TrapViewModel : ViewModelBase
    {
        public TrapViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Trap = new VisualFinal.Models.Database.Trap();
        }
        public VisualFinal.Models.Database.Trap Trap { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
