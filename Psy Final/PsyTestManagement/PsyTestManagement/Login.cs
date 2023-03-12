using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
            string Position = cmbPosition.SelectedItem.ToString();
            string EmailID = txtusername.Text;
            string password = txtpassword.Text;

            clsAdmin objlogin = new clsAdmin(Position, EmailID, password);
            SqlDataReader dr;
            dr = objlogin.Login();
            while(dr.Read())
            {
                if(cmbPosition.Text.ToString() == "Admin")
                {
                    frmDashboard objdashboard = new frmDashboard();
                    MessageBox.Show("Login Successfully");
                    objdashboard.Show();
                }
                else if (cmbPosition.Text.ToString() == "Staff")
                {
                    frmEnterExam objexam = new frmEnterExam();
                    MessageBox.Show("Login Successfully");
                    objexam.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }

            }

            if (cmbPosition.Text == " ")
            {
                MessageBox.Show("You must select a conversion Position");
                errorLogin.SetError(this.cmbPosition, "You must select a conversion Position");
                return;
            }
            if (txtusername.Text == "")
            {
                MessageBox.Show("Please Enter your Name");
                errorLogin.SetError(this.txtusername, "plzzz provide valid Name");
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Enter your EmailID");
                errorLogin.SetError(this.txtpassword, "plzzz provide valid EmailID");
                return;
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
    }
}
