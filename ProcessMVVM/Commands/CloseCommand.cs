using ProcessMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace ProcessMVVM.Commands
{
    public class CloseCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            if(parameter is Window window)
            {
                window.Close();
            }
        }
    }
}
