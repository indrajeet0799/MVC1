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

namespace UserRahitechB62
{
    public partial class Frm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=B62;Integrated Security=True");
        public Frm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into TblB62 values ('"+txtName.Text+"','"+txtAddress.Text+"')", con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("show successfull");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from TblB62 where UserID =(" + txtID.Text + ")", con);
            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("delete successfull");
        }
    }
}
