using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class DogStatisticViewModel : ViewModelBase
    {
        public DogStatisticViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            DogStatistic = new VisualFinal.Models.Database.DogStatistic();
        }
        public VisualFinal.Models.Database.DogStatistic DogStatistic { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
