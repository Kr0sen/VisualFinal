using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Linq;
using System.Reactive.Linq;
using VisualFinal.Models;
using VisualFinal.Models.Database;
using VisualFinal.Models.StaticTabs;

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
            Tabs.Add(new DogTab(Data.Dogs));
            Tabs.Add(new DogStatisticTab(Data.DogStatistics));
            Tabs.Add(new TrainerTab(Data.Trainers));
            Tabs.Add(new TrainerStatisticTab(Data.TrainerStatistics));
            Tabs.Add(new TrackTab(Data.Tracks));
            Tabs.Add(new TrapTab(Data.Traps));
            Tabs.Add(new RaceTab(Data.Races));
            Tabs.Add(new ParticipantTab(Data.Participants));
            Tabs.Add(new BidTab(Data.Bids));
            Tabs.Add(new BidderTab(Data.Bidders));
        }
        private void CreateQueries()
        {
            Queries = new ObservableCollection<Query>();
        }
    }
}
