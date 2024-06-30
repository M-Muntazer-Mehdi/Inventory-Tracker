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
    public partial class Edit_Societies : Form
    {
        public Edit_Societies()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard us = new UserDashboard("", "");
            us.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Society_records sr = new Society_records();
            sr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");

            con.Open();

            OracleCommand cmd = new OracleCommand();
            //cmd.CommandText = "INSERT INTO societies VALUES (" + societyname.Text + ", " + mentor.Text + ", " + Head.Text + "," + Members.Text + "," + Room.Text + "," + Societyid + ",)";
            // cmd.CommandText = "INSERT INTO societies VALUES ('" + societyname.Text + "', '" + mentor.Text + "', '" + Head.Text + "'," + Members.Text + "," + Room.Text + "," + Societyid + ")";
            //cmd.CommandText = "INSERT INTO societies VALUES ('" + societyname.Text +"', '" + mentor.Text + "', '" + Head.Text + "'," + Members.Text + "," + Room.Text + "," + Societyid + ",)";
            cmd.CommandText = "INSERT INTO societies VALUES ('" + societyname.Text + "', '" + mentor.Text + "', '" + Head.Text + "'," + Members.Text + "," + Room.Text + "," + Societyid + ")";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully");
        }
    }
}
