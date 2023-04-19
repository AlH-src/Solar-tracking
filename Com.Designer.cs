namespace ReadSerialDataUsingThreading
{
    partial class Com
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
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.STOP_btn = new System.Windows.Forms.Button();
            this.default_btn = new System.Windows.Forms.Button();
            this.podnesi_btn = new System.Windows.Forms.Button();
            this.pozicija_rotora1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.brzina_txtb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Stanjerotora1_txtb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.sys_time_lbl = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.fan_lbl = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Servo_log_lista = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Automatika_chb = new System.Windows.Forms.CheckBox();
            this.Poluautomatika_chb = new System.Windows.Forms.CheckBox();
            this.gbConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
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
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Monitor";
            // 
            // Btnsend
            // 
            this.Btnsend.Location = new System.Drawing.Point(288, 17);
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
            this.txtreaddata.Size = new System.Drawing.Size(357, 166);
            this.txtreaddata.TabIndex = 1;
            this.txtreaddata.Text = "";
            // 
            // txtwritedata
            // 
            this.txtwritedata.Location = new System.Drawing.Point(6, 19);
            this.txtwritedata.Name = "txtwritedata";
            this.txtwritedata.Size = new System.Drawing.Size(276, 20);
            this.txtwritedata.TabIndex = 0;
            // 
            // Btnconnect
            // 
            this.Btnconnect.Location = new System.Drawing.Point(71, 206);
            this.Btnconnect.Name = "Btnconnect";
            this.Btnconnect.Size = new System.Drawing.Size(75, 23);
            this.Btnconnect.TabIndex = 2;
            this.Btnconnect.Text = "Connect";
            this.Btnconnect.UseVisualStyleBackColor = true;
            this.Btnconnect.Click += new System.EventHandler(this.Btnconnect_Click);
            // 
            // Btndisconnect
            // 
            this.Btndisconnect.Location = new System.Drawing.Point(152, 206);
            this.Btndisconnect.Name = "Btndisconnect";
            this.Btndisconnect.Size = new System.Drawing.Size(75, 23);
            this.Btndisconnect.TabIndex = 12;
            this.Btndisconnect.Text = "Disconnect";
            this.Btndisconnect.UseVisualStyleBackColor = true;
            this.Btndisconnect.Click += new System.EventHandler(this.Btndisconnect_Click);
            // 
            // Btnedit
            // 
            this.Btnedit.Location = new System.Drawing.Point(71, 177);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(75, 23);
            this.Btnedit.TabIndex = 13;
            this.Btnedit.Text = "Edit";
            this.Btnedit.UseVisualStyleBackColor = true;
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Location = new System.Drawing.Point(152, 177);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 14;
            this.Btnsave.Text = "Save";
            this.Btnsave.UseVisualStyleBackColor = true;
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "LOG lista";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(2, 35);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(163, 282);
            this.textBox8.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 620);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(508, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Pritiskom na STOP obustavlja se sva mehanika, rotor 1 i rotor 2. A zatim se isklj" +
    "učuje napajanje do baterije ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // STOP_btn
            // 
            this.STOP_btn.Location = new System.Drawing.Point(526, 603);
            this.STOP_btn.Name = "STOP_btn";
            this.STOP_btn.Size = new System.Drawing.Size(156, 47);
            this.STOP_btn.TabIndex = 44;
            this.STOP_btn.Text = "STOP";
            this.STOP_btn.UseVisualStyleBackColor = true;
            this.STOP_btn.Click += new System.EventHandler(this.STOP_btn_Click);
            // 
            // default_btn
            // 
            this.default_btn.Location = new System.Drawing.Point(362, 230);
            this.default_btn.Name = "default_btn";
            this.default_btn.Size = new System.Drawing.Size(111, 32);
            this.default_btn.TabIndex = 43;
            this.default_btn.Text = "default";
            this.default_btn.UseVisualStyleBackColor = true;
            this.default_btn.Click += new System.EventHandler(this.default_btn_Click);
            // 
            // podnesi_btn
            // 
            this.podnesi_btn.Location = new System.Drawing.Point(479, 230);
            this.podnesi_btn.Name = "podnesi_btn";
            this.podnesi_btn.Size = new System.Drawing.Size(111, 32);
            this.podnesi_btn.TabIndex = 42;
            this.podnesi_btn.Text = "Apply";
            this.podnesi_btn.UseVisualStyleBackColor = true;
            this.podnesi_btn.Click += new System.EventHandler(this.podnesi_btn_Click);
            // 
            // pozicija_rotora1
            // 
            this.pozicija_rotora1.Location = new System.Drawing.Point(102, 83);
            this.pozicija_rotora1.Name = "pozicija_rotora1";
            this.pozicija_rotora1.Size = new System.Drawing.Size(100, 20);
            this.pozicija_rotora1.TabIndex = 39;
            this.pozicija_rotora1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Vrijednost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Pozicija";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Lokacija";
            // 
            // brzina_txtb
            // 
            this.brzina_txtb.Location = new System.Drawing.Point(91, 66);
            this.brzina_txtb.Name = "brzina_txtb";
            this.brzina_txtb.Size = new System.Drawing.Size(100, 20);
            this.brzina_txtb.TabIndex = 27;
            this.brzina_txtb.Text = "1\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Pozicija rotora 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Brzina";
            // 
            // Stanjerotora1_txtb
            // 
            this.Stanjerotora1_txtb.Location = new System.Drawing.Point(91, 100);
            this.Stanjerotora1_txtb.Name = "Stanjerotora1_txtb";
            this.Stanjerotora1_txtb.Size = new System.Drawing.Size(100, 20);
            this.Stanjerotora1_txtb.TabIndex = 48;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Automatika_chb);
            this.groupBox2.Controls.Add(this.Stanjerotora1_txtb);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.brzina_txtb);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(184, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 194);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automatika";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.Poluautomatika_chb);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.pozicija_rotora1);
            this.groupBox3.Location = new System.Drawing.Point(401, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 194);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Poluautomatika";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Pomak broja koraka motora";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(14, 116);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(36, 13);
            this.label40.TabIndex = 50;
            this.label40.Text = "Brzina";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "1\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.default_btn);
            this.groupBox4.Controls.Add(this.podnesi_btn);
            this.groupBox4.Location = new System.Drawing.Point(10, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(602, 326);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Postavljanje upravljanja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Gradačac";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Fiksna";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(151, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Sistemsko vrijeme";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.sys_time_lbl);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(618, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(521, 173);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Programski zadane vrijednosti";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(84, 150);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(37, 13);
            this.label39.TabIndex = 63;
            this.label39.Text = "Status";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(327, 127);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(15, 13);
            this.label38.TabIndex = 62;
            this.label38.Text = "%";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(327, 100);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(14, 13);
            this.label37.TabIndex = 61;
            this.label37.Text = "C";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(261, 127);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(60, 13);
            this.label36.TabIndex = 60;
            this.label36.Text = "Vlaga_load";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(151, 127);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 13);
            this.label32.TabIndex = 59;
            this.label32.Text = "Vlaga";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(261, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 54;
            this.label24.Text = "UTC_load";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Longitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Time zone UTC";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(261, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 54;
            this.label27.Text = "Temp_load";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(151, 100);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 13);
            this.label26.TabIndex = 54;
            this.label26.Text = "Temperatura";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(261, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "label25";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // sys_time_lbl
            // 
            this.sys_time_lbl.AutoSize = true;
            this.sys_time_lbl.Location = new System.Drawing.Point(261, 27);
            this.sys_time_lbl.Name = "sys_time_lbl";
            this.sys_time_lbl.Size = new System.Drawing.Size(47, 13);
            this.sys_time_lbl.TabIndex = 57;
            this.sys_time_lbl.Text = "sys_time";
            this.sys_time_lbl.Click += new System.EventHandler(this.sys_time_lbl_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(57, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "18.4276";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(57, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 55;
            this.label22.Text = "44.8785";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(151, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "Programsko vrijeme";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Latitude";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 43;
            this.button1.Text = "default";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 32);
            this.button2.TabIndex = 42;
            this.button2.Text = "Podnesi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(627, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Fan status";
            // 
            // fan_lbl
            // 
            this.fan_lbl.AutoSize = true;
            this.fan_lbl.Location = new System.Drawing.Point(702, 162);
            this.fan_lbl.Name = "fan_lbl";
            this.fan_lbl.Size = new System.Drawing.Size(0, 13);
            this.fan_lbl.TabIndex = 53;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 13);
            this.label28.TabIndex = 54;
            this.label28.Text = "Trenutne pozicije";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 61);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 13);
            this.label29.TabIndex = 55;
            this.label29.Text = "Azimuth";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 82);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 13);
            this.label30.TabIndex = 56;
            this.label30.Text = "Elavacija";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 110);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 13);
            this.label31.TabIndex = 57;
            this.label31.Text = "Pozicija serva";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Location = new System.Drawing.Point(618, 191);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(242, 142);
            this.groupBox6.TabIndex = 59;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "promjenjive vrijednosti";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(118, 110);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(74, 13);
            this.label35.TabIndex = 61;
            this.label35.Text = "Value_loading";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(118, 82);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(74, 13);
            this.label34.TabIndex = 60;
            this.label34.Text = "Value_loading";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(118, 63);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(73, 13);
            this.label33.TabIndex = 59;
            this.label33.Text = "value_loading";
            this.label33.Click += new System.EventHandler(this.label33_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 32);
            this.button3.TabIndex = 43;
            this.button3.Text = "default";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 32);
            this.button4.TabIndex = 42;
            this.button4.Text = "Podnesi";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Servo_log_lista);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Location = new System.Drawing.Point(618, 342);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(242, 238);
            this.groupBox7.TabIndex = 62;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Servo LOG";
            // 
            // Servo_log_lista
            // 
            this.Servo_log_lista.FormattingEnabled = true;
            this.Servo_log_lista.Location = new System.Drawing.Point(9, 19);
            this.Servo_log_lista.Name = "Servo_log_lista";
            this.Servo_log_lista.Size = new System.Drawing.Size(209, 212);
            this.Servo_log_lista.TabIndex = 44;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(362, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 32);
            this.button5.TabIndex = 43;
            this.button5.Text = "default";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(479, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 32);
            this.button6.TabIndex = 42;
            this.button6.Text = "Podnesi";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(866, 199);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(116, 40);
            this.button11.TabIndex = 63;
            this.button11.Text = "Exit";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Automatika_chb
            // 
            this.Automatika_chb.AutoSize = true;
            this.Automatika_chb.Location = new System.Drawing.Point(91, 43);
            this.Automatika_chb.Name = "Automatika_chb";
            this.Automatika_chb.Size = new System.Drawing.Size(79, 17);
            this.Automatika_chb.TabIndex = 42;
            this.Automatika_chb.Text = "Automatika";
            this.Automatika_chb.UseVisualStyleBackColor = true;
            // 
            // Poluautomatika_chb
            // 
            this.Poluautomatika_chb.AutoSize = true;
            this.Poluautomatika_chb.Location = new System.Drawing.Point(104, 43);
            this.Poluautomatika_chb.Name = "Poluautomatika_chb";
            this.Poluautomatika_chb.Size = new System.Drawing.Size(99, 17);
            this.Poluautomatika_chb.TabIndex = 35;
            this.Poluautomatika_chb.Text = "Poluautomatika";
            this.Poluautomatika_chb.UseVisualStyleBackColor = true;
            // 
            // Com
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 662);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.fan_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.STOP_btn);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btnedit);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.Btndisconnect);
            this.Controls.Add(this.Btnconnect);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Name = "Com";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button STOP_btn;
        private System.Windows.Forms.Button default_btn;
        private System.Windows.Forms.Button podnesi_btn;
        private System.Windows.Forms.TextBox pozicija_rotora1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox brzina_txtb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Stanjerotora1_txtb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label sys_time_lbl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label fan_lbl;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox Servo_log_lista;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.CheckBox Automatika_chb;
        private System.Windows.Forms.CheckBox Poluautomatika_chb;
    }
}

