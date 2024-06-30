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
    public partial class Delete_User : Form
    {
        String connectionstring = ("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
        public Delete_User()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from USERADMIN", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv4.DataSource = dtb1;
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214";
            String myquery = "Select * from USERADMIN where ID =" + search.Text;
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
                name.Text = (ds.Tables[0].Rows[0]["USERNAME1"].ToString()).Trim();
                password.Text = (ds.Tables[0].Rows[0]["PASSWORD1"].ToString()).Trim();
            }
            else
            {
                name.Text = "";
                password.Text = "";

            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214";
            String myquery = "Delete from USERADMIN where ID =" + search.Text;
            OracleConnection con = new OracleConnection(mycon);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_User AD = new Add_User();
            AD.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_User US = new Update_User();
            US.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperPanelDashboard Sp = new SuperPanelDashboard();
            Sp.Show();
        }
    }
}
