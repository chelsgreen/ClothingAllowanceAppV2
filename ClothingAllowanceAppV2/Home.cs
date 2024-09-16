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
        AllowanceManager am;
        public Home(AllowanceManager am)
        {
            this.am = am;
            InitializeComponent();

          

        }

        //Takes user to the selection form 
        private void continuebtn_Click(object sender, EventArgs e)
        {              
            this.Hide();
            var myForm = new Selection(am);
            myForm.Show();
        }

        //Takes user to the stats form 
        private void statsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myform = new Stats(am);
            myform.Show();
              
        }

        //Closes program
        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
