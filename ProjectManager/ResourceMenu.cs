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
    public partial class ResourceMenu : Form
    {
        // class to store resource data
        ResourceData data;

        // bool to check if date has been filled
        bool hasDateBeenFilled;

        // list to store created resources
        private static List<ResourceData> resources = new List<ResourceData>(); 

        public List<ResourceData> Resources { get { return resources; } }

        public ResourceMenu()
        {
            InitializeComponent();

            hideOrShowItems(false);

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
            // Has the date been filled? Call method in another way if not.
            if (hasDateBeenFilled)
            {
                string availableDate = availableDateRange.ToString();
                string unavailableDate = unavailableDateRange.ToString();
                string unavailableDateEnd = unavailableDateRangeEnd.ToString();

                resources.Add(new ResourceData(cbResourceType.SelectedItem.ToString(), tbResourceName.Text, cbResourceRole.SelectedItem.ToString(), availableDate, unavailableDate, unavailableDateEnd));
            }
            else
            {
                resources.Add(new ResourceData(cbResourceType.SelectedItem.ToString(), tbResourceName.Text, cbResourceRole.SelectedItem.ToString()));
            }

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

        void hideOrShowItems(bool HideOrShow)
        {
            label5.Visible = HideOrShow;
            availableDateRange.Visible = HideOrShow;
            label6.Visible = HideOrShow;
            unavailableDateRange.Visible = HideOrShow;
            label7.Visible = HideOrShow;
            unavailableDateRangeEnd.Visible = HideOrShow;

            hasDateBeenFilled = HideOrShow;
        }
    }
}
