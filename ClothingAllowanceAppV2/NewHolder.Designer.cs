
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
            this.continuebtn4 = new RoundButton();
            this.title5lbl = new System.Windows.Forms.Label();
            this.newNametbx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
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
            // newNametbx
            // 
            this.newNametbx.Location = new System.Drawing.Point(305, 112);
            this.newNametbx.Name = "newNametbx";
            this.newNametbx.Size = new System.Drawing.Size(197, 45);
            this.newNametbx.TabIndex = 2;
            this.newNametbx.Text = "";
            this.newNametbx.TextChanged += new System.EventHandler(this.newNametbx_TextChanged);
            // 
            // NewHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newNametbx);
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
        private System.Windows.Forms.RichTextBox newNametbx;
    }
}
