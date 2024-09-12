using ProcessMVVM.Stores;
using ProcessMVVM.ViewModels;
using System;

namespace ProcessMVVM.Services
{
    public class NavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _setViewModel;
        public NavigationService(NavigationStore navigationStore, Func<TViewModel> setViewModel)
        {
            _navigationStore = navigationStore;
            _setViewModel = setViewModel;
        }
        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _setViewModel();
        }
    }
}
