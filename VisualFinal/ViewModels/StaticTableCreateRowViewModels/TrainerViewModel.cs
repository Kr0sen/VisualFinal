using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class TrainerViewModel : ViewModelBase
    {
        public TrainerViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Trainer = new VisualFinal.Models.Database.Trainer();
        }
        public VisualFinal.Models.Database.Trainer Trainer { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
