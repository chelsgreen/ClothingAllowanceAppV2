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
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            //Ensures the user enters both first and last name
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                // Display a message box to the user
                MessageBox.Show("Please enter both first and last names.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Combine the first and last names with a space between them
            string fullName = firstName + " " + lastName;

            // Create a new AllowanceHolder instance with the combined name
            AllowanceHolder newHolder = new AllowanceHolder(fullName);
           
            AllowanceManager manager = new AllowanceManager();           
            // Add the new allowance holder
            am.AddAllowanceHolder(newHolder); // Add new holder to AllowanceManager
           

            //Clear the text boxes after adding the holder
            txtFirstName.Clear();
            txtLastName.Clear();

          
                this.Hide();
                var myForm = new Selection(am);
                myForm.Show();
           
        }

        //takes user back to home form
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Home(am);
            myForm.Show();
        }
    }
}
