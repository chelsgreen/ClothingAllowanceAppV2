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
            int deductionAmount = (int)deductionnud.Value;
            int selectedYear = dateTimePicker1.Value.Year; // Get the selected year

            if (deductionAmount > 300)
            {
                MessageBox.Show("Error: You cannot enter a value greater than $300.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var allowanceHolder = am.GetAllowanceHolderByName(selectedName);

            if (allowanceHolder != null)
            {
                float remainingAllowance = allowanceHolder.CalculateAllowance(selectedYear);

                if (deductionAmount > remainingAllowance)
                {
                    MessageBox.Show($"Error: Insufficient funds. You only have ${remainingAllowance} remaining.", "Invalid Deduction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string result = am.DeductAllowance(selectedName, deductionAmount, dateTimePicker1.Value, selectedBonus, "Clothing Price $");

                // Set the bonus activity for the selected year
                allowanceHolder.SetBonusActivity(selectedBonus, selectedYear);

                Summaryrtbx.Text = am.GetAllowanceHolderSummary(selectedName);

                MessageBox.Show($"You have deducted ${deductionAmount} from the allowance.", "Deduction Confirmation");

                this.Hide();
                Home myNewForm = new Home(am);
                myNewForm.Closed += (s, args) => this.Close();
                myNewForm.Show();
            }
            else
            {
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          am.SetYear(dateTimePicker1.Value.Year);
        }

        private void Summaryrtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
