using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class ResetPassword : Form
    {
        string username = ForgetPassword.to;
        public ResetPassword(string meg)
        {
            InitializeComponent();

            code.Text = meg;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (password.Text == cpassword.Text)
            {
                String mycon = "Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214";
                String updatedata = "Update USERADMIN set password1='" + password.Text + "' where phone = " + code.Text;
                OracleConnection con = new OracleConnection(mycon);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                this.Hide();
                User Us = new User();
                Us.Show();
            }
            else
            {
                code.Text = "Password not match!";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword Us = new ForgetPassword();
            Us.Show();
        }

        private void code_Click(object sender, EventArgs e)
        {

        }
    }
}
