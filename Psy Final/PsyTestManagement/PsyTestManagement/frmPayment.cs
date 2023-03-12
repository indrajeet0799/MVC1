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


namespace TestManagement
{
    public partial class frmPayment : Form
    {
        string Status;
        public frmPayment()
        {
            InitializeComponent();
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            //===================== To add AddPayment Column in DataGridView ===================//

            DataGridViewButtonColumn objBtn = new DataGridViewButtonColumn();
            dataGridViewPayment.Columns.Add(objBtn);
            objBtn.HeaderText = "Add Payment";
            objBtn.Text = "Add Payment";
            objBtn.UseColumnTextForButtonValue = true;
            objBtn.Name = "btnAddPayment";

            clsAdmin objAdmin = new clsAdmin();
            DataTable dt = new DataTable();
            dt = objAdmin.GetUnPaidPayment();
            dataGridViewPayment.DataSource = dt;
            dataGridViewPayment.Show();
        }
        private void dataGridViewPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPayment.Columns[e.ColumnIndex].HeaderText == "Add Payment")
            {
                string StudentId = this.dataGridViewPayment.CurrentRow.Cells[1].Value.ToString();
                string FullName = this.dataGridViewPayment.CurrentRow.Cells[2].Value.ToString();
                string TestType = this.dataGridViewPayment.CurrentRow.Cells[3].Value.ToString();
                string TestPaperName = this.dataGridViewPayment.CurrentRow.Cells[4].Value.ToString();
                //string Fees = this.dataGridViewPayment.CurrentRow.Cells[6].Value.ToString();
                Status = this.dataGridViewPayment.CurrentRow.Cells[5].Value.ToString();

                if (Status == "Unpaid")
                {
                    frmAddPayment objAdd = new frmAddPayment(FullName, TestType, TestPaperName, StudentId);
                    objAdd.Show();
                }
                else if (Status == "Paid")
                {
                    MessageBox.Show("Your Payment was Already Done...!!!");
                }
            }
        }
        private void dataGridViewPayment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var Height = 50;
            foreach (DataGridViewRow dr in dataGridViewPayment.Rows)
            {
                Height += dr.Height;
            }
            dataGridViewPayment.Height = Height;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewPayment.DataSource as DataTable).DefaultView.RowFilter = string.Format("Fullname like '%" + txtSearch.Text + "%' or TestType like '%" + txtSearch.Text + "%' or Status like '%" + txtSearch.Text + "%'");
        }

        private void tnRefresh_Click(object sender, EventArgs e)
        {
            clsAdmin objAdmin = new clsAdmin();
            DataTable dt = new DataTable();
            dt = objAdmin.GetUnPaidPayment();
            dataGridViewPayment.DataSource = dt;
            dataGridViewPayment.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayment.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 2; i < dataGridViewPayment.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridViewPayment.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewPayment.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < dataGridViewPayment.Columns.Count; j++)
                    {
                        if (dataGridViewPayment.Rows[i].Cells[j].Value != null)
                        {
                            xcelApp.Cells[i + 2, j + 1] = dataGridViewPayment.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            xcelApp.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
        private void btnPaid_Click_1(object sender, EventArgs e)
        {
            clsAdmin objAdmin = new clsAdmin();
            DataTable dt = new DataTable();
            dt = objAdmin.GetPaidPayment();
            dataGridViewPayment.DataSource = dt;
            dataGridViewPayment.Show();
        }

        private void btnUnpaid_Click(object sender, EventArgs e)
        {
            clsAdmin objAdmin = new clsAdmin();
            DataTable dt = new DataTable();
            dt = objAdmin.GetUnPaidPayment();
            dataGridViewPayment.DataSource = dt;
            dataGridViewPayment.Show();
        }
    }
}
