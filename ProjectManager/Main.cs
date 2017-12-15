using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectManager
{
    public partial class Main : Form
    {
        // Menu's voor het aanmaken van resources en tasks
        ResourceMenu createResource;
        TaskMenu createTask;

        public Main()
        {
            InitializeComponent();
            createResource = new ResourceMenu();
            createTask = new TaskMenu();
        }

        private void resourceCreationMenuItem_Click(object sender, EventArgs e)
        {
            createResource.ShowDialog();
        }

        private void taskCreationMenuItem_Click(object sender, EventArgs e)
        {
            createTask.ShowDialog();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            refreshResourceListbox(createTask.tasks);
        }


        // List that gets all the created tasks and resources
        public void refreshResourceListbox(List<TaskData> tasks)
        {
            foreach (TaskData r in tasks)
            {
                string taskName = r.TaskName;
                if (lbProjectTasksResources.Items.Contains(taskName))
                {
                    continue;
                }
                else
                {
                    lbProjectTasksResources.Items.Add(taskName);
                    fillCalendar(taskName, r);
                }
            }
        }

        public void refreshDetailsBox(List<TaskData> tasks, string selectedTask)
        {
            lbTaskDetails.Items.Clear();
            foreach (TaskData r in tasks)
            {
                if (r.TaskName == selectedTask)
                {
                    string[] taskItems = new string[] { "Task details:", r.TaskDetails, "\n", "Task phase:", r.TaskPhase, "\n", "Task deadline:", r.TaskDeadline, "\n" };
                    lbTaskDetails.Items.AddRange(taskItems);
                }
            }
        }

        private void lbProjectTasksResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTask;
            try
            {
                selectedTask = lbProjectTasksResources.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            refreshDetailsBox(createTask.tasks, selectedTask);
        }

        private void populateCalendar()
        {
            DateTime calendarDays = new DateTime();
            calendarDays = DateTime.Now;
            listView1.View = View.Details;

            // Add a month to the calendar
            for (int i = 0; i < 31; i++)
            {
                calendarDays = calendarDays.AddDays(1);
                string columnName = calendarDays.ToString("dd/MM/yyyy");
                listView1.Columns.Add(columnName, 75);
            }
        }

        private void fillCalendar(string taskname, TaskData taskdata)
        {
            int columnNumber = 0;
            ListViewItem item = new ListViewItem();
            if (taskdata.TaskDeadline != null)
            {
                foreach (ColumnHeader header in listView1.Columns)
                {
                    if (taskdata.TaskDeadline == header.Text)
                    {
                        if (columnNumber == 0)
                        {
                            item.Text = taskname;
                            break;
                        }
                        item.SubItems.Add(taskname);
                        break;
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }
                    columnNumber++;
                }
            }
            listView1.Items.Add(item);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            populateCalendar();
        }
    }
}
