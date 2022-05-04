using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using VisualFinal.Models;

namespace VisualFinal.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateTabs();
            CreateDBGS();
            CreateQueries();
            Content = Fv = new FirstViewModel(this);
            Sv = new SecondViewModel(this);
        }
        ViewModelBase content;
        public ViewModelBase Content
        {
            get { return content; }
            set { this.RaiseAndSetIfChanged(ref content, value); }
        }
        public void Change()
        {
            if (Content == Fv)
                Content = Sv;
            else if (Content == Sv)
                Content = Fv;
            else throw new InvalidOperationException();
        }

        ObservableCollection<MyTab> tabs;
        public ObservableCollection<MyTab> Tabs
        {
            get { return tabs; }
            set { this.RaiseAndSetIfChanged(ref tabs, value); }
        }
        ObservableCollection<DataBaseGridSample> dbgs;
        public ObservableCollection<DataBaseGridSample> DBGS
        {
            get { return dbgs; }
            set { this.RaiseAndSetIfChanged(ref dbgs, value); }
        }

        ObservableCollection<Query> queries;
        public ObservableCollection<Query> Queries
        {
            get { return queries; }
            set { this.RaiseAndSetIfChanged(ref queries, value); }
        }

        public FirstViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        private void CreateTabs()
        {
            Tabs = new ObservableCollection<MyTab>();
            Tabs.Add(new StaticTab("Dog"));
            Tabs.Add(new StaticTab("Dog statistics"));
            Tabs.Add(new StaticTab("Trainer"));
            Tabs.Add(new StaticTab("Trainer statistics"));
            Tabs.Add(new StaticTab("Track"));
            Tabs.Add(new StaticTab("Trap"));
            Tabs.Add(new StaticTab("Race"));
            Tabs.Add(new StaticTab("Participant"));
            Tabs.Add(new StaticTab("Bid"));
            Tabs.Add(new StaticTab("Bidder"));
            Tabs.Add(new DynamicTab("ggg"));
            Tabs.Add(new DynamicTab("sadoj"));
            Tabs.Add(new DynamicTab("s123231j"));
        }
        private void CreateDBGS()
        {
            DBGS = new ObservableCollection<DataBaseGridSample>();
            DBGS.Add(new DataBaseGridSample("1", "2", "3", "4", "5"));
            DBGS.Add(new DataBaseGridSample("2", "2", "3", "4", "5"));
            DBGS.Add(new DataBaseGridSample("2", "3", "3", "4", "5"));
            DBGS.Add(new DataBaseGridSample("2", "3", "4", "4", "5"));
            DBGS.Add(new DataBaseGridSample("2", "3", "4", "5", "5"));
            DBGS.Add(new DataBaseGridSample("2", "3", "4", "5", "6"));
        }
        private void CreateQueries()
        {
            Queries = new ObservableCollection<Query>();
            Queries.Add(new Query("1234"));
            Queries.Add(new Query("12534"));
            Queries.Add(new Query("123"));
            Queries.Add(new Query("126734"));
        }
    }
}
