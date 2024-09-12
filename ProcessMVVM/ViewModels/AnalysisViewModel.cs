using ProcessMVVM.Commands;
using ProcessMVVM.Models;
using ProcessMVVM.Services;
using ProcessMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Input;

namespace ProcessMVVM.ViewModels
{
    public class AnalysisViewModel : ViewModelBase
    {
        private readonly IEnumerable<TCPProcess> _originalActiveProcessList;
        TCPProcess _selectedTCPProcess;
        public IEnumerable<TCPProcess>? RelatedProcesses { get; }
        public IEnumerable<int>? LocalPorts => RelatedProcesses.Select( p => p.LocalPort );
        public IEnumerable<IPAddress> LocalIPs => RelatedProcesses.Select(p => p.LocalIP);
        public IEnumerable<int>? RemotePorts => RelatedProcesses.Select(p => p.RemotePort);
        public IEnumerable<IPAddress> RemoteIPs => RelatedProcesses.Select(p => p.RemoteIP);
        public TCPProcess SelectedTCPProcess
        {
            get => _selectedTCPProcess;
            set => Set(ref _selectedTCPProcess, value);
        }
        public int? ProcessCount => RelatedProcesses?.Count();
        public ICommand? CloseCommand { get; }
        public ICommand? PreviousViewCommand { get; }
        public AnalysisViewModel(NavigationStore navigationStore, IEnumerable<TCPProcess> relatedProcesses, TCPProcess selectedTCPProcess)
        {
            _originalActiveProcessList = relatedProcesses;
            _selectedTCPProcess = selectedTCPProcess;
            RelatedProcesses = GetRelatedProcesses(_originalActiveProcessList);
            CloseCommand = new CloseCommand();
            PreviousViewCommand = new NavigateCommand<ParticularProcessViewModel>(new NavigationService<ParticularProcessViewModel>(navigationStore, () => new ParticularProcessViewModel(navigationStore, SelectedTCPProcess, _originalActiveProcessList)));
        }

        private IEnumerable<TCPProcess>? GetRelatedProcesses(IEnumerable<TCPProcess> relatedProcesses)
        {
            return relatedProcesses.Where(p => p.ProcessName == _selectedTCPProcess.ProcessName);
        }
    }
}
