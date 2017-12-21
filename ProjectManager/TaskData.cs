using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    [Serializable]
    public class TaskData
    {
        // Enum to fill combobox
        private Projectphase projectphase;

        private string name;
        private string details;
        private string phase;
        private string deadline;

        // => korte notatie voor { get { return ....; } }
        public string Name => name;
        public string Details => details;
        public string Phase => phase;
        public string Deadline => deadline;



        public TaskData(string taskname, string taskdetails, string taskphase, string taskdeadline = "")
        {
            this.name = taskname;
            this.details = taskdetails;
            this.phase = taskphase;
            this.deadline = taskdeadline;
        }
    }

    public enum Projectphase
    {
        Requirements, 
        Design,
        Implementation, 
        Verification, 
        Maintenance
    }
}
