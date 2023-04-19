namespace maturski_rad
{
    partial class Log_in_frm
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
            this.User_txtb = new System.Windows.Forms.TextBox();
            this.password_txtb = new System.Windows.Forms.TextBox();
            this.User_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Log_in_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // User_txtb
            // 
            this.User_txtb.Location = new System.Drawing.Point(294, 128);
            this.User_txtb.Name = "User_txtb";
            this.User_txtb.Size = new System.Drawing.Size(143, 20);
            this.User_txtb.TabIndex = 0;
            this.User_txtb.TextChanged += new System.EventHandler(this.User_txtb_TextChanged);
            // 
            // password_txtb
            // 
            this.password_txtb.Location = new System.Drawing.Point(294, 165);
            this.password_txtb.Name = "password_txtb";
            this.password_txtb.PasswordChar = '*';
            this.password_txtb.Size = new System.Drawing.Size(143, 20);
            this.password_txtb.TabIndex = 1;
            // 
            // User_lbl
            // 
            this.User_lbl.AutoSize = true;
            this.User_lbl.BackColor = System.Drawing.Color.Transparent;
            this.User_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_lbl.Location = new System.Drawing.Point(159, 128);
            this.User_lbl.Name = "User_lbl";
            this.User_lbl.Size = new System.Drawing.Size(49, 23);
            this.User_lbl.TabIndex = 2;
            this.User_lbl.Text = "User";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.Transparent;
            this.password_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(159, 161);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(90, 23);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::maturski_rad.Properties.Resources.rikur;
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Log_in_btn
            // 
            this.Log_in_btn.BackColor = System.Drawing.Color.Transparent;
            this.Log_in_btn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_in_btn.Location = new System.Drawing.Point(294, 229);
            this.Log_in_btn.Name = "Log_in_btn";
            this.Log_in_btn.Size = new System.Drawing.Size(75, 23);
            this.Log_in_btn.TabIndex = 6;
            this.Log_in_btn.Text = "Log in";
            this.Log_in_btn.UseVisualStyleBackColor = false;
            this.Log_in_btn.Click += new System.EventHandler(this.Log_in_btn_Click);
            // 
            // Log_in_frm
            // 
            this.AcceptButton = this.Log_in_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 413);
            this.Controls.Add(this.Log_in_btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.User_lbl);
            this.Controls.Add(this.password_txtb);
            this.Controls.Add(this.User_txtb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Log_in_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in ";
            this.Load += new System.EventHandler(this.Log_in_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox User_txtb;
        private System.Windows.Forms.TextBox password_txtb;
        private System.Windows.Forms.Label User_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Log_in_btn;
    }
}

