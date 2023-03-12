using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;

namespace Testmgt
{
    public partial class FrmAbove18 : Form
    {
        public int testtypeid = 0;
        private string StudentId;
        private string Studentname;
        private string FatherName;
        private string LastName;
        private string EmailID;
        private string Contact;
        private string Address;
        private string Cityname;
        private string Statename;
        private string Countryname;

        public FrmAbove18(string StudentID, string StudentName, string FatherName, string LastName,string EmailID, string contact, string Address, string cityname, string statename, string countryname, decimal percentage)
        {
            InitializeComponent();
            lblStudentID1.Text = StudentID.ToString();
            lblStudent1.Text = StudentName;
            lblFather1.Text = FatherName;
            lblLast1.Text = LastName;
            lblEmail1.Text = EmailID;
            lblContact1.Text = contact.ToString();
            lbladdress1.Text = Address;
            lblCity1.Text = cityname;
            lblState1.Text = statename;
            lblCountry1.Text = countryname;
            txtPercentage1.Text = percentage.ToString();
        }
        //private void btnsave_Click(object sender, EventArgs e)
        //{
        //    FrmStudentRegistration obj = new FrmStudentRegistration();
        //    obj.Show();
        //}
        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (txtMotherName1.Text == "")
            {
                MessageBox.Show("Please enter MotherName");
                ErrorAboveReg.SetError(this.txtMotherName1, "please enter MotherName");
                return;
            }
            if (txtCollageName.Text == "")
            {
                MessageBox.Show("Please enter CollageName");
                ErrorAboveReg.SetError(this.txtMotherName1, "please enter CollageName");
                return;
            }

            if (cmbbxQualification1.Text == "")
            {
                MessageBox.Show("Please enter STD");
                ErrorAboveReg.SetError(this.cmbbxQualification1, "please enter Qualification");
                return;
            }

            if (txtPercentage1.Text == "")
            {
                MessageBox.Show("Please enter Percentage");
                ErrorAboveReg.SetError(this.txtPercentage1, "please enter Percentage");
                return;
            }

            if (TestPaper.CheckedIndices.Count <= 0)
            {
                MessageBox.Show("Select Test Type");
                return;
            }

            string studentid = lblStudentID1.Text;
            string MotherName = txtMotherName1.Text;
            string CollageName = txtCollageName.Text;
            int Percentage = Convert.ToInt32(txtPercentage1.Text.ToString());
            int qualificationid = Convert.ToInt32(cmbbxQualification1.SelectedIndex.ToString());
            int testtypeid = Convert.ToInt32(cmbsuggesttest.SelectedValue.ToString());

            foreach (var item in TestPaper.CheckedItems)
            {
                var row = (item as DataRowView).Row;
                string paperid = row["TestPaperId"].ToString();

                int TestTYPEID = Convert.ToInt32(cmbsuggesttest.SelectedValue.ToString());
                int TestStatusID = 4;
                int FeesStatusID = 7;

                clsAdmin objsaveSuggest = new clsAdmin(studentid, TestTYPEID, Convert.ToInt32(paperid), TestStatusID, FeesStatusID);
                objsaveSuggest.SuggestedSave();
            }

            clsAdmin objA = new clsAdmin(studentid, MotherName, CollageName,Percentage, qualificationid);
            objA.UpdateAForm();
            MessageBox.Show(" Registered Successfully....!!!");
            this.Close();
        }

        private void FrmAbove18_Load(object sender, EventArgs e)
        {

            clsAdmin objQ = new clsAdmin();
            DataTable dtq = new DataTable();
            dtq = objQ.Qualification();
            cmbbxQualification1.DisplayMember = "Qualification";
            cmbbxQualification1.ValueMember = "QualificationId";
            cmbbxQualification1.DataSource = dtq;
            cmbbxQualification1.ResetText();

            clsAdmin obj = new clsAdmin();
            DataTable dt = new DataTable();
            dt = obj.TestList();
            cmbsuggesttest.DataSource = null;
            cmbsuggesttest.DisplayMember = "TestType";
            cmbsuggesttest.ValueMember = "TestTypeId";
            cmbsuggesttest.DataSource = dt;
            /*this.cmbsuggesttest.ResetText();*/
        }
        private void txtMotherName1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";
            if (Regex.IsMatch(txtMotherName1.Text, pattern))
            {
                ErrorAboveReg.Clear();
            }
            else
            {
                ErrorAboveReg.SetError(this.txtMotherName1, "Please Enter Mother Name");
            }
        }

        private void cmbsuggesttest_SelectedIndexChanged(object sender, EventArgs e)
        {
            testtypeid = Convert.ToInt32(cmbsuggesttest.SelectedValue);

            clsAdmin objp = new clsAdmin(testtypeid);
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {

        }

        private void lblCity1_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxQualification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SuggestedTest1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
