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
        FormUtilities formfunction;

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

            formfunction = new FormUtilities();

            hideOrShowItems(false);

            // Set datepickers to default starting values
            availableDateRange.Value = DateTime.Now;
            unavailableDateRange.Value = DateTime.Now;
            unavailableDateRangeEnd.Value = DateTime.Now.AddDays(7);

            cbResourceRole.DataSource = Enum.GetValues(typeof(ResourceRole));
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
            string resourceName;

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
            finally
            {
                resourceName = tbResourceName.Text;
            }


            // Has the date been filled? Call method in another way if not.
            // Adds resource to public list.
            if (hasDateBeenFilled)
            {
                availableDate = availableDateRange.Value.ToString("dd/MM/yyyy");
                unavailableDate = unavailableDateRange.Value.ToString("dd/MM/yyyy");
                unavailableDateEnd = unavailableDateRangeEnd.Value.ToString("dd/MM/yyyy");

                formfunction.parseResourceDatabaseData(this, hasDateBeenFilled, resourceType, resourceName, resourceRole, availableDate, unavailableDate, unavailableDateEnd);
            }
            else
            {
                formfunction.parseResourceDatabaseData(this, hasDateBeenFilled, resourceType, resourceName, resourceRole);
            }
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

        public void clearFormState()
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
