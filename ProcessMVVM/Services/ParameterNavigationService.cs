using ProcessMVVM.Stores;
using ProcessMVVM.ViewModels;
using System;

namespace ProcessMVVM.Services
{
    public class ParameterNavigationService<TParam, TParam2, TViewModel> where TViewModel : ViewModelBase
    {
        NavigationStore _navigationStore;
        Func<TParam, TParam2, TViewModel> _setViewModel;
        public ParameterNavigationService(NavigationStore navigationStore, Func<TParam, TParam2, TViewModel> setViewModel)
        {
            _navigationStore = navigationStore;
            _setViewModel = setViewModel;
        }
        public void Navigate(TParam param, TParam2 param2)
        {
            _navigationStore.CurrentViewModel = _setViewModel(param, param2);
        }
    }
}
