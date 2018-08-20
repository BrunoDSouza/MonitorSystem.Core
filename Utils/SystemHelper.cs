using MonitorSystem.Core.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace MonitorSystem.Core.Utils
{
    public class SystemHelper
    {
        public static string GetIPV4()
        {
            var ipv4Addresses = Array.FindLast(
                Dns.GetHostEntry(string.Empty)
                .AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);

            return ipv4Addresses.ToString();
        }

        public static string GetUserName()
        {
            return Environment.UserName;
        }

        public static string GetNameComputer()
        {
            return Environment.MachineName;
        }

        public static List<ProcessRunning> GetProcesses(Process[] array)
        {
            return array.Aggregate(new List<ProcessRunning>(), (newList, process) => {
                var item = new ProcessRunning
                {
                    Id = process.Id,
                    Name = process.ProcessName
                };

                try
                {
                    item.Description = process.MainModule.FileVersionInfo.FileDescription;
                    item.Path = process.MainModule.FileName;
                    item.Version = process.MainModule.FileVersionInfo.FileVersion;
                    item.MemoryAllocation = process.MainModule.ModuleMemorySize.ToString();
                }
                catch
                {
                    item.Description = item.Path = item.Version = item.MemoryAllocation = "Access denied";
                }

                newList.Add(item);
                return newList;
            });
        }

    }
}
