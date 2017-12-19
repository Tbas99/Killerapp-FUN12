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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
                string taskName = r.Name;
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
                if (r.Name == selectedTask)
                {
                    string[] taskItems = new string[] { "Task details:", r.Details, "\n", "Task phase:", r.Phase, "\n", "Task deadline:", r.Deadline, "\n" };
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
                string columnName = calendarDays.ToString("dd/MM/yyyy");
                listView1.Columns.Add(columnName, 75);
                calendarDays = calendarDays.AddDays(1);
            }
        }

        private void fillCalendar(string taskname, TaskData taskdata)
        {
            int columnNumber = 0;
            ListViewItem item = new ListViewItem();
            if (taskdata.Deadline != null)
            {
                foreach (ColumnHeader header in listView1.Columns)
                {
                    if (taskdata.Deadline == header.Text)
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
                        if (columnNumber != 0)
                        {
                            item.SubItems.Add("");
                        }
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

        // Save the file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToBinary(createResource.resources, createTask.tasks);
        }

        // Open a saved file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Update lists.....
            createResource.resources = readResourcesFromBinary();
            createTask.tasks = readTasksFromBinary();

            // Finally, destroy the file(s)
            File.Delete(@"C:\Users\Tob\source\repos\ProjectManager\ProjectManager\SavedStates\resources.xml");
            File.Delete(@"C:\Users\Tob\source\repos\ProjectManager\ProjectManager\SavedStates\tasks.xml");
        }

        public void saveToBinary(List<ResourceData> resources, List<TaskData> tasks)
        {
            // Save all resources
            // Create the TextWriter for the serialiser to use, using to dispose it in order to clear resources
            using (Stream filestream = File.Open(@"C:\Users\Tob\source\repos\ProjectManager\ProjectManager\SavedStates\resources.xml", FileMode.Append))
            {
                //create the serialiser to create the binary file
                var binaryFormatter = new BinaryFormatter();

                //write to the file
                binaryFormatter.Serialize(filestream, resources);
            }

            // Same for the task list....
            using (Stream filestream = File.Open(@"C:\Users\Tob\source\repos\ProjectManager\ProjectManager\SavedStates\tasks.xml", FileMode.Append))
            {
                var binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(filestream, tasks);
            }
        }

        // Extract resources from binary xml
        public List<ResourceData> readResourcesFromBinary()
        {
            using (Stream filestream = File.Open(@"C:\Users\Tob\source\repos\ProjectManager\ProjectManager\SavedStates\resources.xml", FileMode.Open))
            {
                //create the serialiser to modify/read the binary file
                var binaryFormatter = new BinaryFormatter();

                // Return list contents to application
                return (List<ResourceData>)binaryFormatter.Deserialize(filestream);
            }
        }

        // Extract tasks from binary xml
        public List<TaskData> readTasksFromBinary()
        {
            using (Stream filestream = File.Open(@"C:\Users\Tob\source\repos\ProjectManager\ProjectManager\SavedStates\tasks.xml", FileMode.Open))
            {
                //create the serialiser to modify/read the binary file
                var binaryFormatter = new BinaryFormatter();

                // Return list contents to application
                return (List<TaskData>)binaryFormatter.Deserialize(filestream);
            }
        }
    }
}
