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
        FormUtilities formUtilities;

        public Main()
        {
            InitializeComponent();
            createResource = new ResourceMenu();
            createTask = new TaskMenu();
            formUtilities = new FormUtilities();
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
            formUtilities.refreshResourceListbox(createTask.tasks, createResource.resources, lbProjectTasksResources, lbResourceDetails, listView1);
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
            formUtilities.refreshDetailsBox(createTask.tasks, selectedTask, lbTaskDetails);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            populateCalendar();
        }

        // Save the file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUtilities.saveToBinary(createResource.resources, createTask.tasks);
        }

        // Open a saved file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Update lists.....
            createResource.resources = formUtilities.readResourcesFromBinary();
            createTask.tasks = formUtilities.readTasksFromBinary();

            // Finally, destroy the file(s)
            File.Delete(@"C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\SavedStates\resources.xml");
            File.Delete(@"C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\SavedStates\tasks.xml");
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

        private void btPrintResourceDetails_Click(object sender, EventArgs e)
        {
            formUtilities.printSelectedResourceDetails(createResource.resources, lbResourceDetails);
        }
    }
}
