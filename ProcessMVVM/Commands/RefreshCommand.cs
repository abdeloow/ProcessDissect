using ProcessMVVM.Models;
using ProcessMVVM.Models.Helpers;
using ProcessMVVM.ViewModels;
using System.Collections.Generic;

namespace ProcessMVVM.Commands
{
    public class RefreshCommand : CommandBase
    {
        HomeViewModel _vm;
        public RefreshCommand(HomeViewModel vm)
        {
            _vm = vm;
        }
        public override void Execute(object? parameter)
        {
            IEnumerable<TCPProcess> activeProcesses = _vm.GetActiveProcesses(NetstatOutputHelper.GetNetstatOutput());
            _vm.ActiveTcpProcesses.Clear();
            foreach (TCPProcess process in activeProcesses)
            {
                _vm.ActiveTcpProcesses.Add(process);
            }
            _vm.ProcessCount = _vm.ActiveTcpProcesses.Count;
        }
    }
}
