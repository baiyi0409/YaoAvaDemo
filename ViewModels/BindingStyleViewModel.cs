using ImTools;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using YaoAvaDemo.Models;

namespace YaoAvaDemo.ViewModels
{
    public class BindingStyleViewModel:BindableBase
    {
        public BindingStyleViewModel() 
        {
            Items = new ObservableCollection<ItemsClass>();
            Items.Add(new ItemsClass{ Title = "1", IsRight = true });
            Items.Add(new ItemsClass{ Title = "2", IsRight = false });
            Items.Add(new ItemsClass{ Title = "3", IsRight = false });
            Items.Add(new ItemsClass{ Title = "4", IsRight = true });
        }

        private ObservableCollection<ItemsClass> items;

        public ObservableCollection<ItemsClass> Items
        {
            get { return items; }
            set { items = value; RaisePropertyChanged(); }
        }

    }
}
