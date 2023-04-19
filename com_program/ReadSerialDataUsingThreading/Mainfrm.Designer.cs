namespace ReadSerialDataUsingThreading
{
    partial class Mainfrm
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
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstopbits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdatabits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtparity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbaudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtportname = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btnsend = new System.Windows.Forms.Button();
            this.txtreaddata = new System.Windows.Forms.RichTextBox();
            this.txtwritedata = new System.Windows.Forms.TextBox();
            this.Btnconnect = new System.Windows.Forms.Button();
            this.Btndisconnect = new System.Windows.Forms.Button();
            this.Btnedit = new System.Windows.Forms.Button();
            this.Btnsave = new System.Windows.Forms.Button();
            this.serialPortIn = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_system = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.gbConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.label5);
            this.gbConnection.Controls.Add(this.txtstopbits);
            this.gbConnection.Controls.Add(this.label4);
            this.gbConnection.Controls.Add(this.txtdatabits);
            this.gbConnection.Controls.Add(this.label3);
            this.gbConnection.Controls.Add(this.txtparity);
            this.gbConnection.Controls.Add(this.label2);
            this.gbConnection.Controls.Add(this.txtbaudrate);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Controls.Add(this.txtportname);
            this.gbConnection.Location = new System.Drawing.Point(24, 21);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(215, 159);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stop Bits";
            // 
            // txtstopbits
            // 
            this.txtstopbits.FormattingEnabled = true;
            this.txtstopbits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.txtstopbits.Location = new System.Drawing.Point(78, 127);
            this.txtstopbits.Name = "txtstopbits";
            this.txtstopbits.Size = new System.Drawing.Size(131, 21);
            this.txtstopbits.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Bits";
            // 
            // txtdatabits
            // 
            this.txtdatabits.FormattingEnabled = true;
            this.txtdatabits.Items.AddRange(new object[] {
            "8",
            "7"});
            this.txtdatabits.Location = new System.Drawing.Point(78, 100);
            this.txtdatabits.Name = "txtdatabits";
            this.txtdatabits.Size = new System.Drawing.Size(131, 21);
            this.txtdatabits.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parity";
            // 
            // txtparity
            // 
            this.txtparity.FormattingEnabled = true;
            this.txtparity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.txtparity.Location = new System.Drawing.Point(78, 73);
            this.txtparity.Name = "txtparity";
            this.txtparity.Size = new System.Drawing.Size(131, 21);
            this.txtparity.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // txtbaudrate
            // 
            this.txtbaudrate.FormattingEnabled = true;
            this.txtbaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.txtbaudrate.Location = new System.Drawing.Point(78, 46);
            this.txtbaudrate.Name = "txtbaudrate";
            this.txtbaudrate.Size = new System.Drawing.Size(131, 21);
            this.txtbaudrate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Name";
            // 
            // txtportname
            // 
            this.txtportname.FormattingEnabled = true;
            this.txtportname.Location = new System.Drawing.Point(78, 19);
            this.txtportname.Name = "txtportname";
            this.txtportname.Size = new System.Drawing.Size(131, 21);
            this.txtportname.TabIndex = 3;
            this.txtportname.DropDown += new System.EventHandler(this.txtportname_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btnsend);
            this.groupBox1.Controls.Add(this.txtreaddata);
            this.groupBox1.Controls.Add(this.txtwritedata);
            this.groupBox1.Location = new System.Drawing.Point(245, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Monitor";
            // 
            // Btnsend
            // 
            this.Btnsend.Location = new System.Drawing.Point(414, 19);
            this.Btnsend.Name = "Btnsend";
            this.Btnsend.Size = new System.Drawing.Size(75, 23);
            this.Btnsend.TabIndex = 15;
            this.Btnsend.Text = "Send";
            this.Btnsend.UseVisualStyleBackColor = true;
            this.Btnsend.Click += new System.EventHandler(this.Btnsend_Click);
            // 
            // txtreaddata
            // 
            this.txtreaddata.Location = new System.Drawing.Point(6, 45);
            this.txtreaddata.Name = "txtreaddata";
            this.txtreaddata.Size = new System.Drawing.Size(483, 166);
            this.txtreaddata.TabIndex = 1;
            this.txtreaddata.Text = "";
            // 
            // txtwritedata
            // 
            this.txtwritedata.Location = new System.Drawing.Point(6, 19);
            this.txtwritedata.Name = "txtwritedata";
            this.txtwritedata.Size = new System.Drawing.Size(402, 20);
            this.txtwritedata.TabIndex = 0;
            // 
            // Btnconnect
            // 
            this.Btnconnect.Location = new System.Drawing.Point(83, 215);
            this.Btnconnect.Name = "Btnconnect";
            this.Btnconnect.Size = new System.Drawing.Size(75, 23);
            this.Btnconnect.TabIndex = 2;
            this.Btnconnect.Text = "Connect";
            this.Btnconnect.UseVisualStyleBackColor = true;
            this.Btnconnect.Click += new System.EventHandler(this.Btnconnect_Click);
            // 
            // Btndisconnect
            // 
            this.Btndisconnect.Location = new System.Drawing.Point(164, 215);
            this.Btndisconnect.Name = "Btndisconnect";
            this.Btndisconnect.Size = new System.Drawing.Size(75, 23);
            this.Btndisconnect.TabIndex = 12;
            this.Btndisconnect.Text = "Disconnect";
            this.Btndisconnect.UseVisualStyleBackColor = true;
            this.Btndisconnect.Click += new System.EventHandler(this.Btndisconnect_Click);
            // 
            // Btnedit
            // 
            this.Btnedit.Location = new System.Drawing.Point(83, 186);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(75, 23);
            this.Btnedit.TabIndex = 13;
            this.Btnedit.Text = "Edit";
            this.Btnedit.UseVisualStyleBackColor = true;
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Location = new System.Drawing.Point(164, 186);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 14;
            this.Btnsave.Text = "Save";
            this.Btnsave.UseVisualStyleBackColor = true;
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Serial Port Com. V1 build 1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_system, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.time_lbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 79);
            this.tableLayoutPanel1.TabIndex = 19;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbl_system
            // 
            this.lbl_system.AutoSize = true;
            this.lbl_system.Location = new System.Drawing.Point(3, 38);
            this.lbl_system.Name = "lbl_system";
            this.lbl_system.Size = new System.Drawing.Size(0, 13);
            this.lbl_system.TabIndex = 20;
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(3, 19);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(0, 13);
            this.time_lbl.TabIndex = 20;
            this.time_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(786, 382);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btnedit);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.Btndisconnect);
            this.Controls.Add(this.Btnconnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serijski monitor. V1 build 1";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtportname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtstopbits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtdatabits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtparity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtbaudrate;
        private System.Windows.Forms.Button Btnsave;
        private System.Windows.Forms.Button Btnedit;
        private System.Windows.Forms.Button Btndisconnect;
        private System.Windows.Forms.Button Btnconnect;
        private System.Windows.Forms.Button Btnsend;
        private System.Windows.Forms.RichTextBox txtreaddata;
        private System.Windows.Forms.TextBox txtwritedata;
        private System.IO.Ports.SerialPort serialPortIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_system;
        private System.Windows.Forms.Label time_lbl;
    }
}

