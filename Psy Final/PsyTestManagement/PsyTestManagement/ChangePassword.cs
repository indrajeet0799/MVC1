using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;
using System.Data.SqlClient;

namespace PsyTestManagement
{
    public partial class frmChangePassword : Form
    {
        public int StaffId { get; set; }
        public string StaffPass { get; set; }
        public frmChangePassword(int staffid,string password)
        {
            InitializeComponent();
            StaffId = staffid;
            StaffPass = password;
        }
        
        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdatePassWord_Click(object sender, EventArgs e)
        {
            if(txtbxOldPass.Text == StaffPass)
            {
                if (txtbxNewPass.Text != txtbxConfirmPass.Text)
                {
                    MessageBox.Show("Password Does not  Match Successfully");
                }
                else
                {
                    clsAdmin objchange = new clsAdmin(txtbxConfirmPass.Text, StaffId);
                    DataTable dt = new DataTable();
                    dt = objchange.ChangePassword();
                    MessageBox.Show("Your Password Changed Succesfully ......!");
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("OLD Password Incorrect");
            }
           
        }

        private void txtbxOldPass_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
