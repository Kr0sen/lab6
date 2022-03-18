using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.Reactive.Linq;
using lab6.Models;

namespace lab6.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {
        public FirstViewModel(Plan[] ItemsAll)
        {
            itemsAll = ItemsAll;
            changeItems(DateTime.Today);
        }
        public void changeItems(DateTime SelectedTime)
        {
            items.Clear();
            foreach (var item in itemsAll)
            {
                if (item.Date.Equals(SelectedTime)) items.Add(item);
            }
            ItemsSelected = new ObservableCollection<Plan>(items);
        }
        public ObservableCollection<Plan> itemsSelected;
        public ObservableCollection<Plan> ItemsSelected
        {
            get
            {
                return itemsSelected;
            }
            set 
            { 
                this.RaiseAndSetIfChanged(ref itemsSelected, value); 
            } 
        }
        private List<Plan> items = new List<Plan>();
        private Plan[] itemsAll;
    }
}
