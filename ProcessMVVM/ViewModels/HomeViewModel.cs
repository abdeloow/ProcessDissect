using ProcessMVVM.Commands;
using ProcessMVVM.Models;
using ProcessMVVM.Services;
using ProcessMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace ProcessMVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        
        private int _processCount;
        private TCPProcess _currentTcpProcess;
        string _searchValue;
        public int ProcessCount
        {
            get => _processCount;
            set => Set(ref _processCount, value);
        }
        public TCPProcess CurrentTcpProcess
        {
            get => _currentTcpProcess;
            set => Set(ref _currentTcpProcess, value);
        }
        public string SearchValue
        {
            get => _searchValue;
            set
            {
                Set(ref _searchValue, value);
                UpdateProcessesList(_searchValue);
            }
        }
        public ObservableCollection<TCPProcess> ActiveTcpProcesses { get; }
        public ICommand RefreshCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand DetailsCommand { get; }
        public HomeViewModel(List<string> netstatOutput)
        {
            ActiveTcpProcesses = new ObservableCollection<TCPProcess>(GetActiveProcesses(netstatOutput));
            _processCount = ActiveTcpProcesses.Count;
            ClearCommand = new ClearCommand(this);
            RefreshCommand = new RefreshCommand(this);
            DetailsCommand = new DetailsCommand(ActiveTcpProcesses);
        }
        public IEnumerable<TCPProcess> GetActiveProcesses(List<string> netstatOutput)
        {
            if(netstatOutput.Count > 0)
            {
                foreach(string line in netstatOutput)
                {
                    TCPProcess process = GetTcpProcess(line);
                    yield return process;
                }
            }
        }
        private TCPProcess GetTcpProcess(string line)
        {
            string[] columns = Regex.Split(line.Trim(), "\\s+");
            string protocol = columns[0];
            string[] localComm = columns[1].Split(':');
            string[] remoteComm = columns[2].Split(':');
            IPAddress localIp = IPAddress.Parse(localComm[0]);
            int localPort = int.Parse(localComm[1]);
            IPAddress remoteIp = IPAddress.Parse(remoteComm[0]);
            int remotePort = int.Parse(remoteComm[1]);
            string status = columns[3];
            int processId = int.Parse(columns[4]);
            string processName;
            try
            {
                processName = Process.GetProcessById(processId).ProcessName;
            }
            catch (Exception)
            {
                processName = "Unknown";
            }
            return new TCPProcess(processName,processId, protocol, localIp, localPort, remoteIp, remotePort, status);
        }
        private void UpdateProcessesList(string searchValue)
        {
            if (!string.IsNullOrEmpty(searchValue))
            {
                var processes = ActiveTcpProcesses.Where(p => p.ProcessName.StartsWith(searchValue)).ToList();
                if(processes.Count > 0)
                {
                    ActiveTcpProcesses.Clear();
                    foreach( var process in processes)
                        ActiveTcpProcesses.Add(process);
                }
            }
        }
    }
}
