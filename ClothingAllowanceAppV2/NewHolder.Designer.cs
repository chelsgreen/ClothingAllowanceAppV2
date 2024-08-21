
namespace ClothingAllowanceAppV2
{
    partial class NewHolder
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
            this.title5lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.firstnamelbl = new System.Windows.Forms.Label();
            this.continuebtn4 = new RoundButton();
            this.exitbtn = new RoundButton();
            this.SuspendLayout();
            // 
            // title5lbl
            // 
            this.title5lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title5lbl.AutoSize = true;
            this.title5lbl.Font = new System.Drawing.Font("HYGothic-Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title5lbl.Location = new System.Drawing.Point(254, 9);
            this.title5lbl.Name = "title5lbl";
            this.title5lbl.Size = new System.Drawing.Size(306, 27);
            this.title5lbl.TabIndex = 1;
            this.title5lbl.Text = "New Allowance Holder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HYGothic-Medium", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(273, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter both first and last name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(302, 215);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(302, 157);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.AutoSize = true;
            this.lastnamelbl.Font = new System.Drawing.Font("HYGothic-Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lastnamelbl.Location = new System.Drawing.Point(352, 199);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(76, 13);
            this.lastnamelbl.TabIndex = 6;
            this.lastnamelbl.Text = "Last Name";
            // 
            // firstnamelbl
            // 
            this.firstnamelbl.AutoSize = true;
            this.firstnamelbl.Font = new System.Drawing.Font("HYGothic-Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.firstnamelbl.Location = new System.Drawing.Point(352, 141);
            this.firstnamelbl.Name = "firstnamelbl";
            this.firstnamelbl.Size = new System.Drawing.Size(75, 13);
            this.firstnamelbl.TabIndex = 7;
            this.firstnamelbl.Text = "First Name";
            // 
            // continuebtn4
            // 
            this.continuebtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.continuebtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continuebtn4.ForeColor = System.Drawing.Color.Black;
            this.continuebtn4.Location = new System.Drawing.Point(658, 392);
            this.continuebtn4.Name = "continuebtn4";
            this.continuebtn4.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.continuebtn4.Size = new System.Drawing.Size(127, 48);
            this.continuebtn4.TabIndex = 0;
            this.continuebtn4.Text = "Continue";
            this.continuebtn4.UseVisualStyleBackColor = false;
            this.continuebtn4.Click += new System.EventHandler(this.continuebtn4_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.ForeColor = System.Drawing.Color.Black;
            this.exitbtn.Location = new System.Drawing.Point(12, 390);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.exitbtn.Size = new System.Drawing.Size(127, 48);
            this.exitbtn.TabIndex = 8;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // NewHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.firstnamelbl);
            this.Controls.Add(this.lastnamelbl);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title5lbl);
            this.Controls.Add(this.continuebtn4);
            this.Name = "NewHolder";
            this.Text = "NewHolder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton continuebtn4;
        private System.Windows.Forms.Label title5lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lastnamelbl;
        private System.Windows.Forms.Label firstnamelbl;
        private RoundButton exitbtn;
    }
}
