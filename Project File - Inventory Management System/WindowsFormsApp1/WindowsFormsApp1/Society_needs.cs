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
    public partial class Society_needs : Form
    {
        String connectionstring = ("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
        public Society_needs()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("SELECT * FROM societies s INNER JOIN societiesneed sn ON sn.societyid = s.societyid INNER JOIN event e ON e.eventd=sn.eventID", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv7.DataSource = dtb1;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard us = new UserDashboard("","");
            us.Show();
        }

        private void dgv7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_needs sn = new Edit_needs();
            sn.Show();
        }
    }
}
