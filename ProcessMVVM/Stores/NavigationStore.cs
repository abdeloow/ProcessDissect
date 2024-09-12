using ProcessMVVM.ViewModels;
using System;

namespace ProcessMVVM.Stores
{
    public class NavigationStore
    {
        ViewModelBase _vm;
        public event Action CurrentPropertyChanged;
        public ViewModelBase CurrentViewModel
        {
            get => _vm;
            set
            {
                _vm = value;
                OnCurrentPropertyChanged();
            }
        }
        private void OnCurrentPropertyChanged()
        {
            CurrentPropertyChanged?.Invoke();
        }
    }
}
