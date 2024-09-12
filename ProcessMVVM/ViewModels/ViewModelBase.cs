using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProcessMVVM.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return true;
            field = value;
            OnPropertyChanged(propertyName);
            return false;
        }
    }
}
