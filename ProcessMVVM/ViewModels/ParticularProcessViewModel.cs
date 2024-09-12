using ProcessMVVM.Commands;
using ProcessMVVM.Models;
using ProcessMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace ProcessMVVM.ViewModels
{
    public class ParticularProcessViewModel : ViewModelBase
    {
        TCPProcess? _selectedProcess;
        int _associatedProcessesCount;
        public IEnumerable<TCPProcess>? Processes;
        public int AssociatedProcessesCount
        {
            get => _associatedProcessesCount;
            set => Set(ref  _associatedProcessesCount, value);
        }
        public TCPProcess? SelectedProcess
        {
            get => _selectedProcess;
            set => Set(ref _selectedProcess, value);
        }
        public ICommand? NextCommand { get; }
        public ICommand? PreviousCommand { get; }
        public ICommand? AssociatedProcessesCommand { get; }
        public ICommand? CloseCommand { get; }
        public ParticularProcessViewModel(NavigationStore navigationStore, TCPProcess process, IEnumerable<TCPProcess> processes)
        {
            _selectedProcess = process;
            Processes = processes;
            CloseCommand = new CloseCommand();
            NextCommand = new MoveCommand(navigationStore, this, true);
            PreviousCommand = new MoveCommand(navigationStore, this, false);
            _associatedProcessesCount = GetAssociatedProcessNumber(SelectedProcess);
            AssociatedProcessesCommand = new NavigateAnalysisCommand(navigationStore, this);
        }
        public int GetAssociatedProcessNumber(TCPProcess? selectedProcess)
        {
            var relatedProcesses = Processes.Where(p => p.ProcessName == selectedProcess.ProcessName).ToList();
            return relatedProcesses.Count;
        }

    }
}
