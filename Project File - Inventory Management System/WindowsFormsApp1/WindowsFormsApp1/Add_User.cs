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
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Add_User_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperPanelDashboard Sp = new SuperPanelDashboard();
            Sp.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");

            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "insert into USERADMIN values ('" + name.Text + "','" + password.Text + "'," + cnic.Text + "," + phone.Text + ",'" + email.Text + "'," + id.Text + ")";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_User UP = new Update_User();
            UP.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_User Du = new Delete_User();
            Du.Show();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
