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
    public partial class Alert : Form
    {
        String connectionstring = ("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
        public Alert()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select Itemname, noofitems from itemrecord", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv7.DataSource = dtb1;
            }
            OracleConnection mycon = new OracleConnection("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
            String query = "select * from  itemrecord where NOOFITEMS < 200";
            OracleDataAdapter con = new OracleDataAdapter(query, mycon);
            DataTable dtb2 = new DataTable();
            con.Fill(dtb2);
            if (dtb2.Rows.Count > 0)
            {
                Alert1.Text = "OH NO!";
                Alert2.Text = "Your inventory is out of stock .-.";
            }
            else
            {
                Alert1.Text = "Don't worry!";
                Alert2.Text = "Your inventory is full '_' ";
            }
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select Itemname, noofitems from itemrecord where NOOFITEMS < 200", oraclecon);
                DataTable dtb3 = new DataTable();
                oracledp.Fill(dtb3);
                dgv8.DataSource = dtb3;
            }
        }

        private void dgv7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Alert1_Click(object sender, EventArgs e)
        {

        }

        private void Alert_Load(object sender, EventArgs e)
        {

        }

        private void dgv8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Item_Records IT = new Item_Records();
            IT.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperPanelDashboard Sp = new SuperPanelDashboard();
            Sp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard us = new UserDashboard("","");
            us.Show();
        }
    }
}
