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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Takes user to the selection form 
        private void continuebtn_Click(object sender, EventArgs e)
        {              
            this.Hide();
            var myForm = new Selection();
            myForm.Show();
        }

        //Takes user to the stats form 
        private void statsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myform = new Stats();
            myform.Show();
              
        }

        //Closes program
        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
