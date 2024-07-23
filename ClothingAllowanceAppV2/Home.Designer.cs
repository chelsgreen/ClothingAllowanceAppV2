
namespace ClothingAllowanceAppV2
{
    partial class Home
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.continuebtn = new System.Windows.Forms.Button();
            this.statsbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("HYGothic-Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(206, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Clothing Allowance App";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // continuebtn
            // 
            this.continuebtn.Location = new System.Drawing.Point(340, 126);
            this.continuebtn.Name = "continuebtn";
            this.continuebtn.Size = new System.Drawing.Size(127, 48);
            this.continuebtn.TabIndex = 1;
            this.continuebtn.Text = "Continue";
            this.continuebtn.UseVisualStyleBackColor = true;
            this.continuebtn.Click += new System.EventHandler(this.continuebtn_Click);
            // 
            // statsbtn
            // 
            this.statsbtn.Location = new System.Drawing.Point(340, 191);
            this.statsbtn.Name = "statsbtn";
            this.statsbtn.Size = new System.Drawing.Size(127, 48);
            this.statsbtn.TabIndex = 2;
            this.statsbtn.Text = "Stats";
            this.statsbtn.UseVisualStyleBackColor = true;
            this.statsbtn.Click += new System.EventHandler(this.statsbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(340, 261);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(126, 48);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.statsbtn);
            this.Controls.Add(this.continuebtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button continuebtn;
        private System.Windows.Forms.Button statsbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}