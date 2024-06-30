using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
namespace WindowsFormsApp1
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Label mylab = new Label();
            mylab.Text = "GeeksforGeeks";
            mylab.Location = new Point(222, 90);
            mylab.Size = new Size(120, 25);
            mylab.BorderStyle = BorderStyle.FixedSingle;

            // Adding this control to the form
            this.Controls.Add(mylab);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User US = new User();
            US.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperPanel Sp = new SuperPanel();
            Sp.Show();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            SuperPanel Sp = new SuperPanel();
            Sp.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            User US = new User();
            US.Show();
        }
    }
}
