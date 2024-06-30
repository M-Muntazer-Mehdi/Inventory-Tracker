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
    public partial class Update_Records : Form
    {
        String connectionstring = ("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
        public Update_Records()
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
            UserDashboard us = new UserDashboard("", "");
            us.Show();
        }

        private void dgv4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214";
            String myquery = "Select * from itemrecord where ID =" + code.Text;
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
                //Check.Text = "Particular ID Found Successfully";
                name.Text = (ds.Tables[0].Rows[0]["itemname"].ToString()).Trim();
                noofitens.Text = (ds.Tables[0].Rows[0]["noofitems"].ToString()).Trim();
                Price.Text = (ds.Tables[0].Rows[0]["price"].ToString()).Trim();
            }
            else
            {
                //Check.Text = "Particular ID Not Found - Search Again";
                name.Text = "";
                noofitens.Text = "";
                Price.Text = "";

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
            String updatedata = "Update itemrecord set itemname='" + name.Text + "', noofitems=" + noofitens.Text + ", price=" + Price.Text + " where CODE=" + code.Text;
            OracleConnection con = new OracleConnection(mycon);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            //check2.Text = "Data Has Been Updated";
            name.Text = "";
            noofitens.Text = "";
            Price.Text = "";
        }
    }
}
