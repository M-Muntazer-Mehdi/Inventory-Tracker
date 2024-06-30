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
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword FP = new ForgetPassword();
            FP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            OracleConnection mycon = new OracleConnection("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
            String query = "Select * from USERADMIN where username1 = '" + textBox1.Text.Trim() + "' and password1 = '" + textBox2.Text.Trim() + "'";
            OracleDataAdapter con = new OracleDataAdapter(query, mycon);
            DataTable dtb1 = new DataTable();
            con.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                //try
                //{
                //    using (MailMessage mail = new MailMessage())
                //    {
                //        mail.From = new MailAddress("mehdirizvi5121472@gmail.com");
                //        mail.To.Add("funnytalks.org@gmail.com");
                //        mail.Subject = "User Login";
                //        mail.Body = "<h1>User is login to Daira Managment system</h1>";
                //        mail.IsBodyHtml = true;

                //        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                //        {
                //            smtp.Credentials = new System.Net.NetworkCredential("mehdirizvi5121472@gmail.com", "tigerbro512");
                //            smtp.EnableSsl = true;
                //            smtp.Send(mail);
                //            label3.Text = "Mail sent!";
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    label3.Text = ex.Message;
                //}
                this.Hide();
                UserDashboard Sp = new UserDashboard(textBox1.Text, textBox2.Text);
                Sp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username and password. TRY AGAIN!");
            }
        }
    }
}
