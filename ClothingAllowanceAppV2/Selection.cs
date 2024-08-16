using ClothingAllowanceAppV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingAllowanceAppV2
{
    public partial class Selection : Form
    {
        private AllowanceManager am;


        public Selection(AllowanceManager am)
        {
            this.am = am;
            InitializeComponent();
            PopulateComboBox();
        }
        private void PopulateComboBox()
        {
            // Get all holder names from AllowanceManager
            var names = am.GetAllHolderNames();

            // Set the ComboBox data source
            namecbx.DataSource = names;
        }

        // Continue button. This takes the user to the deduction form
        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (namecbx.SelectedIndex >= 0)
            {
                // Retrieve the selected name from the ComboBox
                string selectedName = namecbx.SelectedItem.ToString();

                // Check if the selected name already exists in the AllowanceManager
                if (am.GetAllowanceHolderByName(selectedName) == null)
                {
                    // Create a new AllowanceHolder with the selected name
                    AllowanceHolder newHolder = new AllowanceHolder(selectedName);

                    // Add the new holder to the AllowanceManager
                    am.AddAllowanceHolder(newHolder);
                }

                // Proceed to the Deduction form with the selected name
                this.Hide();
                var myForm = new Deduction(am, selectedName);
                myForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a name from the list.");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Home(am);
            myForm.Show();
        }

        //takes the user to the new holder forn
        private void newholderbtn_Click(object sender, EventArgs e)
        {
            var newHolderForm = new NewHolder(am);
            newHolderForm.FormClosed += (s, args) => PopulateComboBox(); // Refresh ComboBox after NewHolder closes
            this.Hide();
            newHolderForm.Show();
        }
           
        

        private void namecbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle ComboBox selection change if needed
            
        }

        private void bonuselectioncbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}