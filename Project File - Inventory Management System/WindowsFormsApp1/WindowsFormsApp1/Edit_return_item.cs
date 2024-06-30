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
    public partial class Edit_return_item : Form
    {
        String connectionstring = ("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
        public Edit_return_item()
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
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from SOCIETIES", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv8.DataSource = dtb1;
            }
        }

        private void dgv7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard us = new UserDashboard("", "");
            us.Show();
        }

        private void Edit_return_item_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");

            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "insert into returnitems values ('" + itemname.Text + "','" + societyname.Text + "'," + noof.Text + "," + Societycode.Text + "," + itemid.Text +")";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully");


            String mycon = "Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214";
            OracleConnection con1 = new OracleConnection(mycon);
            con1.Open();
            String updatedata = "Update ITEMRECORD set noofitems= noofitems + " + noof.Text + " where code=" + itemid.Text;
            OracleCommand cmd1 = new OracleCommand();
            cmd1.CommandText = updatedata;
            cmd1.Connection = con1;
            cmd1.ExecuteNonQuery();
            //check2.Text = "Data Has Been Updated";
            noof.Text = "";
            itemid.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return_item rt = new Return_item();
            rt.Show();
        }

        private void dgv8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
