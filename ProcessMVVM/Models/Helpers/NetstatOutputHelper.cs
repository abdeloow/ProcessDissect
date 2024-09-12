using ProcessMVVM.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProcessMVVM.Models.Helpers
{
    public static class NetstatOutputHelper
    {
        const string _fileName = "Netstat";
        const string _arguments = "-ano -p tcp";
        public static List<string> GetNetstatOutput()
        {
            List<string> netstatOutput = new List<string>();
            Process process = ConfigureProcess();
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            if (output != null)
            {
                string[] lines = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    if (line.Contains("TCP"))
                        netstatOutput.Add(line);
                }
            }
            else
            {
                throw new NetstatProcessException(process);
            }
            return netstatOutput;
        }
        static Process ConfigureProcess()
        {
            Process process = new Process();
            process.StartInfo.FileName = _fileName;
            process.StartInfo.Arguments = _arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            return process;
        }
    }
}
