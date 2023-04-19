using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadSerialDataUsingThreading
{
    public partial class Mainfrm : Form
    {
        public Thread ReadSerialDataThread;
        public string readserialvalue;
        
       

        public Mainfrm(object contextInformation)
        {
            InitializeComponent();

            time_lbl.Text = Convert.ToString(DateTime.Now);
            lbl_system.Text = Convert.ToString(ServerProcessing.Complete);
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

        private void Btnsave_Click(object sender, EventArgs e) //za cuvanje postavki
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

        private void Btnconnect_Click(object sender, EventArgs e) // uspostavlja knekciju sa portom 
        {
            serialPortIn = txtportname.Text;
            serialPortIn.BaudRate = int.Parse(txtbaudrate.Text);
            serialPortIn.Parity = (Parity) Enum.Parse(typeof(Parity), txtparity.Text);
            serialPortIn.DataBits = int.Parse(txtdatabits.Text);
            serialPortIn.StopBits = (StopBits) Enum.Parse(typeof(StopBits), txtstopbits.Text);

            serialPortIn.Open(); // otvara port
            if (serialPortIn.IsOpen) 
            {
                ReadSerialData();
                Btnconnect.Enabled = false;
                Btnedit.Enabled = false;
                Btndisconnect.Enabled = true;
                Btnsend.Enabled = true;
            }
        }

        private void ReadSerialData() // cita podatke sa porta
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

        private void ReadSerial()
        {
            while (serialPortIn.IsOpen)
            {
                readserialvalue = serialPortIn.ReadExisting();
                ShowSerialData(readserialvalue);

                Thread.Sleep(1000);
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

        private void Btnsend_Click(object sender, EventArgs e) // Za slanje podataka mozemo iskoristiti ovaj način pisanja za sljanja novih komandi u Arduino na osnovu potrebe tj programa
        {
            if (serialPortIn.IsOpen)
            {
                serialPortIn.WriteLine(txtwritedata.Text);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
