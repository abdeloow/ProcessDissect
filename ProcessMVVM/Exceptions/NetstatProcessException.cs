using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace ProcessMVVM.Exceptions
{
    public class NetstatProcessException : Exception
    {
        Process NetstatProcess;
        public NetstatProcessException(Process netstatProcess)
        {
            NetstatProcess = netstatProcess;
        }

        public NetstatProcessException(string? message, Process netstatProcess) : base(message)
        {
            NetstatProcess = netstatProcess;
        }

        public NetstatProcessException(string? message, Exception? innerException, Process netstatProcess) : base(message, innerException)
        {
            NetstatProcess = netstatProcess;
        }

        protected NetstatProcessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
