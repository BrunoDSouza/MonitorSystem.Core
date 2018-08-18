using System.Collections.Generic;

namespace MonitorSystem.Core.Model
{
    public class Computer
    {

        #region Public Members

        public string NameComputer { get; set; }
        public string Ipv4 { get; set; }
        public string UserName { get; set; }
        public object Processes { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Computer() { }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="nameComputer"></param>
        /// <param name="ipv4"></param>
        /// <param name="userName"></param>
        /// <param name="processes"></param>
        public Computer(string nameComputer, string ipv4, string userName, object processes)
        {
            NameComputer = nameComputer;
            Ipv4 = ipv4;
            UserName = userName;
            Processes = processes;
        }

        #endregion

        #region Equals and Hashcode

        public override bool Equals(object obj)
        {
            var details = obj as Computer;
            return details != null &&
                   NameComputer == details.NameComputer &&
                   Ipv4 == details.Ipv4 &&
                   UserName == details.UserName &&
                   EqualityComparer<object>.Default.Equals(Processes, details.Processes);
        }

        public override int GetHashCode()
        {
            var hashCode = 228897068;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NameComputer);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Ipv4);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UserName);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Processes);
            return hashCode;
        }


        #endregion

    }
}
