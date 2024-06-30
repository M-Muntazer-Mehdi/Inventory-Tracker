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
    public partial class Update_User : Form
    {
        public Update_User()
        {
            InitializeComponent();
        }

        private void Ente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperPanelDashboard Sp = new SuperPanelDashboard();
            Sp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_User AD = new Add_User();
            AD.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214";
            String myquery = "Select * from USERADMIN where ID =" + search.Text;
            OracleConnection con = new OracleConnection(mycon);
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Check.Text = "Particular ID Found Successfully";
                name.Text = (ds.Tables[0].Rows[0]["USERNAME1"].ToString()).Trim();
                password.Text = (ds.Tables[0].Rows[0]["PASSWORD1"].ToString()).Trim();
                email.Text = (ds.Tables[0].Rows[0]["EMAILID"].ToString()).Trim();
                cnic.Text = (ds.Tables[0].Rows[0]["CNIC"].ToString()).Trim();
                phone.Text = (ds.Tables[0].Rows[0]["PHONE"].ToString()).Trim();
            }
            else
            {
                Check.Text = "Particular ID Not Found - Search Again";
                name.Text = "";
                password.Text = "";
                email.Text = "";
                cnic.Text = "";
                phone.Text = "";

            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214";
            String updatedata = "Update USERADMIN set username1='" + name.Text + "', password1='" + password.Text + "', EMAILID='" + email.Text + "'" + ", phone = " + phone.Text + ", cnic= " + cnic.Text + " where ID=" + search.Text;
            OracleConnection con = new OracleConnection(mycon);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            check2.Text = "Data Has Been Updated";
            name.Text = "";
            password.Text = "";
            email.Text = "";
            cnic.Text = "";
            phone.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_User DU = new Delete_User();
            DU.Show();
        }

        private void Update_User_Load(object sender, EventArgs e)
        {

        }
    }
}
