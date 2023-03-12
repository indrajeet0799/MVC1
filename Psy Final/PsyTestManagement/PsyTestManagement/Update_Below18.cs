using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PsyTestManagement;
using TestManagement.Admin;

namespace PsyTestManagement
{
    public partial class FrmBelow18 : Form
    {


        public FrmBelow18(string studentid, string firstname, string fathername,string lastname, string mothername, string emailid,string contact ,string addressinfo,string schoolname,decimal percentage,string familyincome)
        {
            InitializeComponent();
            lblStudentId2.Text = studentid;
            txtStudentName2.Text = firstname;
            txtFatherName2.Text = fathername;
            txtLastName2.Text = lastname;
            txtMotherName2.Text = mothername;
            txtEmailID2.Text = emailid;
            txtaddress.Text = addressinfo;
            txtPercentage2.Text = percentage.ToString();
            txtSchoolName2.Text = schoolname;
            txtFamilyIncome2.Text = familyincome;
            txtContact2.Text = contact;
            
        }

        private void FrmBelow18_Load(object sender, EventArgs e)
        {
            clsAdmin objC = new clsAdmin();
            DataTable dtC = new DataTable();
            dtC = objC.Country();
            cmbbxCountry2.DisplayMember = "CountryName";
            cmbbxCountry2.ValueMember = "CountryId";
            cmbbxCountry2.DataSource = dtC;

            //cmbbxCountry2.ResetText();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (txtStudentName2.Text == "")
            {
                MessageBox.Show("Please enter First Name");
                errorBelow18.SetError(this.txtStudentName2, "please enter First Name");
                return;
            }
            if (txtLastName2.Text == "")
            {
                MessageBox.Show("Please enter Last Name");
                errorBelow18.SetError(this.txtLastName2, "please enter Last Name");
                return;
            }
            if (txtFatherName2.Text == "")
            {
                MessageBox.Show("Please enter Father Name");
                errorBelow18.SetError(this.txtFatherName2, "please enter Father Name");
                return;
            }
            if (txtMotherName2.Text == "")
            {
                MessageBox.Show("Please enter Mother Name");
                errorBelow18.SetError(this.txtMotherName2, "please enter Mother Name");
                return;
            }
            if (txtaddress.Text == "")
            {
                MessageBox.Show("Please enter Address");
                errorBelow18.SetError(this.txtaddress, "please enter Address");
                return;
            }
            if (txtEmailID2.Text == "")
            {
                MessageBox.Show("Please enter your Email");
                errorBelow18.SetError(this.txtEmailID2, "please enter Email");
                return;
            }
            if (txtContact2.Text == "")
            {
                MessageBox.Show("Please enter your Contact");
                errorBelow18.SetError(this.txtContact2, "please enter Contact");
                return;
            }
            if (txtSchoolName2.Text == "")
            {
                MessageBox.Show("Please enter your School Name");
                errorBelow18.SetError(this.txtSchoolName2, "please enter School Name");
                return;
            }
            if (cmbbxCountry2.Text == "")
            {
                MessageBox.Show("select The Country");
                errorBelow18.SetError(this.cmbbxCountry2, "select The Country");

                return;
            }
            if (cmbbxState2.Text == "")
            {
                MessageBox.Show("select The State");
                errorBelow18.SetError(this.cmbbxState2, "select The State");

                return;
            }
            if (cmbbxCity2.Text == "")
            {
                MessageBox.Show("select The City");
                errorBelow18.SetError(this.cmbbxCity2, "select The City");

                return;
            }
            if (txtFamilyIncome2.Text == "")
            {
                MessageBox.Show("Please Enter Family Income ");
                errorBelow18.SetError(this.txtFamilyIncome2, "Please Enter Family Income");

                return;
            }
            if (txtEmailID2.Text == "")
            {
                MessageBox.Show("Please enter your Email");
                errorBelow18.SetError(this.txtEmailID2, "please enter Email");
                return;
            }
            if (txtPercentage2.Text == "")
            {
                MessageBox.Show("Please enter your Percentage");
                errorBelow18.SetError(this.txtPercentage2, "please enter percentage");
                return;
            }

            string studentid = lblStudentId2.Text;
            string firstname = txtStudentName2.Text;
            string middlename = txtFatherName2.Text;
            string lastname = txtLastName2.Text;
            string mothername = txtMotherName2.Text;
            string emailid = txtEmailID2.Text;
            string addressinfo = txtaddress.Text;
            string familyincome = txtFamilyIncome2.Text;
            string contact = txtContact2.Text;
            string schoolname = txtStudentName2.Text;
            decimal percentage = Convert.ToDecimal(txtPercentage2.Text);
            int cityid = Convert.ToInt32(cmbbxCity2.SelectedValue.ToString());



            clsAdmin obj = new clsAdmin(studentid,firstname, middlename,lastname,mothername,emailid,addressinfo,schoolname,familyincome,contact,percentage, cityid);
            obj.btnBUpdate();
            MessageBox.Show("Updated Successflly");
            this.Close();



        }

