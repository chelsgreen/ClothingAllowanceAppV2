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
    public partial class NewHolder : Form
    {
        private AllowanceManager am;
        public NewHolder(AllowanceManager am)
        {
            this.am = am;
            InitializeComponent();
        }

        private void continuebtn4_Click(object sender, EventArgs e)
        {
            string newHolderName = newNametbx.Text.Trim();
            if (!string.IsNullOrEmpty(newHolderName))
            {
                AllowanceHolder newHolder = new AllowanceHolder(newHolderName);
                am.AddAllowanceHolder(newHolder); // Add new holder to AllowanceManager

                // Close the form to return to Selection form
                this.Hide();
                var myForm = new Selection(am);
                myForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid name.");
            }
        }

        private void newNametbx_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
