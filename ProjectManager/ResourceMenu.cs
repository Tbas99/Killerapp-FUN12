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
using System.Globalization;

namespace ProjectManager
{
    public partial class ResourceMenu : Form
    {
        // class to store resource data
        ResourceData data;

        // bool to check if date has been filled
        bool hasDateBeenFilled;

        // Store date values to parse them into the database later
        string availableDate;
        string unavailableDate;
        string unavailableDateEnd;

        // list to store created resources
        public List<ResourceData> resources = new List<ResourceData>();

        public ResourceMenu()
        {
            InitializeComponent();

            hideOrShowItems(false);

            // Set datepickers to default starting values
            availableDateRange.Value = DateTime.Now;
            unavailableDateRange.Value = DateTime.Now;
            unavailableDateRangeEnd.Value = DateTime.Now.AddDays(7);

            string[] cbResourceRoleItems = new string[] { "Freelancer", "Trainee", "HR", "IT", "Support", "Management", "Accountancy", "Lead worker", "Finance" };
            cbResourceRole.Items.AddRange(cbResourceRoleItems);
        }

        private void cbResourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbResourceType.SelectedItem.ToString();
            
            if (selectedItem == "Human")
            {
                hideOrShowItems(true);
            }
            else
            {
                hideOrShowItems(false);
            }
        }

        private void btCreateResource_Click(object sender, EventArgs e)
        {
            // Variables to make a method call easier to read and to avoid string conversion in a method call
            string resourceType;
            string resourceRole;

            // Error happens when no value is selected and/or a person has typed in the field
            try
            {
                resourceType = cbResourceType.SelectedItem.ToString();
                resourceRole = cbResourceRole.SelectedItem.ToString();
            }
            catch
            {
                // No value selected
                // Proceed with entered text unless that is empty aswell
                if (cbResourceRole.Text == null || cbResourceType.Text == null)
                {
                    MessageBox.Show("U dient een rol/type te specificeren!");
                    return;
                }
                else
                {
                    resourceType = cbResourceType.Text;
                    resourceRole = cbResourceRole.Text;
                }
            }


            // Has the date been filled? Call method in another way if not.
            // Adds resource to public static list.
            if (hasDateBeenFilled)
            {
                availableDate = availableDateRange.Value.ToString("dd/MM/yyyy");
                unavailableDate = unavailableDateRange.Value.ToString("dd/MM/yyyy");
                unavailableDateEnd = unavailableDateRangeEnd.Value.ToString("dd/MM/yyyy");

                data = new ResourceData(resourceType, tbResourceName.Text, resourceRole, availableDate, unavailableDate, unavailableDateEnd);
                resources.Add(data);
            }
            else
            {
                data = new ResourceData(resourceType, tbResourceName.Text, resourceRole);
                resources.Add(data);
            }

            // Create database connection to parse data
            using(SqlConnection openConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tob\source\repos\ProjectManager\ProjectManager\ProjectManagerData.mdf;Integrated Security=True"))
            {
                string saveQuery = "INSERT into Resources (Resource,Name,Role,AvailableDate,UnavailableDate,UnavailableDateEnd) VALUES (@Resource,@Name,@Role,@AvailableDate,@UnavailableDate,@UnavailableDateEnd)";

                using (SqlCommand cmd = new SqlCommand(saveQuery, openConnection))
                {
                    cmd.Connection = openConnection;
                    cmd.Parameters.Add("@Resource", SqlDbType.Text).Value = data.Type;
                    cmd.Parameters.Add("@Name", SqlDbType.Text).Value = data.Name;
                    cmd.Parameters.Add("@Role", SqlDbType.Text).Value = data.Role;

                    // If date has been filled, then parse it
                    if (hasDateBeenFilled)
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
            clearFormState();
            this.Hide();
        }

        private void btAddRole_Click(object sender, EventArgs e)
        {
            string roleName = tbNewResourceRole.Text;

            if (String.IsNullOrWhiteSpace(roleName))
            {
                MessageBox.Show("Er is geen rolnaam ingevuld!");
            }
            else
            {
                cbResourceRole.Items.Add(roleName);
                tbNewResourceRole.Clear();
            }
        }

        private void btDeleteRole_Click(object sender, EventArgs e)
        {
            cbResourceRole.Items.Remove(cbResourceRole.SelectedItem);
        }


        // Hide a bunch of irrelevant items, or show them
        private void hideOrShowItems(bool HideOrShow)
        {
            label5.Visible = HideOrShow;
            availableDateRange.Visible = HideOrShow;
            label6.Visible = HideOrShow;
            unavailableDateRange.Visible = HideOrShow;
            label7.Visible = HideOrShow;
            unavailableDateRangeEnd.Visible = HideOrShow;
            label8.Visible = HideOrShow;

            hasDateBeenFilled = HideOrShow;
        }

        private void clearFormState()
        {
            //cbResourceType.SelectedIndex = -1;
            tbNewResourceRole.Clear();
            tbResourceName.Clear();
            //cbResourceRole.SelectedIndex = -1;
            availableDateRange.Value = DateTime.Now;
            unavailableDateRange.Value = DateTime.Now;
            unavailableDateRangeEnd.Value = DateTime.Now.AddDays(7);
        }
    }
}
