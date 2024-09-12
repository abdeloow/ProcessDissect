using ProcessMVVM.Models;
using ProcessMVVM.Stores;
using ProcessMVVM.ViewModels;
using ProcessMVVM.Views;
using System.Collections.Generic;

namespace ProcessMVVM.Commands
{
    public class DetailsCommand : CommandBase
    {
        private readonly IEnumerable<TCPProcess> processes;
        NavigationStore _navgiationStore;
        public DetailsCommand(IEnumerable<TCPProcess> tCPProcesses)
        {
            _navgiationStore = new NavigationStore();
            processes = tCPProcesses;
        }
        public override bool CanExecute(object? parameter)
        {
            return parameter != null;
        }
        public override void Execute(object? parameter)
        {
            _navgiationStore.CurrentViewModel = new ParticularProcessViewModel(_navgiationStore, parameter as TCPProcess, processes);
            SecondWindow secondWindow = new SecondWindow()
            {
                DataContext = new MainViewModel(_navgiationStore)
            };
            secondWindow.Show();
        }
    }
}
