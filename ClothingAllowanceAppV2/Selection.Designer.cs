
namespace ClothingAllowanceAppV2
{
    partial class Selection
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
            this.title2lbl = new System.Windows.Forms.Label();
            this.namecbx = new System.Windows.Forms.ComboBox();
            this.nextbtn = new RoundButton();
            this.backbtn = new RoundButton();
            this.newholderbtn = new RoundButton();
            this.SuspendLayout();
            // 
            // title2lbl
            // 
            this.title2lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title2lbl.AutoSize = true;
            this.title2lbl.Font = new System.Drawing.Font("HYGothic-Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title2lbl.Location = new System.Drawing.Point(209, 9);
            this.title2lbl.Name = "title2lbl";
            this.title2lbl.Size = new System.Drawing.Size(382, 32);
            this.title2lbl.TabIndex = 1;
            this.title2lbl.Text = "Please select an option";
            this.title2lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // namecbx
            // 
            this.namecbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.namecbx.AutoCompleteCustomSource.AddRange(new string[] {
            "Nikau",
            "Hana",
            "Tia"});
            this.namecbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(221)))));
            this.namecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.namecbx.FormattingEnabled = true;
            this.namecbx.Items.AddRange(new object[] {
            "Nikau",
            "Hana",
            "Tia"});
            this.namecbx.Location = new System.Drawing.Point(332, 136);
            this.namecbx.Name = "namecbx";
            this.namecbx.Size = new System.Drawing.Size(127, 21);
            this.namecbx.TabIndex = 4;
            this.namecbx.SelectedIndexChanged += new System.EventHandler(this.namecbx_SelectedIndexChanged);
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbtn.ForeColor = System.Drawing.Color.Black;
            this.nextbtn.Location = new System.Drawing.Point(661, 390);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.nextbtn.Size = new System.Drawing.Size(127, 48);
            this.nextbtn.TabIndex = 3;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = false;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.ForeColor = System.Drawing.Color.Black;
            this.backbtn.Location = new System.Drawing.Point(12, 390);
            this.backbtn.Name = "backbtn";
            this.backbtn.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.backbtn.Size = new System.Drawing.Size(127, 48);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // newholderbtn
            // 
            this.newholderbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newholderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(221)))));
            this.newholderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newholderbtn.ForeColor = System.Drawing.Color.Black;
            this.newholderbtn.Location = new System.Drawing.Point(332, 178);
            this.newholderbtn.Name = "newholderbtn";
            this.newholderbtn.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.newholderbtn.Size = new System.Drawing.Size(127, 48);
            this.newholderbtn.TabIndex = 5;
            this.newholderbtn.Text = "New Allowance Holder";
            this.newholderbtn.UseVisualStyleBackColor = false;
            this.newholderbtn.Click += new System.EventHandler(this.newholderbtn_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newholderbtn);
            this.Controls.Add(this.namecbx);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.title2lbl);
            this.Name = "Selection";
            this.Text = "Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title2lbl;
        private RoundButton backbtn;    
        private RoundButton nextbtn;
        private RoundButton newholderbtn;
        private System.Windows.Forms.ComboBox namecbx;
      
    }
}