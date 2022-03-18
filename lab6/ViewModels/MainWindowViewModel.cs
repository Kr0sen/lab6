using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using lab6.Models;

namespace lab6.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public Plan[] ItemsAll { get; set; }

        ViewModelBase content;
        public MainWindowViewModel()
        {
            ItemsAll = BuildAllPlans();
            Content = Fv = new FirstViewModel(ItemsAll);
        }

        public ViewModelBase Content
        {
            set => this.RaiseAndSetIfChanged(ref content, value);
            get => content;
        }
        public FirstViewModel Fv
        {
            get;
        }
        private Plan[] BuildAllPlans()
        {
            return new Plan[]
            {
                new Plan("plan1","todo1", DateTime.Today.AddDays(0)),
                new Plan("plan2","todo2", DateTime.Today.AddDays(1) ),
                new Plan("plan3","todo3", DateTime.Today.AddDays(2) ),
                new Plan("plan4","todo4", DateTime.Today.AddDays(3) ),
                new Plan("plan5","todo5", DateTime.Today.AddDays(4) ),
                new Plan("plan6","todo6", DateTime.Today.AddDays(5) ),
                new Plan("plan7","todo7", DateTime.Today.AddDays(6) ),
                new Plan("plan8","todo8", DateTime.Today.AddDays(7) ),
                new Plan("plan9","todo9", DateTime.Today.AddDays(8) ),
                new Plan("plan10","todo10", DateTime.Today.AddDays(9) ),
                new Plan("plan11","todo11", DateTime.Today.AddDays(-1) ),
                new Plan("plan12","todo12", DateTime.Today.AddDays(-2) ),
                new Plan("plan13","todo13", DateTime.Today.AddDays(-3) ),
                new Plan("plan14","todo14", DateTime.Today.AddDays(-4) ),
                new Plan("plan15","todo15", DateTime.Today.AddDays(-5) ),
                new Plan("plan16","todo16", DateTime.Today.AddDays(-6) ),
                new Plan("plan17","todo17", DateTime.Today.AddDays(-7) ),
                new Plan("plan18","todo18", DateTime.Today.AddDays(-8) ),
                new Plan("plan19","todo19", DateTime.Today.AddDays(-9) )
            };
        }
    }
}
