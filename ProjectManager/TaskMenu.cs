using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class TaskMenu : Form
    {
        TaskData data;
        FormUtilities formfunction;

        string deadline;

        bool deadlineFilled = false;

        // list to store created tasks
        public List<TaskData> tasks = new List<TaskData>();

        public TaskMenu()
        {
            InitializeComponent();

            formfunction = new FormUtilities();

            hideOrShowItems(false);

            cbTaskPhase.DataSource = Enum.GetValues(typeof(Projectphase));
        }


        private void showDeadline_CheckedChanged(object sender, EventArgs e)
        {
            if (showDeadline.Checked)
            {
                hideOrShowItems(true);
            }
            else
            {
                hideOrShowItems(false);
            }
        }

        private void btCreateTask_Click(object sender, EventArgs e)
        {
            string taskName = tbTaskName.Text;
            string taskPhase = cbTaskPhase.Text;
            string taskDetails = tbTaskDetails.Text;

            if (deadlineFilled)
            {
                deadline = deadlineDate.Value.ToString("dd/MM/yyyy");
                formfunction.parseTaskDatabaseData(this, deadlineFilled, taskName, taskDetails, taskPhase, deadline);
            }
            else
            {
                formfunction.parseTaskDatabaseData(this, deadlineFilled, taskName, taskDetails, taskPhase);
            }
        }


        private void hideOrShowItems(bool hideOrShow)
        {
            label4.Visible = hideOrShow;
            deadlineDate.Visible = hideOrShow;
            deadlineFilled = hideOrShow;
        }

        public void clearFormState()
        {
            tbTaskName.Clear();
            tbTaskDetails.Clear();
            tbTaskDetails.Clear();
            cbTaskPhase.SelectedIndex = -1;
            showDeadline.Checked = false;
            deadlineDate.Value = DateTime.Now;
        }
    }
}
