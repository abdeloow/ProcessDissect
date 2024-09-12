using ProcessMVVM.Stores;

namespace ProcessMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentPropertyChanged += OnCurrentPropertyChanged;
        }
        private void OnCurrentPropertyChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
