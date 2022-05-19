using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class DogViewModel : ViewModelBase
    {
        public DogViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Dog = new VisualFinal.Models.Database.Dog();
        }
        public VisualFinal.Models.Database.Dog Dog { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
