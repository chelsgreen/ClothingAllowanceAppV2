
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
            this.components = new System.ComponentModel.Container();
            this.titlelbl = new System.Windows.Forms.Label();
            this.exitbtn = new RoundButton();
            this.statsbtn = new RoundButton();
            this.continuebtn = new RoundButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("HYGothic-Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titlelbl.Location = new System.Drawing.Point(212, 9);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(386, 32);
            this.titlelbl.TabIndex = 4;
            this.titlelbl.Text = "Clothing Allowance App";
            this.titlelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitbtn.AutoSize = true;
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("HYGothic-Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exitbtn.ForeColor = System.Drawing.Color.Black;
            this.exitbtn.Location = new System.Drawing.Point(341, 258);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.exitbtn.Size = new System.Drawing.Size(126, 48);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // statsbtn
            // 
            this.statsbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statsbtn.AutoSize = true;
            this.statsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(221)))));
            this.statsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsbtn.Font = new System.Drawing.Font("HYGothic-Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statsbtn.ForeColor = System.Drawing.Color.Black;
            this.statsbtn.Location = new System.Drawing.Point(340, 191);
            this.statsbtn.Name = "statsbtn";
            this.statsbtn.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.statsbtn.Size = new System.Drawing.Size(127, 48);
            this.statsbtn.TabIndex = 2;
            this.statsbtn.Text = "Stats";
            this.statsbtn.UseVisualStyleBackColor = false;
            this.statsbtn.Click += new System.EventHandler(this.statsbtn_Click);
            // 
            // continuebtn
            // 
            this.continuebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.continuebtn.AutoSize = true;
            this.continuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.continuebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continuebtn.Font = new System.Drawing.Font("HYGothic-Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.continuebtn.ForeColor = System.Drawing.Color.Black;
            this.continuebtn.Location = new System.Drawing.Point(338, 124);
            this.continuebtn.Name = "continuebtn";
            this.continuebtn.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.continuebtn.Size = new System.Drawing.Size(127, 48);
            this.continuebtn.TabIndex = 1;
            this.continuebtn.Text = "Continue";
            this.continuebtn.UseVisualStyleBackColor = false;
            this.continuebtn.Click += new System.EventHandler(this.continuebtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClothingAllowanceAppV2.Properties.Resources.homepage;
            this.pictureBox1.Location = new System.Drawing.Point(523, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 252);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClothingAllowanceAppV2.Properties.Resources.homepage;
            this.pictureBox2.Location = new System.Drawing.Point(30, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 251);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.statsbtn);
            this.Controls.Add(this.continuebtn);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //buttons and labels 
        private RoundButton continuebtn;
        private RoundButton statsbtn;
        private RoundButton exitbtn;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}