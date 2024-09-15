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

   
        // Method to handle button click for deduction
        private void button1_Click(object sender, EventArgs e)
        {
            // Gets the deduction amount from the numeric up-down control
            int deductionAmount = (int)deductionnud.Value;

            // Check if the deduction amount exceeds the maximum allowed value
            if (deductionAmount > 300)
            {
                //displays message back to the user 
                MessageBox.Show("Error: You cannot enter a value greater than $300.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }

            // Retrieve the selected allowance holder
            var allowanceHolder = am.GetAllowanceHolderByName(selectedName);

            if (allowanceHolder != null)
            {
                // Get the remaining allowance for the selected year
                float remainingAllowance = allowanceHolder.CalculateAllowance(am.GetSelectYear());

                // Check if the deduction exceeds the available allowance
                if (deductionAmount > remainingAllowance)
                {
                    //displays message back to the user 
                    MessageBox.Show($"Error: Insufficient funds. You only have ${remainingAllowance} remaining.", "Invalid Deduction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop further execution
                }

                // Log or debug to ensure flow
                Console.WriteLine($"Deduction of ${deductionAmount} is valid. Proceeding with deduction.");

                // Proceed with the deduction if both checks pass
                string result = am.DeductAllowance(selectedName, deductionAmount, dateTimePicker1.Value, selectedBonus, "Clothing Price $");

                // Set the bonus activity for the selected holder
                allowanceHolder.SetBonusActivity(selectedBonus);

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
            else
            {
                // If allowance holder is not found
                MessageBox.Show("Error: Allowance holder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Takes user back to the home form
        private void exitbtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myform = new Stats(am);
            myform.Show();
        }      


        // Method to handle numeric up-down value changes
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            deductionnud.Maximum = decimal.MaxValue;           
            deductionnud.Minimum = 0;
        }

    }
}
