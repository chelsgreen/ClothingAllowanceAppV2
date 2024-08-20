
namespace ClothingAllowanceAppV2
{
    partial class Stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitbtn2 = new RoundButton();
            this.statsSummaryrtbx = new System.Windows.Forms.RichTextBox();
            this.allowancesummarycbx = new System.Windows.Forms.ComboBox();
            this.title4lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitbtn2
            // 
            this.exitbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.exitbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn2.ForeColor = System.Drawing.Color.Black;
            this.exitbtn2.Location = new System.Drawing.Point(662, 390);
            this.exitbtn2.Name = "exitbtn2";
            this.exitbtn2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.exitbtn2.Size = new System.Drawing.Size(126, 48);
            this.exitbtn2.TabIndex = 0;
            this.exitbtn2.Text = "Exit";
            this.exitbtn2.UseVisualStyleBackColor = false;
            this.exitbtn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // statsSummaryrtbx
            // 
            this.statsSummaryrtbx.Location = new System.Drawing.Point(37, 110);
            this.statsSummaryrtbx.Name = "statsSummaryrtbx";
            this.statsSummaryrtbx.Size = new System.Drawing.Size(334, 244);
            this.statsSummaryrtbx.TabIndex = 1;
            this.statsSummaryrtbx.Text = "";
            this.statsSummaryrtbx.TextChanged += new System.EventHandler(this.statsSummaryrtbx_TextChanged);
            // 
            // allowancesummarycbx
            // 
            this.allowancesummarycbx.FormattingEnabled = true;
            this.allowancesummarycbx.Location = new System.Drawing.Point(37, 83);
            this.allowancesummarycbx.Name = "allowancesummarycbx";
            this.allowancesummarycbx.Size = new System.Drawing.Size(334, 21);
            this.allowancesummarycbx.TabIndex = 2;
            this.allowancesummarycbx.SelectedIndexChanged += new System.EventHandler(this.allowancesummarycbx_SelectedIndexChanged);
            // 
            // title4lbl
            // 
            this.title4lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title4lbl.Font = new System.Drawing.Font("HYGothic-Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title4lbl.Location = new System.Drawing.Point(31, 27);
            this.title4lbl.Name = "title4lbl";
            this.title4lbl.Size = new System.Drawing.Size(340, 60);
            this.title4lbl.TabIndex = 3;
            this.title4lbl.Text = "Allowance Summary";
            this.title4lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title4lbl);
            this.Controls.Add(this.allowancesummarycbx);
            this.Controls.Add(this.statsSummaryrtbx);
            this.Controls.Add(this.exitbtn2);
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);

        }

        #endregion

        
        private RoundButton exitbtn2;
        private System.Windows.Forms.RichTextBox statsSummaryrtbx;
        private System.Windows.Forms.ComboBox allowancesummarycbx;
        private System.Windows.Forms.Label title4lbl;
    }
}