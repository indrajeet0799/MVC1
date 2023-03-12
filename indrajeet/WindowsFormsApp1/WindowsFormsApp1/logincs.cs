using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void logincs_Load(object sender, EventArgs e)
        {

        }

        private void labForgetPassword_Click(object sender, EventArgs e)
        {
            SendCode sc = new SendCode();
            sc.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=\"create test\";Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblLogin where username='" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("login successfull");
            }
            else
            {
                MessageBox.Show("error");   
            }
        }
    }
}
