using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorSystem.Core.Model
{
    public class ProcessRunning
    {
        #region Public Members

        public long Id { get; set; }
        public string Name { get; set; }
        public string MemoryAllocation { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ProcessRunning() { }
        
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="memoryAllocation"></param>
        /// <param name="path"></param>
        /// <param name="description"></param>
        /// <param name="version"></param>
        public ProcessRunning(long id, string name, string memoryAllocation, string path, string description, string version)
        {
            Id = id;
            Name = name;
            MemoryAllocation = memoryAllocation;
            Path = path;
            Description = description;
            Version = version;
        }

        #endregion
    }
}
