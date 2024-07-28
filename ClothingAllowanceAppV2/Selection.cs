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
        public Selection()
        {
            InitializeComponent();
        }

        //continue button. This takes user to the deduction form
        private void nextbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Deduction();
            myForm.Show();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Home();
            myForm.Show();

        }
    }
}
