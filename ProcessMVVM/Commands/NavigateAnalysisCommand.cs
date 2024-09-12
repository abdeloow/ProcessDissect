using ProcessMVVM.Stores;
using ProcessMVVM.ViewModels;
using System.Windows.Controls;

namespace ProcessMVVM.Commands
{
    public class NavigateAnalysisCommand : CommandBase
    {
        NavigationStore _navigationStore;
        ParticularProcessViewModel _vm;
        public NavigateAnalysisCommand(NavigationStore navigationStore, ParticularProcessViewModel vm)
        {
            _navigationStore = navigationStore;
            _vm = vm;
        }
        public override bool CanExecute(object? parameter)
        {
            return _vm.AssociatedProcessesCount > 1;
        }
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new AnalysisViewModel(_navigationStore, _vm.Processes, _vm.SelectedProcess);
        }
    }
}
