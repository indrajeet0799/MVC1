using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;
using System.Data.SqlClient;

namespace PsyTestManagement
{
    public partial class frmForgot_Password : Form
    {
        string to;
        public frmForgot_Password()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string emailid = txtEmailID.Text;
            clsAdmin obj = new clsAdmin(emailid);
            SqlDataReader dr;
            dr = obj.Forgot_Pass();
            if (dr.HasRows == true)
            {
                dr.Read();
                //string email = dr["EmailId"].ToString();
                string password = dr["Password"].ToString();

                string from, pass, messagebody;
                MailMessage message = new MailMessage();
                to = (txtEmailID.Text).ToString();
                from = "saurabh72720@gmail.com";
                pass = "tpfeqzysnovozwkw";
                messagebody = "Your Password is "+ password;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Get Password";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Send successfully Password");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
