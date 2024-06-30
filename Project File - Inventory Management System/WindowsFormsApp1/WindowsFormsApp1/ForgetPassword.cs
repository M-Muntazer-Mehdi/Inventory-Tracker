using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class ForgetPassword : Form
    {
        string randomcode;
        public static string to;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string from, pass, messageBody;
            //Random rand = new Random();
            //randomcode = (rand.Next(999999)).ToString();
            //MailMessage message = new MailMessage();
            //to = (txtEmail.Text).ToString();
            //from = "mehdirizvi5121472@gmail.com";
            //pass = "tigerbro512";
            //messageBody = $"Your code is : {randomcode}";
            //message.To.Add(to);
            //message.From = new MailAddress(from);
            //message.Body = messageBody;
            //message.Subject = "Password Reseting Code";
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.EnableSsl = true;
            //smtp.Port = 587;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Credentials = new NetworkCredential(from, pass);
            //try
            //{
            //    smtp.Send(message);
            //    MessageBox.Show("Code Successfully send.");
            //}catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            OracleConnection mycon = new OracleConnection("Data Source=DESKTOP-IVSQDIL;User ID=SUPER_PANEL;Password=1214");
            String query = "Select * from USERADMIN where phone = " + txtEmail.Text.Trim();
            OracleDataAdapter con = new OracleDataAdapter(query, mycon);
            DataTable dtb1 = new DataTable();
            con.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                Random rand = new Random();
                randomcode = (rand.Next(999999)).ToString();
                code.Text = "Code is = " + randomcode;
            }
            else
            {
                code.Text = "Phone number does not exist";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if((txtVerCode.Text).ToString() == randomcode)
            {
                to = txtEmail.Text;
                ResetPassword Sp = new ResetPassword(txtEmail.Text);
                this.Hide();
                Sp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code, Try Again!");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVerCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            User Us = new User();
            Us.Show();
        }

        private void code_Click(object sender, EventArgs e)
        {

        }
    }
}
