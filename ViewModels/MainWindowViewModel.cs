using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System.Collections.ObjectModel;
using YaoAvaDemo.Models;

namespace YaoAvaDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        //区域管理功能
        private readonly IRegionManager regionManager;
        public MainWindowViewModel(IRegionManager regionManager)
        {
            CreateNavigate();
            this.regionManager = regionManager;
            NavigateCommand = new DelegateCommand<NavigateModel>(Navigate);
        }

        private ObservableCollection<NavigateModel> navigatebar;
        /// <summary>
        /// 导航栏集合
        /// </summary>
        public ObservableCollection<NavigateModel> NavigateBar
        {
            get { return navigatebar; }
            set { navigatebar = value; RaisePropertyChanged();}
        }

        void CreateNavigate()
        {
            NavigateBar = new ObservableCollection<NavigateModel>();
            NavigateBar.Add(new NavigateModel { Icon = "cog", Title = "StyleView", NameSpace = "StyleView" });
            NavigateBar.Add(new NavigateModel { Icon = "cog", Title = "ControlThemesView", NameSpace = "ControlThemesView" });
            NavigateBar.Add(new NavigateModel { Icon = "cog", Title = "CommandView", NameSpace = "CommandView" });
            NavigateBar.Add(new NavigateModel { Icon = "cog", Title = "INotifyPropertyChangedView", NameSpace = "INotifyPropertyChangedView" });
            NavigateBar.Add(new NavigateModel { Icon = "cog", Title = "BindingStyleView", NameSpace = "BindingStyleView" });
            NavigateBar.Add(new NavigateModel { Icon = "cog", Title = "BindingControlView", NameSpace = "BindingControlView" });
            NavigateBar.Add(new NavigateModel { Icon = "cog", Title = "MaskView", NameSpace = "MaskView" });
        }

        public DelegateCommand<NavigateModel> NavigateCommand { get; set; }
        /// <summary>
        /// 导航命令
        /// </summary>
        void Navigate(NavigateModel item)
        {
            if (item == null || string.IsNullOrWhiteSpace(item.NameSpace))
                return;
            regionManager.Regions[Extension.RegionManager.MainViewRegionName].RequestNavigate(item.NameSpace);
        }
    }
}
