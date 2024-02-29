using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaoAvaDemo.ViewModels
{
    public class INotifyPropertyChangedViewModel: INotifyPropertyChanged
    {
        public INotifyPropertyChangedViewModel()
        {
            ShowNameCommand = new DelegateCommand<string>(ShowName);
        }
        //Notify 通知 Property 属性 Changed 改变
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //无论是Prism还是CommunityToolki的MVVM模块都是在此接口的基础上进行开发的
        //所以本质都是一样，当一个属性的值发生改变时，对象会引发 PropertyChanged 事件，以通知任何已绑定的元素属性已更改。
        private string _name;
        //这里的Name属性就是提供为View页面绑定的属性值
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        //如果要实现绑定命令，则需要实现ICommand接口，这里使用的还是Prism已经实现好的
        public DelegateCommand<string> ShowNameCommand { get; set; }

        void ShowName(string name) 
        {
            Name = name;
        }
    }
}
