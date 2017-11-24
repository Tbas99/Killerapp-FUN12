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
    public partial class WelcomeSelection : Form
    {
        // Get user path to select xml file
        string startupPath = @"C:\Users\Tob\source\repos\ProjectManager\ProjectManager\SavedStates";
        string fileName = "";

        public WelcomeSelection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openSavedState.Filter = "XML Files (*.xml)|*.xml";
            openSavedState.FilterIndex = 0;
            openSavedState.DefaultExt = "xml";
            openSavedState.InitialDirectory = startupPath;
            openSavedState.ShowDialog();
            fileName = openSavedState.FileName;
        }
    }
}
