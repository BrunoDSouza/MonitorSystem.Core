using MonitorSystem.Core.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorSystem.Core.Utils
{
    public class SystemHelper
    {
        public static string GetIPV4()
        {
            return "";
        }

        public static string GetUserName()
        {
            return "";
        }

        public static string GetNameComputer()
        {
            return "";
        }

        public static List<ProcessRunning> GetProcesses(Process[] array)
        {
            return array.Aggregate(new List<ProcessRunning>(), (newList, process) => {
                var item = new ProcessRunning
                {
                    Id = process.Id,
                    Name = process.ProcessName
                };
                process.Modules.Cast<ProcessModule>().ToList()
                    .ForEach(module => {
                        item.Description = module.FileVersionInfo.FileDescription;
                        item.Path = module.FileName;
                        item.Version = module.FileVersionInfo.FileVersion;
                        item.MemoryAllocation = module.ModuleMemorySize.ToString();
                    });

                newList.Add(item);
                return newList;
            });
        }

    }
}
