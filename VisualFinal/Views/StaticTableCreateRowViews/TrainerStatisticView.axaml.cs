using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using VisualFinal.ViewModels;
using VisualFinal.ViewModels.StaticTableCreateRowViewModels;

namespace VisualFinal.Views.StaticTableCreateRowViews
{
    public partial class TrainerStatisticView : Window
    {
        public TrainerStatisticView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("Confirm").Click += button_Confirm_Click;
            this.FindControl<Button>("Cancel").Click += button_Cancel_Click;
        }
        public TrainerStatisticView(MainWindowViewModel? mainContext) : this()
        {
            this.DataContext = new TrainerStatisticViewModel(mainContext);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void button_Confirm_Click(object? sender, RoutedEventArgs e)
        {
            var dc = (this.DataContext as TrainerStatisticViewModel);
            dc.MainContext.Data.TrainerStatistics.Add(dc.TrainerStatistic);
            dc.MainContext.Data.SaveChanges();
            this.Close();
        }
        private void button_Cancel_Click(object? sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
