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
        private string name;
        private string details;
        private string phase;
        private string deadline;

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
}
