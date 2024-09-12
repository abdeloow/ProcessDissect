using ProcessMVVM.Services;
using ProcessMVVM.Stores;
using ProcessMVVM.ViewModels;

namespace ProcessMVVM.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        NavigationService<TViewModel> _setNavigation;
        public NavigateCommand(NavigationService<TViewModel> setNavigation)
        {
            _setNavigation = setNavigation;
        }
        public override void Execute(object? parameter)
        {
            _setNavigation.Navigate();
        }
    }
}
