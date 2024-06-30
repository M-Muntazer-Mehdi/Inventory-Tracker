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
    public partial class Delete_Records : Form
    {
        String connectionstring = ("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
        public Delete_Records()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from itemrecord", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv4.DataSource = dtb1;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard us = new UserDashboard("","");
            us.Hide();
        }

        private void dgv4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214";
            String myquery = "Select * from itemrecord where CODE =" + code.Text;
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
                name.Text = (ds.Tables[0].Rows[0]["Noofitems"].ToString()).Trim();
                noofitem.Text = (ds.Tables[0].Rows[0]["itemname"].ToString()).Trim();
            }
            else
            {
                name.Text = "";
                noofitem.Text = "";

            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from itemrecord", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv4.DataSource = dtb1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214";
            String myquery = "Delete from itemrecord where code =" + code.Text;
            OracleConnection con = new OracleConnection(mycon);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
