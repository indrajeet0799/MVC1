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
    public partial class Resetpassword : Form
    {
        string username = SendCode.to;
        public Resetpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtResetPass.Text==txtResetPassVerify.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=\"create test\";Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tblLogin]  SET  [Password] = '" + txtResetPassVerify.Text + "' WHERE username='" + username + "'", con);
                con.Open(); 
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("reset successfully");
            }
            else
            {
                MessageBox.Show("the new password do not match so enter same password");
            }
        }
    }
}
