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

namespace WindowsFormsApp1
{
    public partial class SendCode : Form
    {
        string RandomCode;
        public static string to;
        public SendCode()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            RandomCode=(rand.Next(999999)).ToString();
            MailMessage message= new MailMessage(); 
            to= (txtEmail.Text).ToString();
            from = "saurabh72720@gmail.com";
            pass = "tpfeqzysnovozwkw";
            messageBody = "your reset code is" + RandomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod=SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try

            {
                smtp.Send(message);
                MessageBox.Show("Code send successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            if (RandomCode == (txtVarcode.Text).ToString()) 
            {
                to = txtEmail.Text;
                Resetpassword rp = new Resetpassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong code");
            }
        }
    }
}
