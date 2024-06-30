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
    public partial class Add_records : Form
    {
        String connectionstring = ("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
        public Add_records()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from itemrecord", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv7.DataSource = dtb1;
            }
        }

        private void dgv7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard us = new UserDashboard("","");
            us.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from itemrecord", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv7.DataSource = dtb1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");

            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "insert into itemrecord values ('" + name.Text + "'," + noofitems.Text + "," + price.Text + "," + Code.Text + ")";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully");
        }
    }
}
