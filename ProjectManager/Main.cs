using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class Main : Form
    {
        // Menu's voor het aanmaken van resources en tasks
        ResourceMenu creeerResource;
        TaskMenu creeerTask;

        public Main()
        {
            InitializeComponent();
            creeerResource = new ResourceMenu();
            creeerTask = new TaskMenu();
        }

        private void resourceCreationMenuItem_Click(object sender, EventArgs e)
        {
            creeerResource.Show();
        }

        private void taskCreationMenuItem_Click(object sender, EventArgs e)
        {
            creeerTask.Show();
        }
    }
}
