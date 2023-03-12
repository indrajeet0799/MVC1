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
using System.Text.RegularExpressions;

namespace TestManagement
{
    public partial class frmAddTestType : Form
    {
        public frmAddTestType()
        {
            InitializeComponent();
        }
        private void frmAddTestType_Load(object sender, EventArgs e)
        {
            clsAdmin objAdmin = new clsAdmin();     /* Getting Status From Database in combobox */
            DataTable dt = new DataTable();
            dt = objAdmin.GetStatus();
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTestTypeName.Text == "")     /* Warrning for Empty Textbox */
            {
                MessageBox.Show("Please Enter Test Type...");
                errorProvider1.SetError(this.txtTestTypeName, "Please Enter Test Type...");
                return;
            }
            if (cmbbxStatus.Text == "")     /* Warrning For Empty Combobox */
            {
                MessageBox.Show("Please Select Status for Test Type...");
                errorProvider1.SetError(this.cmbbxStatus, "Please Select Status for Test Type...");
                return;
            }
            {
                int StatusId = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());       /* on Button Add Click Save Test Type And Status for Test Type */
                clsAdmin objAdmin = new clsAdmin(txtTestTypeName.Text, StatusId);
                objAdmin.SaveTestType();
                MessageBox.Show("Test Type Saved Successfully...!!!");
                txtTestTypeName.Clear();
                cmbbxStatus.ResetText();
            }
        }
        private void txtTestTypeName_TextChanged(object sender, EventArgs e)
        {
            string TestType = "^[a-zA-Z ]*$";
            if (Regex.IsMatch(txtTestTypeName.Text, TestType))       /* Validations for textbox by errorProvider */
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtTestTypeName, "Please Enter Test Type...");
                return;
            }
        }
        private void cmbbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxStatus.SelectedText))     /* Validations for Combobox by errorProvider */
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.cmbbxStatus, "Please Select Status for Test Type...");
                return;
            }
        }
    }
}
