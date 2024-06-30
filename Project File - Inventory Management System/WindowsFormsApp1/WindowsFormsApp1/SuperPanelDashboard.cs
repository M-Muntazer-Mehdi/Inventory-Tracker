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
    public partial class SuperPanelDashboard : Form
    {
        String connectionstring = ("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
        public SuperPanelDashboard()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from USERADMIN", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv1.DataSource = dtb1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_User Au = new Add_User();
            Au.Show();

        }

        private void SuperPanelDashboard_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperPanel Sp = new SuperPanel();
            Sp.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Item_Records IT = new Item_Records();
            IT.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_User UP = new Update_User();
            UP.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_User Du = new Delete_User();
            Du.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Society_records Sr = new Society_records();
            Sr.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivered_item Sp = new Delivered_item();
            Sp.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return_item RT = new Return_item();
            RT.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alert Al = new Alert();
            Al.Show();
        }
    }
}
