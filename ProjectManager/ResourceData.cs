using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    [Serializable]
    public class ResourceData
    {
        private string type;
        private string name;
        private string role;
        private string availablePeriod;
        private string unavailablePeriod;
        private string unavailablePeriodEnd;

        public string Type => type;
        public string Name => name;
        public string Role => role;
        public string AvailablePeriod => availablePeriod;
        public string UnavailablePeriod => unavailablePeriod;
        public string UnavailablePeriodEnd => unavailablePeriodEnd;

        // Method to store data in variables
        public ResourceData(string resourcetype, string resourcename, string resourcerole, string resourceavailablePeriod = "", string resourceunavailablePeriod = "", string resourceunavailablePeriodEnd = "")
        {
            this.type = resourcetype;
            this.name = resourcename;
            this.role = resourcerole;
            this.availablePeriod = resourceavailablePeriod;
            this.unavailablePeriod = resourceunavailablePeriod;
            this.unavailablePeriodEnd = resourceunavailablePeriodEnd;
        }
    }
}
