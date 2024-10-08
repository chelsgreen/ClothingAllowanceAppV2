﻿using System;
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
            //populate combo box with allowance holder names
            foreach (var name in am.GetAllHolderNames())
            {
                allowancesummarycbx.Items.Add(name);
            }

            allowancesummarycbx.SelectedIndex = 0;
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

        private void allowancesummarycbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            statsSummaryrtbx.Text = am.GetAllowanceHolderSummary(allowancesummarycbx.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            am.SetYear(dateTimePicker1.Value.Year);

            // Get the currently selected allowance holder
            string selectedHolder = allowancesummarycbx.Text;

            // Update the summary for the selected allowance holder
            statsSummaryrtbx.Text = am.GetAllowanceHolderSummary(selectedHolder);
        }
    }
}

