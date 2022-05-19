using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class TrainerStatisticViewModel : ViewModelBase
    {
        public TrainerStatisticViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            TrainerStatistic = new VisualFinal.Models.Database.TrainerStatistic();
        }
        public VisualFinal.Models.Database.TrainerStatistic TrainerStatistic { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
