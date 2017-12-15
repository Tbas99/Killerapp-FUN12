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

        string deadline;

        bool deadlineFilled = false;

        // list to store created tasks
        public List<TaskData> tasks = new List<TaskData>();

        public TaskMenu()
        {
            InitializeComponent();

            hideOrShowItems(false);

            string[] cbWFPhases = new string[] { "Requirements", "Design", "Implementation", "Verification", "Maintenance" };
            cbTaskPhase.Items.AddRange(cbWFPhases);
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
                data = new TaskData(taskName, taskDetails, taskPhase, deadline);
                tasks.Add(data);
            }
            else
            {
                data = new TaskData(taskName, taskDetails, taskPhase);
                tasks.Add(data);
            }

            // Create database connection to parse data
            using (SqlConnection openConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tob\source\repos\ProjectManager\ProjectManager\ProjectManagerData.mdf;Integrated Security = True"))
            {
                string saveQuery = "INSERT into Tasks (Name,Details,Phase,Deadline) VALUES (@Name,@Details,@Phase,@Deadline)";

                using (SqlCommand cmd = new SqlCommand(saveQuery, openConnection))
                {
                    cmd.Connection = openConnection;
                    cmd.Parameters.Add("@Name", SqlDbType.Text).Value = taskName;
                    cmd.Parameters.Add("@Details", SqlDbType.Text).Value = taskDetails;
                    cmd.Parameters.Add("@Phase", SqlDbType.Text).Value = taskPhase;

                    // If date has been filled, then parse it
                    if (deadlineFilled)
                    {
                        cmd.Parameters.Add("@Deadline", SqlDbType.Date).Value = deadline;
                    }
                    else
                    {
                        cmd.Parameters.Add("@Deadline", SqlDbType.Date).Value = DBNull.Value;
                    }

                    // Error handle the connection
                    try
                    {
                        openConnection.Open();
                        int recordsAdded = cmd.ExecuteNonQuery();
                        MessageBox.Show(recordsAdded + " rows have been touched!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Something went wrong with an SQL action....", "SQL-related exception");
                        MessageBox.Show(ex.ToString());
                    }
                    // Catch any other exception other then sql
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong....", "General exception");
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        openConnection.Close();
                    }
                }
            }
            this.Hide();
        }


        public void hideOrShowItems(bool hideOrShow)
        {
            label4.Visible = hideOrShow;
            deadlineDate.Visible = hideOrShow;
            deadlineFilled = hideOrShow;
        }
    }
}
