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
    public partial class Stats : Form
    {
        AllowanceManager am;
        public Stats(AllowanceManager am)
        {
            this.am = am;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myform = new Home(am);
            myform.Show();
        }

        private void statsSummaryrtbx_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
