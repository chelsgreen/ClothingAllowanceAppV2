
namespace ClothingAllowanceAppV2
{
    partial class Deduction
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
            this.deductionnud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.continuebtn3 = new RoundButton();
            this.exitbtn3 = new RoundButton();
            this.Summaryrtbx = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deductionnud)).BeginInit();
            this.SuspendLayout();
            // 
            // deductionnud
            // 
            this.deductionnud.Location = new System.Drawing.Point(347, 308);
            this.deductionnud.Name = "deductionnud";
            this.deductionnud.Size = new System.Drawing.Size(120, 20);
            this.deductionnud.TabIndex = 1;
            this.deductionnud.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HYGothic-Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Allowance Deduction";
            // 
            // continuebtn3
            // 
            this.continuebtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.continuebtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continuebtn3.ForeColor = System.Drawing.Color.Black;
            this.continuebtn3.Location = new System.Drawing.Point(661, 390);
            this.continuebtn3.Name = "continuebtn3";
            this.continuebtn3.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.continuebtn3.Size = new System.Drawing.Size(127, 48);
            this.continuebtn3.TabIndex = 3;
            this.continuebtn3.Text = "Continue";
            this.continuebtn3.UseVisualStyleBackColor = false;
            this.continuebtn3.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbtn3
            // 
            this.exitbtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.exitbtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn3.ForeColor = System.Drawing.Color.Black;
            this.exitbtn3.Location = new System.Drawing.Point(12, 390);
            this.exitbtn3.Name = "exitbtn3";
            this.exitbtn3.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.exitbtn3.Size = new System.Drawing.Size(127, 48);
            this.exitbtn3.TabIndex = 4;
            this.exitbtn3.Text = "Exit";
            this.exitbtn3.UseVisualStyleBackColor = false;
            this.exitbtn3.Click += new System.EventHandler(this.exitbtn3_Click);
            // 
            // Summaryrtbx
            // 
            this.Summaryrtbx.Location = new System.Drawing.Point(260, 68);
            this.Summaryrtbx.Name = "Summaryrtbx";
            this.Summaryrtbx.Size = new System.Drawing.Size(293, 214);
            this.Summaryrtbx.TabIndex = 5;
            this.Summaryrtbx.Text = "                                         Summary\n";
            this.Summaryrtbx.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Deduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Summaryrtbx);
            this.Controls.Add(this.exitbtn3);
            this.Controls.Add(this.continuebtn3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deductionnud);
            this.Name = "Deduction";
            this.Text = "Deduction";
            ((System.ComponentModel.ISupportInitialize)(this.deductionnud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown deductionnud;
        private System.Windows.Forms.Label label1;      
        private RoundButton continuebtn3;
        private RoundButton exitbtn3;
        private System.Windows.Forms.RichTextBox Summaryrtbx;
    }
}