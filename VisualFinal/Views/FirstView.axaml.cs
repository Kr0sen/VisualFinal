using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using VisualFinal.Models;
using VisualFinal.Models.StaticTabs;
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
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            if (selectedTab != null)
            {
                if (selectedTab is DynamicTab)
                {
                    var selectedItems = (selectedTab as DynamicTab).BindedList;
                    if (selectedItems != null)
                        this.Find<DataGrid>("DataTable").Items = selectedItems;
                }
                else
                {
                    if (selectedTab is BidTab)
                    {
                        var selectedItems = (selectedTab as BidTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is BidderTab)
                    {
                        var selectedItems = (selectedTab as BidderTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is DogStatisticTab)
                    {
                        var selectedItems = (selectedTab as DogStatisticTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is DogTab)
                    {
                        var selectedItems = (selectedTab as DogTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is ParticipantTab)
                    {
                        var selectedItems = (selectedTab as ParticipantTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is RaceTab)
                    {
                        var selectedItems = (selectedTab as RaceTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is TrackTab)
                    {
                        var selectedItems = (selectedTab as TrackTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is TrainerStatisticTab)
                    {
                        var selectedItems = (selectedTab as TrainerStatisticTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is TrainerTab)
                    {
                        var selectedItems = (selectedTab as TrainerTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is TrapTab)
                    {
                        var selectedItems = (selectedTab as TrapTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else throw new System.ArgumentException();
                }
            }
        }
        private void dataGrid_AutoGeneratingColumn(object? sender,
        DataGridAutoGeneratingColumnEventArgs e)
        {
            var tab = (this.FindControl<TabControl>("DataTabs").SelectedItem as MyTab);
            if (!tab.DataColumns.Contains(e.Column.Header.ToString()))
                e.Column.IsVisible = false;
        }
    }
}
