using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Linq;
using System.Reactive.Linq;
using VisualFinal.Models;
using VisualFinal.Models.Database;

namespace VisualFinal.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateContext();
            CreateTabs();
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

        ObservableCollection<Query> queries;
        public ObservableCollection<Query> Queries
        {
            get { return queries; }
            set { this.RaiseAndSetIfChanged(ref queries, value); }
        }

        public FirstViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        DatabaseContext data;

        public DatabaseContext Data
        {
            get { return data; }
            set { this.RaiseAndSetIfChanged(ref data, value); }
        }
        private void CreateContext()
        {
            Data = new DatabaseContext();
        }

        private void CreateTabs()
        {
            Tabs = new ObservableCollection<MyTab>();
            Tabs.Add(new StaticTab("Dog", Data.Dogs.ToList<object>()));
            Tabs.Add(new StaticTab("Dog statistics", Data.DogStatistics.ToList<object>()));
            Tabs.Add(new StaticTab("Trainer", Data.Trainers.ToList<object>()));
            Tabs.Add(new StaticTab("Trainer statistics", Data.TrainerStatistics.ToList<object>()));
            Tabs.Add(new StaticTab("Track", Data.Tracks.ToList<object>()));
            Tabs.Add(new StaticTab("Trap", Data.Traps.ToList<object>()));
            Tabs.Add(new StaticTab("Race", Data.Races.ToList<object>()));
            Tabs.Add(new StaticTab("Participant", Data.Participants.ToList<object>()));
            Tabs.Add(new StaticTab("Bid", Data.Bids.ToList<object>()));
            Tabs.Add(new StaticTab("Bidder", Data.Bidders.ToList<object>()));
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
