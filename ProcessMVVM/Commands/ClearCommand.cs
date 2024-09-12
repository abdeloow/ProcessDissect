using ProcessMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMVVM.Commands
{
    public class ClearCommand : CommandBase
    {
        HomeViewModel _vm;
        public ClearCommand(HomeViewModel vm)
        {
            _vm = vm;
        }
        public override void Execute(object? parameter)
        {
            _vm.ActiveTcpProcesses.Clear();
            _vm.ProcessCount = 0;
        }
    }
}
