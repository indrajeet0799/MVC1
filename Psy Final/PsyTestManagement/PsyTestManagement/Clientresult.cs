using PsyTestManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;

namespace TestManagement.Admin
{
    public partial class frmClientresult : Form
    {
        public string studid;
        public string Fullname;
        public string age;
        public string gender;

        public frmClientresult()
        {
            InitializeComponent();
        }

        private void Clientresult_Load(object sender, EventArgs e)
        {
            clsAdmin frm = new clsAdmin();
            DataTable dt = new DataTable();
            dt = frm.getclientresult();
            grdclientresult.DataSource = dt;
            grdclientresult.Show();

            
        }

        private void grdclientresult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grdclientresult.AutoGenerateColumns = false;

            studid = grdclientresult.CurrentRow.Cells[2].Value.ToString();
            Fullname = grdclientresult.CurrentRow.Cells[3].Value.ToString();
            //middlename = grdclientresult.CurrentRow.Cells[3].Value.ToString();
            //lastname = grdclientresult.CurrentRow.Cells[4].Value.ToString();
            age = grdclientresult.CurrentRow.Cells[6].Value.ToString();
            gender = grdclientresult.CurrentRow.Cells[5].Value.ToString();
            
            if (grdclientresult.Columns[e.ColumnIndex].HeaderText == "Result")
            {
                Result rs = new Result(studid,Fullname, age,gender);
                rs.Show();
            }

            if (grdclientresult.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                string id = grdclientresult.Rows[e.RowIndex].Cells[2].Value.ToString();
                

                clsAdmin obj = new clsAdmin(id);

                obj.Deleteresult();
                grdclientresult.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("delete successfully");

            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (grdclientresult.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Fullname like '%" + txtSearch.Text + "%'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clsAdmin frm = new clsAdmin();
            DataTable dt = new DataTable();
            dt = frm.getclientresult();
            grdclientresult.DataSource = dt;
            grdclientresult.Show();
        }
    }
}
