using System;
using System.Windows.Forms;

namespace ClothingAllowanceAppV2
{
    public partial class Deduction : Form
    {
        AllowanceManager am;
        private string selectedName;
        private string selectedBonus;
        public Deduction(AllowanceManager am, string selectedName, string selectedBonus)
        {
            InitializeComponent();
            this.am = am;
            this.selectedName = selectedName;
            this.selectedBonus = selectedBonus;

            dateTimePicker1.Value = new DateTime(am.GetSelectYear(),01,01);
            Summaryrtbx.Text = am.AllowanceHolderSummary();

        }

        public Deduction(AllowanceManager am)
        {
            this.am = am;
        }

        //Deducts the allowance amount from the holder then takes user back to home screen
        private void button1_Click(object sender, EventArgs e)
        {
            int deductionAmount = (int)deductionnud.Value;

            // Call DeductAllowance method with required parameters
            string result = am.DeductAllowance(selectedName, deductionAmount, dateTimePicker1.Value, selectedBonus, "Clothing Price $");

            // Set the bonus activity for the selected holder
            var allowanceHolder = am.GetAllowanceHolderByName(selectedName);
            if (allowanceHolder != null)
            {
                allowanceHolder.SetBonusActivity(selectedBonus);
            }

            // Update the summary display
            Summaryrtbx.Text = am.GetAllowanceHolderSummary(selectedName);

            // Show confirmation message
            MessageBox.Show($"You have deducted ${deductionAmount} from the allowance.", "Deduction Confirmation");

            // Navigate to the Home form
            this.Hide();
            Home myNewForm = new Home(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }


        private void exitbtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myform = new Stats(am);
            myform.Show();
        }

        //displays to user the summary of the allowance holder
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event here
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //stops user from entering a value that is higher than $300 
            deductionnud.Maximum = 300;
            deductionnud.Minimum = 0;
        }
    }
}
