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

namespace UserManegment
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=vita;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clssangli obj = new Clssangli(txtName.Text, txtAddress.Text);
            obj.Usersave();
            

            MessageBox.Show("save successfully");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clssangli obj = new Clssangli(Convert.ToInt32(txtId.Text));
            obj.deleteUser();
            MessageBox.Show("Delete successfully");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Clssangli obj = new Clssangli(Convert.ToInt32(txtId.Text), txtName.Text, txtAddress.Text);
            obj.UpdateUser();

            MessageBox.Show("Update successfully");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Clssangli obj = new Clssangli();
            DataTable dt = new DataTable();
            dt = obj.GetUser();
            grdUservita.DataSource = dt;
            grdUservita.Show();
            

            

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Clssangli obj = new Clssangli(Convert.ToInt32(txtId.Text));
            SqlDataReader dr;
            dr = obj.GetShow();
            while (dr.Read()) 
            {
                txtName.Text = dr["UserName"].ToString();
                txtAddress.Text = dr["UserAddress"].ToString();
            }
            dr.Close();


            con.Close();
                
        }
    }
}

