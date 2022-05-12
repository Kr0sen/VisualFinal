using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using VisualFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace VisualFinal.Views
{
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            InitializeComponent();
            this.Find<DataGrid>("DataTable").AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
            this.FindControl<TabControl>("DataTabs").SelectionChanged += tabControl_SelectionChanged;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void tabControl_SelectionChanged(object? sender,
           SelectionChangedEventArgs e)
        {
            MyTab selectedTab;
            System.Collections.Generic.List<object>? selectedItems;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem as MyTab;
            if (selectedTab != null)
            {
                selectedItems = selectedTab.DatabaseSet;
                if (selectedItems != null)
                    this.Find<DataGrid>("DataTable").Items = selectedItems;
            }
        }
        private void dataGrid_AutoGeneratingColumn(object? sender,
        DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.Column.Header.ToString())
            {
                case "TrainerNavigation":
                    e.Column.IsVisible = false;
                    break;
                case "DogStatistics":
                    e.Column.IsVisible = false;
                    break;
                case "Participants":
                    e.Column.IsVisible = false;
                    break;
                case "Dog":
                    e.Column.IsVisible = false;
                    break;
                case "TrackNameNavigation":
                    e.Column.IsVisible = false;
                    break;
                case "Race":
                    e.Column.IsVisible = false;
                    break;
                case "Bids":
                    e.Column.IsVisible = false;
                    break;
                case "Races":
                    e.Column.IsVisible = false;
                    break;
                case "TrainerStatistics":
                    e.Column.IsVisible = false;
                    break;
                case "Traps":
                    e.Column.IsVisible = false;
                    break;
                case "Dogs":
                    e.Column.IsVisible = false;
                    break;
                case "Trainer":
                    e.Column.IsVisible = false;
                    break;
                case "Participant":
                    e.Column.IsVisible = false;
                    break;
            }
        }
    }
}
