using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserDashboard : Form
    {
        public UserDashboard(string e1, string e2)
        {
            InitializeComponent();
            name.Text = e1;
            password.Text = e2;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alert al = new Alert();
            al.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            User us = new User();
            us.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Item_Records it = new Item_Records();
            it.Show();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_return_item ed = new Edit_return_item();
            ed.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_delivered_item ed = new Edit_delivered_item();
            ed.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Societies es = new Edit_Societies();
            es.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Society_needs sn = new Society_needs();
            sn.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_records ad = new Add_records();
            ad.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Records dr = new Delete_Records();
            dr.Show();
        }
    }
}
