using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class TaskData
    {
        private string taskName;
        private string taskDetails;
        private string taskPhase;
        private string taskDeadline;

        public string TaskName => taskName;
        public string TaskDetails => taskDetails;
        public string TaskPhase => taskPhase;
        public string TaskDeadline => taskDeadline;

        public TaskData(string taskname, string taskdetails, string taskphase, string taskdeadline = "")
        {
            this.taskName = taskname;
            this.taskDetails = taskdetails;
            this.taskPhase = taskphase;
            this.taskDeadline = taskdeadline;
        }
    }
}
