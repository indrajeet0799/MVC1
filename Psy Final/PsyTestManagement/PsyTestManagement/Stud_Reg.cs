using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Client;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using PSYTestManagement;


using TestManagement;
using TestManagement.Admin;

namespace Client_Student_Information_2
{
    public partial class frmStud_Reg : Form
    {
        int testTypeId = 1;

        string Gender;
         




        public frmStud_Reg()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmStudentInformation_Load(object sender, EventArgs e)
        {
            clsClient objt = new clsClient();
            DataTable dtt = new DataTable();
            dtt = objt.TestList();
            cmbsuggesttest.DisplayMember = "TestType";
            cmbsuggesttest.ValueMember = "TestTypeId";
            cmbsuggesttest.DataSource = dtt;
            cmbsuggesttest.ResetText();

            clsClient obj = new clsClient();
            SqlDataReader dr;
            dr = obj.StudentCode();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["ID"]);
                id++;
                string StudentCode = "RTS" + id;
                lblID1.Text = StudentCode;
            }
            dr.Close();

        }
        //***************************************************Validation********************************************************************
        private void btnSaveandNext_Click(object sender, EventArgs e)
        {
            string StudentId = lblID1.Text;

            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter StaffName");
                ErrorClient.SetError(this.txtName, "please enter FirstName");
                return;
            }


            else if (txtMiddleName.Text == "")
            {
                MessageBox.Show("Please select a MiddleName....!");
                ErrorClient.SetError(this.txtName, "Plese select the Middle Name");
                return;
            }

            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Please select a LastName....!");
                ErrorClient.SetError(this.txtLastName, "Plese select the Last Name");
                return;
            }

            else if (txtbxEmailId.Text == "")
            {
                MessageBox.Show("Please select a EmailId....!");
                ErrorClient.SetError(this.txtbxEmailId, "Plese select the EamilId ");
                return;
            }


            else if (txtbxContactNo.Text == "")
            {
                MessageBox.Show("Please select a ContactNumber....!");
                ErrorClient.SetError(this.txtbxContactNo, "Plese select the ContactNumber");
                return;
            }
            else if (DOB.Text == "")
            {
                MessageBox.Show("Please select a DOB....!");
                ErrorClient.SetError(this.DOB, "Plese select the DOB");
                return;
            }

            else if (txtbxIncome.Text == "")
            {
                MessageBox.Show("Please Enter Your Income");
                ErrorClient.SetError(this.txtbxIncome, "Enter your Income");
                return;
            }
            else if (cmbbxfamilytype.Text == "")
            {
                MessageBox.Show("Please Enter your Family Type");
                ErrorClient.SetError(this.cmbbxfamilytype, "Enter your FamilyType.Nuclear Or Joint");
                return;
            }
            if (cmbbxSocialEn.Text == "")
            {
                MessageBox.Show("Please Enter your Area Type");
                ErrorClient.SetError(this.cmbbxSocialEn, "Enter your SocialEnvironment");
                return;
            }

            else if (rdbbtnFemale.Checked == false && rdbbtnMale.Checked == false && rdbbtnOther.Checked == false)
            {
                MessageBox.Show("Select the Gender ");
                return;
            }
            else if (TestPaper.CheckedIndices.Count <= 0)
            {
                MessageBox.Show("Select Test Type");
                return;
            }
            else
            {


                string Firstname = txtName.Text;
                String MiddleName = txtMiddleName.Text;
                string LastName = txtLastName.Text;
                string EmailId = txtbxEmailId.Text;
                string Gender = "null";
                if (rdbbtnMale.Checked == true)
                {
                    Gender = "Male";

                }
                else if (rdbbtnFemale.Checked == true)
                {
                    Gender = "Female";
                }
                else if (rdbbtnOther.Checked == true)
                {
                    Gender = "Other";
                }



                DateTime DateDOB = Convert.ToDateTime(DOB.Text);
                string Contact = txtbxContactNo.Text;
                string AddressInfo = "null";
                int CityId = 0;
                int PINCde = 0;
                string MotherName = "null";
                string SchoolName = "null";
                int MediumId = 0;
                decimal Percentage = 0;
                DateTime studentregistrationDate = System.DateTime.Now;
                int statusId = 4;
                string familytype = cmbbxfamilytype.Text.ToString();
                string familyincome = txtbxIncome.Text;
                string socialtype = cmbbxSocialEn.Text;
                int age1 = DateTime.Today.Year - DOB.Value.Year;
                string STD = "0";
                int qualificationId = 2;
                string collagename = "";
                int isdelete = 0;


                clsClient obj = new clsClient(StudentId, Firstname, MiddleName, LastName, Gender, DateDOB, EmailId, Contact, AddressInfo, CityId, PINCde, MotherName, collagename, SchoolName,
               qualificationId, MediumId, Percentage, studentregistrationDate, statusId,familytype, familyincome, age1, STD, socialtype, isdelete);
                obj.StudentRegistration();

                foreach (var item in TestPaper.CheckedItems)
                {
                    var row = (item as DataRowView).Row;
                    string paperid = row["TestPaperId"].ToString();

                    int TestTYPEID = Convert.ToInt32(cmbsuggesttest.SelectedValue.ToString());
                    int TestStatusID = 4;
                    int FeesStatusID = 7;

                    clsAdmin objsaveSuggest = new clsAdmin(StudentId, TestTYPEID, Convert.ToInt32(paperid), TestStatusID, FeesStatusID);
                    objsaveSuggest.SuggestedSave();
                }
                MessageBox.Show("Register Successfully");

                this.Close();
                frmPayment objpayment = new frmPayment();
                objpayment.Show();
                    
            }
        }
        //**********************************************************************************************************************************
        private void lblGender_Click(object sender, EventArgs e)
        {
            if (rdbbtnMale.Checked && rdbbtnFemale.Checked && rdbbtnOther.Checked)
            {
                ErrorClient.Clear();
            }
            else
            {
                ErrorClient.SetError(this.lblGender, "Select a Gender!");
                MessageBox.Show("Enter the gender");
                return;
            }
        }
        //*************************************************************************************************************************************
        private void txtbxContactNo_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[A-9]{10}$";
            if (Regex.IsMatch(txtbxContactNo.Text, pattern))
            {
                ErrorClient.Clear();
            }
            else
            {
                ErrorClient.SetError(this.txtbxContactNo, "Enter the valid contact number");
                return;
            }
        }
        //*******************************************************************************************************************************88
        private void txtbxEmailId_TextChanged_1(object sender, EventArgs e)
        {
            string pattern = "^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$";
            //string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtbxEmailId.Text, pattern))
            {

                ErrorClient.Clear();

            }
            else
            {
                ErrorClient.SetError(this.txtbxEmailId, "Please enter valid email id");
                return;
            }
        }
        //***************************************************FirstName******************************************************************
        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            string pattern = "^[A-zA]*$";
            if (Regex.IsMatch(txtName.Text, pattern))
            {
                ErrorClient.Clear();
            }
            else
            {
                ErrorClient.SetError(this.txtName, "Enter the CorrectPateern");
                MessageBox.Show("Enter valid name..digits are not allow here");
                return;
            }
        }

        private void txtMiddleName_TextChanged_1(object sender, EventArgs e)
        {

            string pattern = "^[A-zA]*$";
            if (Regex.IsMatch(txtMiddleName.Text, pattern))
            {
                ErrorClient.Clear();
            }
            else
            {
                ErrorClient.SetError(this.txtMiddleName, "Enter the CorrectPateern");
                MessageBox.Show("Enter valid name..digits are not allow here");
                return;
            }
        }
        //********************************************************LastName*********************************************************
        private void txtLastName_TextChanged_1(object sender, EventArgs e)
        {

            string pattern = "^[A-zA]*$";
            if (Regex.IsMatch(txtLastName.Text, pattern))
            {
                ErrorClient.Clear();
            }
            else
            {
                ErrorClient.SetError(this.txtLastName, "Enter the Correct Pattern");
                MessageBox.Show("Enter valid name...Digits are not allow here");
                return;
            }
        }
        //****************************************ContactNo**************************************************************************
        private void txtbxContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("only allow digits");
            }
        }

        private void txtbxContactNo_Validating(object sender, CancelEventArgs e)
        {
           
        }
        private void txtbxIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Allow Digits Here");
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void chklistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbsuggesttest_SelectedIndexChanged(object sender, EventArgs e)
        {
            int testtypeid = Convert.ToInt32(cmbsuggesttest.SelectedValue.ToString());

            clsClient objp = new clsClient(testtypeid);
            DataTable dtp = new DataTable();
            dtp = objp.PaperList();
            DataColumn dc = new DataColumn("StringType", typeof(String));
            dtp.Columns.Add(dc);
            DataRow dr = dtp.NewRow();
            dtp.Rows.Add(dr);
            this.TestPaper.DataSource = dtp;
            this.TestPaper.DisplayMember = "TestPaperName";
            this.TestPaper.ValueMember = "TestPaperId";
        }
    }
}