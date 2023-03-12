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
using TestManagement.Admin;
using System.Text.RegularExpressions;

namespace TestManagement
{
    public partial class frmAddPayment : Form
    {

        string StudentId;
        string FirstName;
        string MiddleName;
        string FullName;
        string LastName;
        string AddressInfo;
        string CityName;
        string Pincode;
        string TestName;
        int TestFees;
        int PaymentId;
        string TransId;
        int TestPaperId;
        string TestType;
        string TestPaperName;
        string PaymentMode;
        int RegistrationFees;
        int CouncelingFees;
        int GST;
        int Total;
        int TotalCount;
        string ReferenceName;
        string Phone;
        string Email;

        public frmAddPayment()
        {
            InitializeComponent();
        }
        public frmAddPayment(string FullName, string Testtype, string TestPaperName, string studentId)
        {
            InitializeComponent();
            lblFullName.Text = FullName;
            lblTestType.Text = Testtype;
            lblStudId.Text = studentId;
            lblTestPaperName.Text = TestPaperName;
        }
        private void btnGetReceipt_Click(object sender, EventArgs e)
        {
            //============ Validation for Combobox =========//

            if (cmbbxPaymentMode.Text == "")
            {
                MessageBox.Show("Select Payment Mode");
                errorProvider1.SetError(this.cmbbxPaymentMode, "Select Payment Mode");
                return;
            }
            if (txtFees.Text == "")
            {
                MessageBox.Show("Please Enter Fees");
                errorProvider1.SetError(this.txtFees, "Please Enter Fees");
                return;
            }
            if (txtbxTotal.Text == "")
            {
                MessageBox.Show("Please Click On The Total Button");
                errorProvider1.SetError(this.txtbxTotal, "Please Click On The Total Button");
                return;
            }
            if (cmbbxPaymentMode.SelectedItem.ToString() == "Online")
            {
                //lblTransactionId.Visible = true;
                //txtTransactionId.Visible = true;
                if (txtTransactionId.Text == "")
                {
                    MessageBox.Show("Please Enter TransactionId");
                    errorProvider1.SetError(this.txtTransactionId, "Please Enter TransactionId");
                    return;
                }
            }

            {
                //============== To Transfer Data to frmReceipt ==============//

                clsAdmin objRec = new clsAdmin(lblStudId.Text, lblTestPaperName.Text);
                SqlDataReader dr;
                dr = objRec.GetReceipt();
                while (dr.Read())
                {
                    //StudentId = dr["StudentId"].ToString();
                    FirstName = dr["FirstName"].ToString();
                    MiddleName = dr["MiddleName"].ToString();
                    LastName = dr["LastName"].ToString();
                    Phone = dr["Contactno"].ToString();
                    Email = dr["EmailId"].ToString();
                    AddressInfo = dr["AddressInfo"].ToString();
                    CityName = dr["CityName"].ToString();
                    Pincode = dr["PINCde"].ToString();
                    //TestName = dr["TestPaperName"].ToString();
                    TestPaperId = Convert.ToInt32(dr["TestPaperId"].ToString());
                    //PaymentId = Convert.ToInt32(dr["PaymentId"].ToString());
                }
                dr.Close();
                StudentId = lblStudId.Text;
                TestType = lblTestType.Text;
                TestPaperName = lblTestPaperName.Text;
                FullName = lblFullName.Text;
                TestFees = Convert.ToInt32(txtFees.Text);
                RegistrationFees = Convert.ToInt32(txtbxRegFees.Text);
                CouncelingFees = Convert.ToInt32(txtbxCounFees.Text);
                GST = Convert.ToInt32(txtbxGST.Text);
                Total = Convert.ToInt32(txtbxTotal.Text);
                ReferenceName = txtRef.Text;

                if (cmbbxPaymentMode.SelectedItem.ToString() == "Cash")
                {
                    TransId = "Cash";
                }
                else if (cmbbxPaymentMode.SelectedItem.ToString() == "Online")
                {
                    TransId = txtTransactionId.Text;
                }
                frmReceipt objReceipt = new frmReceipt(StudentId, FullName, AddressInfo, CityName, Pincode, TestType, TestPaperName, TestFees, TransId, TestPaperId,PaymentMode, RegistrationFees, CouncelingFees, GST, Total, ReferenceName, Phone, Email);
                objReceipt.Show();
                Hide();
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void cmbbxPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaymentMode = cmbbxPaymentMode.SelectedItem.ToString();
            if (cmbbxPaymentMode.SelectedItem.ToString() == "Online")
            {
                lblTransactionId.Visible = true;
                txtTransactionId.Visible = true;
            }
            if (cmbbxPaymentMode.SelectedItem.ToString() == "Cash")
            {
                lblTransactionId.Visible = false;
                txtTransactionId.Visible = false;
            }
            if (string.IsNullOrEmpty(cmbbxPaymentMode.SelectedText))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.cmbbxPaymentMode, "Select Payment Mode");
                return;
            }
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter Only Numbers...!!!");
            }
            //char ch = e.KeyChar;
            //if(!Char.IsDigit(ch))
            //{
            //    e.Handled = true;
            //}
            //e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {
            string Fees = "^[a-zA-z]*$";
            if (Regex.IsMatch(txtFees.Text, Fees))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtFees, "Please Enter the Test Fees...");
                return;
            }
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            lblTransactionId.Visible = false;
            txtTransactionId.Visible = false;
        }

        private void txtbxTotal_TextChanged(object sender, EventArgs e)
        {
            //int GST = Convert.ToInt32(txtbxGST.Text);
            //TotalCount = Convert.ToInt32(txtbxRegFees.Text + txtbxCounFees.Text + txtFees.Text);

            //txtbxTotal.Text = Convert.ToInt32(TotalCount + (TotalCount * GST / 100)).ToString();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int GST = Convert.ToInt32(txtbxGST.Text);
            int A = Convert.ToInt32(txtbxRegFees.Text);
            int B = Convert.ToInt32(txtbxCounFees.Text);
            int C =  Convert.ToInt32(txtFees.Text);

            TotalCount = A + B + C;

            txtbxTotal.Text = Convert.ToInt32(TotalCount + (TotalCount * GST / 100)).ToString();
        }
    }
}
