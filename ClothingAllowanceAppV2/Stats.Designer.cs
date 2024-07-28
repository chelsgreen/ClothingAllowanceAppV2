
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
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbtn2);
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);

        }

        #endregion

        
        private RoundButton exitbtn2;
    }
}