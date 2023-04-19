using ReadSerialDataUsingThreading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maturski_rad
{
    public partial class Log_in_frm : Form
    {
        public Log_in_frm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Log_in_frm_Load(object sender, EventArgs e)
        {


        }

        private void User_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_in_btn_Click(object sender, EventArgs e)
        {
            User_txtb.MaxLength = 12;
            password_txtb.MaxLength = 12;
            
            try
            {
                if (User_txtb.Text == "Admin" && password_txtb.Text == "password")
                {

                    Com frm = new Com();
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Pogrešan password ili korisničko ime");
                    password_txtb.Clear();

                }
            }catch (InvalidExpressionException ex)
            {
                MessageBox.Show("User error" + ex.Message);
                password_txtb.Clear();
            };


        }
    }
}

