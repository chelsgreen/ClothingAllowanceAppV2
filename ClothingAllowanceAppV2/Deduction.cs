using System;
using System.Windows.Forms;

namespace ClothingAllowanceAppV2
{
    public partial class Deduction : Form
    {
        AllowanceManager am;

        public Deduction(AllowanceManager am)
        {
            InitializeComponent();
            this.am = am;
           // Summaryrtbx.Text = am.AllowanceHolderSummary();
        }

        //Deducts the allowance amount from the holder then takes user back to home screen
        private void button1_Click(object sender, EventArgs e)
        {
           
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

        }
    }
}
