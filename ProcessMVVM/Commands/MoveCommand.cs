using ProcessMVVM.Stores;
using ProcessMVVM.ViewModels;
using System.Linq;
using System.Windows;

namespace ProcessMVVM.Commands
{
    public class MoveCommand : CommandBase
    {
        ParticularProcessViewModel _vm;
        NavigationStore _navigationStore;
        bool _isNext;
        public MoveCommand(NavigationStore navigationStore, ParticularProcessViewModel vm, bool isNext)
        {
            _navigationStore = navigationStore;
            _vm = vm;
            _isNext = isNext;
        }
        public override void Execute(object? parameter)
        {
            Move(_isNext);
            _vm.AssociatedProcessesCount = _vm.GetAssociatedProcessNumber(_vm.SelectedProcess);
            var oldVm = _vm;
            _vm = new ParticularProcessViewModel(_navigationStore, oldVm.SelectedProcess, oldVm.Processes);
            _navigationStore.CurrentViewModel = _vm;
        }

        private void Move(bool isNext)
        {
            var selectedProcess = _vm.SelectedProcess;
            int index = _vm.Processes.ToList().IndexOf(selectedProcess);
            if (isNext)
            {
                if (index + 1 < _vm.Processes.Count() && _vm.Processes.ToList()[index + 1 ] != null)
                    _vm.SelectedProcess = _vm.Processes.ToList()[index + 1];
                else
                    MessageBox.Show("There is no More Processes To Browse", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (!isNext)
            {
                if (index - 1 >= 0)
                    _vm.SelectedProcess = _vm.Processes.ToList()[index - 1];
                else
                    MessageBox.Show("There is no More Processes To Browse", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
