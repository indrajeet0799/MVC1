using Client_Student_Information_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement;
using TestManagement.Admin;

namespace PsyTestManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgot_Password objpassword = new frmForgot_Password();
            objpassword.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
          
             if (txtusername.Text == "")
            {
                MessageBox.Show("Please Enter your Username");
                errorLogin.SetError(this.txtusername, "plzzz provide valid Username");
                return;
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Enter your Password");
                errorLogin.SetError(this.txtpassword, "plzzz provide valid Password");
                return;
            }
            string Position = null;
            string staffname = null;
            string Contact = null;
            string Emailid = null;
            string Password = null;
            string Address = null;
            int Pincode = 0;
            int StaffId = 0;

            string EmailID = txtusername.Text;
            string password = txtpassword.Text;

            clsAdmin objlogin = new clsAdmin(EmailID, password);
            SqlDataReader dr;
            dr = objlogin.Login();
            while (dr.Read())
            {
                Position = dr["StaffPosition"].ToString();
                staffname = dr["FullName"].ToString();
                 Contact = dr["PhoneNo"].ToString();
                 Emailid = dr["EmailId"].ToString();
                 Password = dr["Password"].ToString();
                 Address = dr["AddressInfo"].ToString();
                 Pincode = Convert.ToInt32(dr["PINCode"].ToString());
                 StaffId = Convert.ToInt32(dr["StaffId"].ToString());                
            }
            if (dr.HasRows && Position == "Admin")
            {
                frmDashboard objdashboard = new frmDashboard(staffname, Contact, Emailid, Password, Address, Pincode, StaffId);
                objdashboard.Show();
                txtusername.Clear();
                txtpassword.Clear();
               
            }
            else if (dr.HasRows && Position == "Staff")
            {
                frmEnterExam objexam = new frmEnterExam();
                objexam.Show();
                txtusername.Clear();
                txtpassword.Clear();
               
            }
            else if (txtusername.Text.Length == 0)
            {
                MessageBox.Show("Username can not be blank...!!!");
            }
            else if (!Regex.IsMatch(txtpassword.Text, @"[A-Za-z][A-Za-z0-9]{2,7}"))
            {
                MessageBox.Show("Invalid Password can not use special character password");
            }
            else
            {
                MessageBox.Show("Login Failed...!!!");
            }
            
        }
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPass.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
