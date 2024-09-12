using System.Net;

namespace ProcessMVVM.Models
{
    public class TCPProcess
    {
        public string ProcessName { get; }
        public int ProcessID { get; }
        public string Protocol { get; }
        public IPAddress LocalIP { get; }
        public int LocalPort { get; }
        public IPAddress RemoteIP { get; }
        public int RemotePort { get; }
        public string Status { get; }
        public TCPProcess(string processName, int processID, string protocol, IPAddress localIP, int localPort, IPAddress remoteIP, int remotePort, string status)
        {
            ProcessName = processName;
            ProcessID = processID;
            Protocol = protocol;
            LocalIP = localIP;
            LocalPort = localPort;
            RemoteIP = remoteIP;
            RemotePort = remotePort;
            Status = status;
        }
    }
}
