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
    public partial class SuperPanel : Form
    {
        public SuperPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperPanelDashboard Sp = new SuperPanelDashboard();
            Sp.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            OracleConnection mycon = new OracleConnection("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
            String query = "Select * from ADMIN where username = '" + username.Text.Trim() + "' and password = '" + password.Text.Trim() + "'";
            OracleDataAdapter con = new OracleDataAdapter(query, mycon);
            DataTable dtb1 = new DataTable();
            con.Fill(dtb1);
            if(dtb1.Rows.Count == 1)
            {
                this.Hide();
                SuperPanelDashboard Sp = new SuperPanelDashboard();
                Sp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username and password. TRY AGAIN!");
            }
        }

        private void SuperPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
