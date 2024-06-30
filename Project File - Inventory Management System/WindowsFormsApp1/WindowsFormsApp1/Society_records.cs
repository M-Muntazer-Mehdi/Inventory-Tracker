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
    public partial class Society_records : Form
    {
        String connectionstring = ("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
        public Society_records()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from SOCIETIES", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv2.DataSource = dtb1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry! Only User can access to the system");
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            UserDashboard us = new UserDashboard("", "");
            us.Show();
        }
    }
}
