using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserChothe1999
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=Chothe1999;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserRahitech obj = new UserRahitech();
            DataTable dt = new DataTable();
            dt = obj.GetUser();
            grdUserDetails.DataSource = dt;
            grdUserDetails.Show();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            UserRahitech objfrm = new UserRahitech(txtName.Text, txtVillage.Text, txtTalukha.Text);
            objfrm.ShowUser();
            
            
                
            

            MessageBox.Show("Show successfully..");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserRahitech obj = new UserRahitech(Convert.ToInt32 (txtID.Text));
            obj.DeleteUser();
             
               
            
          
            MessageBox.Show("delete succesfull");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            UserRahitech obj = new UserRahitech(Convert.ToInt32(txtID.Text), txtName.Text, txtVillage.Text, txtTalukha.Text);
            obj.UpdateUser();


            con.Close();
            MessageBox.Show("update successflly...");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            UserRahitech obj = new UserRahitech(Convert.ToInt32(txtID.Text));
            SqlDataReader dr;
            dr = obj.GetShow();
            while (dr.Read()) 
            {
                txtName.Text = dr["UserName"].ToString();
                txtVillage.Text = dr["UserVillage"].ToString();
                txtTalukha.Text = dr["UserTalukha"].ToString();
            }
            dr.Close();
            con.Close();

            

         



            
        }
    }
}
