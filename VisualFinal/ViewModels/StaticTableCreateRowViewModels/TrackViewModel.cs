using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class TrackViewModel : ViewModelBase
    {
        public TrackViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Track = new VisualFinal.Models.Database.Track();
        }
        public VisualFinal.Models.Database.Track Track { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
