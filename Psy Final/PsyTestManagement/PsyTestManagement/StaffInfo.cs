using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;
using System.Configuration;
using Microsoft.Office.Core;

namespace PsyTestManagement
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            frmStaff_Registration obj = new frmStaff_Registration();
            obj.Show();
        }

        private void frmStaf_Load(object sender, EventArgs e)
        {

            clsAdmin obj = new clsAdmin();
            DataTable dt = new DataTable();
            dt = obj.grdView();
            
            dataGridView1.DataSource = dt;
            dataGridView1.Show();

            dataGridView1.Columns["AddressInfo"].Visible = false;
            dataGridView1.Columns["CityName"].Visible = false;
            dataGridView1.Columns["PINCode"].Visible = false;

            DataGridViewImageColumn btn = new DataGridViewImageColumn();
            btn.HeaderText = "";
            dataGridView1.Columns.Add(btn);
            btn.Width = 25;
            btn.Image = Image.FromFile(Application.StartupPath + "/Resources/Edit.jpg");
            btn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            btn.ToolTipText = "Edit";
            btn.Name = "btnEdit";
            //    btn.DisplayIndex = 13;

            DataGridViewImageColumn btn1 = new DataGridViewImageColumn();
            btn1.HeaderText = "";
            dataGridView1.Columns.Add(btn1);
            btn1.Width = 25;
            btn1.Image = Image.FromFile(Application.StartupPath + "/Resources/Delete.jpg");
            btn1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            btn1.ToolTipText = "Delete";
            btn1.Name = "btnDelete";
            //    btn1.DisplayIndex = 14;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int staffid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string StaffName = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Int64 contactNo = Convert.ToInt64(this.dataGridView1.CurrentRow.Cells[5].Value.ToString());
            string emailid = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string addressinf = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string pincode = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                frmUpdateStaff_Information objupdate = new frmUpdateStaff_Information(staffid, StaffName, contactNo, emailid, addressinf, pincode);
                objupdate.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clsAdmin obj = new clsAdmin();
            DataTable dt = new DataTable();
            dt = obj.grdView();
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

               int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
              
                clsAdmin obj = new clsAdmin(id);

                obj.btndelete();
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("delete successfully");

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
               String.Format("FullName like '%" + txtSearch.Text + "%'");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++) 
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int k = 0; k < dataGridView1.Rows.Count; k++)
                {
                    for ( int j = 2; j< dataGridView1.Columns.Count;j++)
                    {
                        xcelApp.Cells[k + 2, j + 1] = dataGridView1.Rows[k].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
            
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