        private void cmbbxCountry2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(cmbbxCountry2.SelectedValue.ToString());


            clsAdmin obj = new clsAdmin(countryId);
            DataTable dt = new DataTable();
            dt = obj.State();
            cmbbxState2.DisplayMember = "StateName";
            cmbbxState2.ValueMember = "StateId";
            cmbbxState2.DataSource = dt;
            //cmbbxState2.ResetText();
        }

        private void cmbbxState2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stateId = Convert.ToInt32(cmbbxState2.SelectedValue.ToString());


            clsAdmin obj = new clsAdmin(stateId);
            DataTable dt = new DataTable();
            dt = obj.City();
            cmbbxCity2.DisplayMember = "CityName";
            cmbbxCity2.ValueMember = "CityId";
            cmbbxCity2.DataSource = dt;
            //cmbbxCity2.ResetText();
        }

        private void txtPercentage2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentName2_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$";
            if (Regex.IsMatch(txtStudentName2.Text, pattern))
            {
                errorBelow18.Clear();
            }
            else
            {
                errorBelow18.SetError(this.txtStudentName2, "Pleasw Enter First Name");
            }
        }

        private void txtLastName2_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$";
            if (Regex.IsMatch(txtLastName2.Text, pattern))
            {
                errorBelow18.Clear();
            }
            else
            {
                errorBelow18.SetError(this.txtLastName2, "Pleasw Enter Last Name");
            }
        }

        private void txtFatherName2_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$";
            if (Regex.IsMatch(txtFatherName2.Text, pattern))
            {
                errorBelow18.Clear();
            }
            else
            {
                errorBelow18.SetError(this.txtFatherName2, "Pleasw Enter Middle Name");
            }
        }

        private void txtMotherName2_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$";
            if (Regex.IsMatch(txtMotherName2.Text, pattern))
            {
                errorBelow18.Clear();
            }
            else
            {
                errorBelow18.SetError(this.txtMotherName2, "Pleasw Enter Mother Name");
            }
        }

        private void txtEmailID2_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(txtEmailID2.Text, pattern))
            {
                errorBelow18.Clear();
            }
            else
            {
                errorBelow18.SetError(this.txtEmailID2, "Please provide valid Mail Address");
                return;
            }
        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$/-";
            if (Regex.IsMatch(txtaddress.Text, pattern))
            {
                errorBelow18.Clear();
            }
            else
            {
                errorBelow18.SetError(this.txtaddress, "Pleasw Enter Valid Address");
            }
        }

        private void txtContact2_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(txtContact2.Text, pattern))
            {
                errorBelow18.Clear();
            }
            else
            {
                errorBelow18.SetError(this.txtContact2, "Please Provide Enter Valid Contact");
                return;
            }
        }

        private void txtFamilyIncome2_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{6}$";

            if (Regex.IsMatch(txtFamilyIncome2.Text, pattern))
            {
                errorBelow18.Clear();
            }
            else
            {
                errorBelow18.SetError(this.txtFamilyIncome2, "Please Enter Family Income");
                return;
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSchoolName2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

