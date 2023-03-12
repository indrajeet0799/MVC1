using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Testmgt
{
    public partial class FrmBelow18 : Form
    {
        public int testtypeid = 0;
        //int testypeid = 0;

        public FrmBelow18(string studentid, string studentname, string fathername, string lastname,string emailid, string contact, string address, string cityname, string statename, string countryname,decimal percentage,string STD)
        {
            InitializeComponent();
            lblStudentID2.Text = studentid;
            lblStudent2.Text = studentname;
            lblFather2.Text = fathername;
            lblLast2.Text =lastname;
            lblEmail2.Text = emailid;
            lblContact2.Text = contact;
            lbladdress2.Text = address;
            lblCity2.Text = cityname;
            lblState2.Text = statename;
            lblCountry2.Text = countryname;
            txtPecentage2.Text = percentage.ToString();
            cmbbxSTD2.Text = STD;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtMotherName2.Text == "")
            {
                MessageBox.Show("Please enter MotherName");
                ErrorBelowReg.SetError(this.txtMotherName2, "please enter MotherName");
                return;
            }

            if (txtSchoolName2.Text == "")
            {
                MessageBox.Show("Please enter SchoolName");
                ErrorBelowReg.SetError(this.txtSchoolName2, "please enter SchoolName");
                return;
            }

            if (txtPecentage2.Text == "")
            {
                MessageBox.Show("Please enter Percentage");
                ErrorBelowReg.SetError(this.txtPecentage2, "please enter Percentage");
                return;
            }

            if (TestPaper.CheckedIndices.Count <= 0)
            {
                MessageBox.Show("Select Test Type");
                return;
            }

            if (cmbbxSTD2.Text == "")
            {
                MessageBox.Show("Please enter STD");
                ErrorBelowReg.SetError(this.cmbbxSTD2, "please enter STD");
                return;
            }


            string Studentid = lblStudentID2.Text;
            string MotherName = txtMotherName2.Text;
            string Schoolname = txtSchoolName2.Text;
            string STD = cmbbxSTD2.Text;
            int Percentage = Convert.ToInt32(txtPecentage2.Text.ToString());
            int Mediumid =Convert.ToInt32(cmbMedium.SelectedValue.ToString());
            int testtypeid = Convert.ToInt32(cmbsuggesttest.SelectedValue.ToString());

            foreach(var item in TestPaper.CheckedItems)
            {
                var row = (item as DataRowView).Row;
                string paperid = row["TestPaperId"].ToString();

                int TestTYPEID = Convert.ToInt32(cmbsuggesttest.SelectedValue.ToString());
                int TestStatusID = 4;
                int FeesStatusID = 7;

                clsAdmin objsaveSuggest = new clsAdmin(Studentid, TestTYPEID, Convert.ToInt32(paperid), TestStatusID, FeesStatusID);
                objsaveSuggest.SuggestedSave();
            }

            clsAdmin objsave = new clsAdmin( Studentid, MotherName,Schoolname, STD,Percentage, Mediumid);
            objsave.UpdateBForm();

            

            this.Close();
            MessageBox.Show("Test Saved Successfully....!!!");

            this.Close();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmBelow18_Load(object sender, EventArgs e)
        {
            clsAdmin objQ = new clsAdmin();
            DataTable dtq = new DataTable();
            dtq = objQ.Medium();
            cmbMedium.DisplayMember = "Medium";
            cmbMedium.ValueMember = "MediumId";
            cmbMedium.DataSource = dtq;
            cmbsuggesttest.ResetText();

            clsAdmin obj = new clsAdmin();
            DataTable dt = new DataTable();
            dt = obj.TestList();
            cmbsuggesttest.DisplayMember = "TestType";
            cmbsuggesttest.ValueMember = "TestTypeId";
            cmbsuggesttest.DataSource = dt;
            /*this.cmbsuggesttest.ResetText();*/
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            {
                System.Text.StringBuilder TestIds = new System.Text.StringBuilder();

                foreach (var item in TestPaper.Items)
                {
                    var a = (item as DataRowView);
                }
            
            }

            MessageBox.Show("Clear All Entities....!!!");
        }

        private void lblStudentID2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SuggestedTest2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMotherName2_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";
            if (Regex.IsMatch(txtMotherName2.Text, pattern))
            {
                ErrorBelowReg.Clear();
            }
            else
            {
                ErrorBelowReg.SetError(this.txtMotherName2, "Please Enter Mother Name");
            }
        }

        private void txtSchoolName2_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";
            if (Regex.IsMatch(txtSchoolName2.Text, pattern))
            {
                ErrorBelowReg.Clear();
            }
            else
            {
                ErrorBelowReg.SetError(this.txtSchoolName2, "Please Enter School Name");
            }
        }

        private void cmbbxSTD2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPecentage2_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{6}$";

            if (Regex.IsMatch(txtPecentage2.Text, pattern))
            {
                ErrorBelowReg.Clear();
            }
            else
            {
                ErrorBelowReg.SetError(this.txtPecentage2, "Please provide Valid Percentage");
                return;
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
    }
}
