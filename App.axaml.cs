using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using Prism.Services.Dialogs;
using YaoAvaDemo.Extension;
using YaoAvaDemo.Pages;
using YaoAvaDemo.ViewModels;
using YaoAvaDemo.Views;

namespace YaoAvaDemo
{
    public partial class App : PrismApplication
    {
        protected override AvaloniaObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnInitialized()
        {
            //var dialog = Container.Resolve<IDialogService>();

            //dialog.ShowDialog("LoginView", result =>
            //{
            //    if (result.Result != ButtonResult.OK)
            //    {
            //        return;
            //    }
            //});
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginView,LoginViewModel>();
            containerRegistry.RegisterForNavigation<MainWindow,MainWindowViewModel>();
            containerRegistry.RegisterForNavigation<MainView,MainWindowViewModel>();
            containerRegistry.RegisterForNavigation<StyleView,StyleViewModel>();
            containerRegistry.RegisterForNavigation<ControlThemesView, ControlThemesViewModel>();
            containerRegistry.RegisterForNavigation<CommandView, CommandViewModel>();
            containerRegistry.RegisterForNavigation<INotifyPropertyChangedView, INotifyPropertyChangedViewModel>();
            containerRegistry.RegisterForNavigation<BindingStyleView, BindingStyleViewModel>();
            containerRegistry.RegisterForNavigation<BindingControlView>();
            containerRegistry.RegisterForNavigation<MaskView>();
        }
    }
}