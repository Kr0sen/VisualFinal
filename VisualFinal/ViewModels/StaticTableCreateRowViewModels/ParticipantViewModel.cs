using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class ParticipantViewModel : ViewModelBase
    {
        public ParticipantViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Participant = new VisualFinal.Models.Database.Participant();
        }
        public VisualFinal.Models.Database.Participant Participant { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
