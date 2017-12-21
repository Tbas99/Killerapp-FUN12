using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    class FormUtilities
    {
        #region mainFormFunctions

        public void refreshResourceListbox(List<TaskData> tasks, List<ResourceData> resources, ListBox taskListbox, ListBox resourceListbox, ListView listview)
        {
            foreach (TaskData r in tasks)
            {
                string taskName = r.Name;
                if (taskListbox.Items.Contains(taskName))
                {
                    continue;
                }
                else
                {
                    taskListbox.Items.Add(taskName);
                    fillCalendar(taskName, r, listview);
                }
            }

            foreach (ResourceData r in resources)
            {
                string resourceName = r.Name;
                if (resourceListbox.Items.Contains(resourceName))
                {
                    continue;
                }
                else
                {
                    resourceListbox.Items.Add(resourceName);
                }
            }
        }

        private void fillCalendar(string taskname, TaskData taskdata, ListView listview)
        {
            int columnNumber = 0;
            ListViewItem item = new ListViewItem();
            if (taskdata.Deadline != null)
            {
                foreach (ColumnHeader header in listview.Columns)
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
            listview.Items.Add(item);
        }

        public void refreshDetailsBox(List<TaskData> tasks, string selectedTask, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (TaskData r in tasks)
            {
                if (r.Name == selectedTask)
                {
                    string[] taskItems = new string[] { "Task details:", r.Details, "\n", "Task phase:", r.Phase, "\n", "Task deadline:", r.Deadline, "\n" };
                    listbox.Items.AddRange(taskItems);
                }
            }
        }

        public void printSelectedResourceDetails(List<ResourceData> resources, ListBox listbox)
        {
            string selectedResource;
            try
            {
                selectedResource = listbox.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("U dient eerst een resource te selecteren!");
                return;
            }

            foreach (ResourceData r in resources)
            {
                if (r.Name == selectedResource)
                {
                    string resourceNameFormat = "Resource name: " + r.Name;
                    string resourceTypeFormat = "Resource type: " + r.Type;
                    string resourceRoleFormat = "Resource role: " + r.Role;
                    string[] fileMessage = { resourceNameFormat, resourceTypeFormat, resourceRoleFormat };
                    File.WriteAllLines(@"C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\UserInfo\ResourceDetails.txt", fileMessage);
                }
            }
        }

        // Bunch of functions to save and load items in form e.g. (De)serialization binary-xml
        public void saveToBinary(List<ResourceData> resources, List<TaskData> tasks)
        {
            // Save all resources
            // Create the TextWriter for the serialiser to use, using to dispose it in order to clear resources
            using (Stream filestream = File.Open(@"C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\SavedStates\resources.xml", FileMode.Append))
            {
                //create the serialiser to create the binary file
                var binaryFormatter = new BinaryFormatter();

                //write to the file
                binaryFormatter.Serialize(filestream, resources);
            }

            // Same for the task list....
            using (Stream filestream = File.Open(@"C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\SavedStates\tasks.xml", FileMode.Append))
            {
                var binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(filestream, tasks);
            }
        }

        // Extract resources from binary xml
        public List<ResourceData> readResourcesFromBinary()
        {
            using (Stream filestream = File.Open(@"C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\SavedStates\resources.xml", FileMode.Open))
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
            using (Stream filestream = File.Open(@"C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\SavedStates\tasks.xml", FileMode.Open))
            {
                //create the serialiser to modify/read the binary file
                var binaryFormatter = new BinaryFormatter();

                // Return list contents to application
                return (List<TaskData>)binaryFormatter.Deserialize(filestream);
            }
        }
        #endregion

        #region taskToDatabase
        TaskData data;
        public void parseTaskDatabaseData(TaskMenu form, bool deadlineFilled, string taskName, string taskDetails, string taskPhase, string deadline = "")
        {
            // Add new task to list
            data = new TaskData(taskName, taskDetails, taskPhase, deadline);
            form.tasks.Add(data);

            // Create database connection to parse data
            using (SqlConnection openConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\ProjectManagerData.mdf;Integrated Security=True"))
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
            form.clearFormState();
            form.Hide();
        }
        #endregion

        #region resourceToDatabase
        ResourceData rdata;
        public void parseResourceDatabaseData(ResourceMenu form, bool dateFilled, string resourceType, string resourceName, string resourceRole, string availableDate = "", string unavailableDate = "", string unavailableDateEnd = "")
        {

            rdata = new ResourceData(resourceType, resourceName, resourceRole);
            form.resources.Add(rdata);
            // Create database connection to parse data
            using (SqlConnection openConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\ProjectManagerData.mdf;Integrated Security=True"))
            {
                string saveQuery = "INSERT into Resources (Resource,Name,Role,AvailableDate,UnavailableDate,UnavailableDateEnd) VALUES (@Resource,@Name,@Role,@AvailableDate,@UnavailableDate,@UnavailableDateEnd)";

                using (SqlCommand cmd = new SqlCommand(saveQuery, openConnection))
                {
                    cmd.Connection = openConnection;
                    cmd.Parameters.Add("@Resource", SqlDbType.Text).Value = resourceType;
                    cmd.Parameters.Add("@Name", SqlDbType.Text).Value = resourceName;
                    cmd.Parameters.Add("@Role", SqlDbType.Text).Value = resourceRole;

                    // If date has been filled, then parse it
                    if (dateFilled)
                    {
                        cmd.Parameters.Add("@AvailableDate", SqlDbType.Date).Value = availableDate;
                        cmd.Parameters.Add("@UnavailableDate", SqlDbType.Date).Value = unavailableDate;
                        cmd.Parameters.Add("@UnavailableDateEnd", SqlDbType.Date).Value = unavailableDateEnd;
                    }
                    else
                    {
                        cmd.Parameters.Add("@AvailableDate", SqlDbType.Date).Value = DBNull.Value;
                        cmd.Parameters.Add("@UnavailableDate", SqlDbType.Date).Value = DBNull.Value;
                        cmd.Parameters.Add("@UnavailableDateEnd", SqlDbType.Date).Value = DBNull.Value;
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
            // Close the window succesfully
            form.clearFormState();
            form.Hide();
        }
        #endregion
    }
}
