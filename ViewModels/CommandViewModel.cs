using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaoAvaDemo.ViewModels
{
    public class CommandViewModel:BindableBase
    {
        public CommandViewModel()
        {
            HandleButtonCommand = new DelegateCommand<string>(HandleButton);
        }

        private int commandcount = 0;
        /// <summary>
        /// 计数
        /// </summary>
        public int commandCount
        {
            get { return commandcount; }
            set { commandcount = value;RaisePropertyChanged();}
        }

        public DelegateCommand<string> HandleButtonCommand { get; set; }

        void HandleButton(string count)
        {
            commandCount = int.Parse(count);
            commandCount--;
        }
    }
}
