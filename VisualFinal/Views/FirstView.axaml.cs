using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using VisualFinal.Models;
using VisualFinal.Models.StaticTabs;
using Microsoft.EntityFrameworkCore;
using VisualFinal.ViewModels;
using VisualFinal.ViewModels.StaticTableCreateRowViewModels;
using VisualFinal.Views.StaticTableCreateRowViews;
using VisualFinal.Models.Database;

namespace VisualFinal.Views
{
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            InitializeComponent();
            this.Find<DataGrid>("DataTable").AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
            this.Find<DataGrid>("DataTable").PropertyChanged += dataGrid_PropertyChanged;
            this.FindControl<TabControl>("DataTabs").SelectionChanged += tabControl_SelectionChanged;
            this.FindControl<Button>("CreateNew").Click += button_CreateNew_Click;
            this.FindControl<Button>("Delete").Click += button_Delete_Click;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void changeDataGridItems()
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            if (selectedTab != null)
            {
                if (selectedTab is DynamicTab)
                {
                    var selectedItems = (selectedTab as DynamicTab).ObjectList;
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
        private void refreshDataGridItems()
        {
            this.Find<DataGrid>("DataTable").Items = null;
            changeDataGridItems();
        }
        private void tabControl_SelectionChanged(object? sender,
           SelectionChangedEventArgs e)
        {
            changeDataGridItems();
        }
        private void dataGrid_AutoGeneratingColumn(object? sender,
        DataGridAutoGeneratingColumnEventArgs e)
        {
            var tab = (this.FindControl<TabControl>("DataTabs").SelectedItem as MyTab);
            if (tab is DynamicTab) (this.DataContext as FirstViewModel).ButtonsEnabled = false;
            else (this.DataContext as FirstViewModel).ButtonsEnabled = true;
            if (!tab.DataColumns.Contains(e.Column.Header.ToString()))
                e.Column.IsVisible = false;
        }
        private void dataGrid_PropertyChanged(object? sender, AvaloniaPropertyChangedEventArgs e)
        {
            if (this.DataContext is not null)
                if (this.FindControl<TabControl>("DataTabs").SelectedItem is not DynamicTab)
                    (this.DataContext as FirstViewModel).MainContext.Data.SaveChanges();
        }

        async private void button_CreateNew_Click(object? sender, RoutedEventArgs e)
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            Window window;
            if (selectedTab != null)
            {
                if (selectedTab is BidTab)
                {
                    window = new BidView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is BidderTab)
                {
                    window = new BidderView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is DogStatisticTab)
                {
                    window = new DogStatisticView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is DogTab)
                {
                    window = new DogView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is ParticipantTab)
                {
                    window = new ParticipantView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is RaceTab)
                {
                    window = new RaceView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is TrackTab)
                {
                    window = new TrackView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is TrainerStatisticTab)
                {
                    window = new TrainerStatisticView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is TrainerTab)
                {
                    window = new TrainerView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is TrapTab)
                {
                    window = new TrapView((this.DataContext as FirstViewModel).MainContext);
                }
                else throw new System.ArgumentException();
                await window.ShowDialog((Window)this.VisualRoot);
                refreshDataGridItems();
            }
        }
        private void button_Delete_Click(object? sender, RoutedEventArgs e)
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            var dgItem = this.Find<DataGrid>("DataTable").SelectedItem;
            if (selectedTab != null && dgItem != null)
            {
                if (selectedTab is BidTab)
                {
                    (selectedTab as BidTab).DBS.Remove(dgItem as Bid);
                }
                else if (selectedTab is BidderTab)
                {

                    (selectedTab as BidderTab).DBS.Remove(dgItem as Bidder);
                }
                else if (selectedTab is DogStatisticTab)
                {

                    (selectedTab as DogStatisticTab).DBS.Remove(dgItem as DogStatistic);
                }
                else if (selectedTab is DogTab)
                {

                    (selectedTab as DogTab).DBS.Remove(dgItem as Dog);
                }
                else if (selectedTab is ParticipantTab)
                {

                    (selectedTab as ParticipantTab).DBS.Remove(dgItem as Participant);
                }
                else if (selectedTab is RaceTab)
                {

                    (selectedTab as RaceTab).DBS.Remove(dgItem as Race);
                }
                else if (selectedTab is TrackTab)
                {

                    (selectedTab as TrackTab).DBS.Remove(dgItem as Track);
                }
                else if (selectedTab is TrainerStatisticTab)
                {

                    (selectedTab as TrainerStatisticTab).DBS.Remove(dgItem as TrainerStatistic);
                }
                else if (selectedTab is TrainerTab)
                {

                    (selectedTab as TrainerTab).DBS.Remove(dgItem as Trainer);
                }
                else if (selectedTab is TrapTab)
                {

                    (selectedTab as TrapTab).DBS.Remove(dgItem as Trap);
                }
                else throw new System.ArgumentException();
                (this.DataContext as FirstViewModel).MainContext.Data.SaveChanges();
                refreshDataGridItems();
            }
        }
    }
}