using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace ReadSerialDataUsingThreading
{
    public partial class Com : Form
    {
        public Thread ReadSerialDataThread;
        public string readserialvalue;
        public float[] niz = new float[4];


        public Com()
        {
            InitializeComponent();
            label24.Text = Convert.ToString(System.TimeZoneInfo.Local);
            label25.Update();
            sys_time_lbl.Text = Convert.ToString(System.DateTime.Now);
            label25.Text = Convert.ToString(System.DateTime.Today);

        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            this.Text = @"Read Serial Data Using Thread";
            LoadConfigurationSetting();
            gbConnection.Enabled = false;
            Btnsave.Enabled = false;
            Btndisconnect.Enabled = false;
            Btnsend.Enabled = false;
           

        }

        private void LoadConfigurationSetting()
        {
            txtportname.Text = ConfigurationManager.AppSettings["comname"];
            txtbaudrate.Text = ConfigurationManager.AppSettings["combaudrate"];
            txtparity.Text = ConfigurationManager.AppSettings["comparity"];
            txtdatabits.Text = ConfigurationManager.AppSettings["comdatabits"];
            txtstopbits.Text = ConfigurationManager.AppSettings["comstopbits"];
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            gbConnection.Enabled = true;
            Btnsave.Enabled = true;
            Btnedit.Enabled = false;
            Btnconnect.Enabled = false;
        }

        private void txtportname_DropDown(object sender, EventArgs e)
        {
            txtportname.Items.Clear();
            string[] comports = SerialPort.GetPortNames();
            foreach (var comport in comports)
            {
                txtportname.Items.Add(comport);
            }
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("comname");
                config.AppSettings.Settings.Remove("combaudrate");
                config.AppSettings.Settings.Remove("comparity");
                config.AppSettings.Settings.Remove("comdatabits");
                config.AppSettings.Settings.Remove("comstopbits");

                config.AppSettings.Settings.Add("comname", txtportname.Text);
                config.AppSettings.Settings.Add("combaudrate", txtbaudrate.Text);
                config.AppSettings.Settings.Add("comparity", txtparity.Text);
                config.AppSettings.Settings.Add("comdatabits", txtdatabits.Text);
                config.AppSettings.Settings.Add("comstopbits", txtstopbits.Text);

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                gbConnection.Enabled = false;
                Btnedit.Enabled = true;
                Btnconnect.Enabled = true;
                Btnsave.Enabled = false;

            }
            catch (Exception exc)
            {
                MessageBox.Show(@"Saving Error. " + exc.Message);
            }
        }

        private void Btnconnect_Click(object sender, EventArgs e)
        {
            serialPortIn.PortName = txtportname.Text;
            serialPortIn.BaudRate = int.Parse(txtbaudrate.Text);
            serialPortIn.Parity = (Parity)Enum.Parse(typeof(Parity), txtparity.Text);
            serialPortIn.DataBits = int.Parse(txtdatabits.Text);
            serialPortIn.StopBits = (StopBits)Enum.Parse(typeof(StopBits), txtstopbits.Text);

            try
            {
                serialPortIn.Open();
                if (serialPortIn.IsOpen)
                {
                    ReadSerialData();
                    Btnconnect.Enabled = false;
                    Btnedit.Enabled = false;
                    Btndisconnect.Enabled = true;
                    Btnsend.Enabled = true;
                }
            }
            catch (Exception exc2)
            {
                MessageBox.Show("Error" + exc2.Message);
            }
        }

        private void ReadSerialData()
        {
            try
            {
                ReadSerialDataThread = new Thread(ReadSerial);
                ReadSerialDataThread.Start();

            }
            catch (Exception e)
            {
                MessageBox.Show(@"Read Serial thread. " + e.Message);
            }
        }

        // receives data from arduino that was upsent
        private void ReadSerial()
        {
            try
            {
                while (serialPortIn.IsOpen)
                {
                    readserialvalue = serialPortIn.ReadExisting();


                    //splits data from a string by "*" character 

                    string[] values = readserialvalue.Split('*');
                    foreach (string value in values)
                    {
                        
                        if (!string.IsNullOrEmpty(value))
                        {
                            ShowSerialData(value);
                            try
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    try
                                    {
                                        label33.Text = values[0];
                                        label34.Text = values[1];
                                        label35.Text = values[2];
                                        label27.Text = values[3];
                                        label36.Text = values[4];
                                        label39.Text = values[5];
                                    }
                                    catch (Exception exc)
                                    {
                                      MessageBox.Show(exc.Message);
                                    }
                                });
                            }
                            catch(Exception exc) 
                            {

                                MessageBox.Show(exc.Message);
                              
                            }


                        }
                        Thread.Sleep(3000);

                    }

                }
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }



        public delegate void ShowSerialDatadelegate(string r);

        private void ShowSerialData(string s)
        {
            if (txtreaddata.InvokeRequired)
            {
                ShowSerialDatadelegate SSDD = ShowSerialData;
                Invoke(SSDD, s);
            }
            else
            {
                txtreaddata.AppendText(Environment.NewLine + s);
                txtreaddata.ScrollToCaret();
            }



        }
       

        private void Btndisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPortIn.IsOpen)
                {
                    serialPortIn.Close();
                    Btnconnect.Enabled = true;
                    Btnedit.Enabled = true;
                    Btndisconnect.Enabled = false;
                    Btnsend.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Disconnect error. " + exception.Message);
            }
        }

        private void Btnsend_Click(object sender, EventArgs e)
        {
            if (serialPortIn.IsOpen)
            {
                serialPortIn.Write(txtwritedata.Text);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        
        private void sys_time_lbl_Click(object sender, EventArgs e)
        {
           
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void STOP_btn_Click(object sender, EventArgs e)
        {
            if (serialPortIn.IsOpen)
            {
                serialPortIn.WriteLine("001");
            }
        }

        private void default_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    brzina_txtb.Text = "1";
                    Stanjerotora1_txtb.Text = "Auto";
                    Automatika_chb.Checked = true;


                    if (serialPortIn.IsOpen)
                    {

                        serialPortIn.Write("002");
                    }


                    Servo_log_lista.Items.Add("Settings changed" + System.DateTime.Now);
                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void podnesi_btn_Click(object sender, EventArgs e)
        {
            string save = textBox1.Text;
            try
            {
                if (Poluautomatika_chb.Checked == true)
                {
                    if (pozicija_rotora1.Text != "0")
                    {


                        if (serialPortIn.IsOpen)
                        {
                            int key = 001;
                            serialPortIn.Write(key+pozicija_rotora1.Text);
                            Servo_log_lista.Items.Add("Sent(X03) value changed to "+pozicija_rotora1.Text);
                        }

                    }
                    if (textBox1.Text!=save)
                    {

                        // max speed 5
                        if (serialPortIn.IsOpen)
                        {
                            int key = 002;
                            serialPortIn.Write(key+textBox1.Text);
                            Servo_log_lista.Items.Add("Sent(X03) value changed to " + textBox1.Text);
                        }

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        

        private void label25_Click(object sender, EventArgs e)
        {
         
          

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label25.Text = Convert.ToString(System.DateTime.Today);
            sys_time_lbl.Text = DateTime.Now.ToString("hh:mm:ss");
            label25.Text = Convert.ToString(System.DateTime.Today);
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (serialPortIn.IsOpen)
            {
                TextBox key = new TextBox();
                key.Text = "114";
                serialPortIn.WriteLine(key.Text);
                Servo_log_lista.Items.Add("Fan turned on for 20 seconds ");
                serialPortIn.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (serialPortIn.IsOpen)
            {
                int key = 005;
                serialPortIn.WriteLine("005");
                Servo_log_lista.Items.Add("Fan turned off");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
