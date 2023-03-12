

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;

namespace PsyTestManagement
{
    public partial class FrmAbove18 : Form
    {
        public FrmAbove18(string studentid,string firstname,string middlename,string lastname,string emailid,string contact, string address,string CollageName,decimal percentage,string familyimcome)
        {
            InitializeComponent();
            lblStudentID1.Text = studentid;
            txtFirstName1.Text = firstname;
            txtmiddlename1.Text = middlename;
            txtLastName1.Text=lastname;
            txtEmail1.Text = emailid;
            txtContact1.Text = contact;
            txtaddress.Text = address;
            txtCollageName2.Text = CollageName;
            txtbxFamilyIncome1.Text = familyimcome;
            txtPercentage1.Text = percentage.ToString();    
            //SuggestedTest1.Text = testtypeid.ToString();
        }

        

        private void FrmAbove18_Load(object sender, EventArgs e)
        {

            clsAdmin objC = new clsAdmin();
            DataTable dtC = new DataTable();
            dtC =  objC.Country();
            cmbbxCountry1.DisplayMember = "CountryName";
            cmbbxCountry1.ValueMember = "CountryId";
            cmbbxCountry1.DataSource = dtC;
            cmbbxCountry1.ResetText();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (txtFirstName1.Text == "")
            {
                MessageBox.Show("Please enter First Name");
                errorAbove18.SetError(this.txtFirstName1, "please enter First Name");
                return;
            }
            if (txtLastName1.Text == "")
            {
                MessageBox.Show("Please enter Last Name");
                errorAbove18.SetError(this.txtLastName1, "please enter Last Name");
                return;
            }
            if (txtmiddlename1.Text == "")
            {
                MessageBox.Show("Please enter Middle Name");
                errorAbove18.SetError(this.txtmiddlename1, "please enter Middle Name");
                return;
            }
           
            if (txtaddress.Text == "")
            {
                MessageBox.Show("Please enter Address");
                errorAbove18.SetError(this.txtaddress, "please enter Address");
                return;
            }
            if (txtEmail1.Text == "")
            {
                MessageBox.Show("Please enter your Email");
                errorAbove18.SetError(this.txtEmail1, "please enter Email");
                return;
            }
            if (txtCollageName2.Text == "")
            {
                MessageBox.Show("Please enter your School Name");
                errorAbove18.SetError(this.txtCollageName2, "please enter School Name");
                return;
            }
            if (txtContact1.Text == "")
            {
                MessageBox.Show("Please enter your Contact");
                errorAbove18.SetError(this.txtContact1, "please enter Contact");
                return;
            }
            
            if (cmbbxCountry1.Text == "")
            {
                MessageBox.Show("select The Country");
                errorAbove18.SetError(this.cmbbxCountry1, "select The Country");

                return;
            }
            if (cmbbxState1.Text == "")
            {
                MessageBox.Show("select The State");
                errorAbove18.SetError(this.cmbbxState1, "select The State");

                return;
            }
            if (cmbbxCity1.Text == "")
            {
                MessageBox.Show("select The City");
                errorAbove18.SetError(this.cmbbxCity1, "select The City");

                return;
            }
            if (txtbxFamilyIncome1.Text == "")
            {
                MessageBox.Show("Please Enter Family Income ");
                errorAbove18.SetError(this.txtbxFamilyIncome1, "Please Enter Family Income");

                return;
            }
            if (txtPercentage1.Text == "")
            {
                MessageBox.Show("Please enter your Percentage");
                errorAbove18.SetError(this.txtPercentage1, "please enter percentage");
                return;
            }

            string studentid = lblStudentID1.Text;
            string firstname = txtFirstName1.Text;
            string middlename = txtmiddlename1.Text;
            string lastname = txtLastName1.Text;
            int cityid = Convert.ToInt32(cmbbxCity1.SelectedValue.ToString());
            string emailid = txtEmail1.Text;
            string addressinfo = txtaddress.Text;
            string collagename = txtCollageName2.Text;
            string familyincome = txtbxFamilyIncome1.Text;
            string contactno = txtContact1.Text;
            decimal percentage = Convert.ToDecimal(txtPercentage1.Text.ToString());



            clsAdmin obj = new clsAdmin(studentid,firstname,middlename, lastname, emailid,addressinfo, collagename, familyincome,contactno,percentage,cityid);
            obj.btnAUpdate();
            MessageBox.Show("Updated Successflly");
            this.Close();
        }

        private void SuggestedTest1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbbxState1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int stateId = Convert.ToInt32(cmbbxState1.SelectedValue.ToString());


            clsAdmin obj = new clsAdmin(stateId);
            DataTable dt = new DataTable();
            dt = obj.City();
            cmbbxCity1.DisplayMember = "CityName";
            cmbbxCity1.ValueMember = "CityId";
            cmbbxCity1.DataSource = dt;
            cmbbxCity1.ResetText();
        }

        private void cmbbxCountry1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(cmbbxCountry1.SelectedValue.ToString());


            clsAdmin obj = new clsAdmin(countryId);
            DataTable dt = new DataTable();
            dt = obj.State();
            cmbbxState1.DisplayMember = "StateName";
            cmbbxState1.ValueMember = "StateId";
            cmbbxState1.DataSource = dt;
           cmbbxState1.ResetText();
        }

        private void txtPercentage1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxFamilyType1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxFamilyIncome1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentName1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$";
            if (Regex.IsMatch(txtFirstName1.Text, pattern))
            {
                errorAbove18.Clear();
            }
            else
            {
                errorAbove18.SetError(this.txtFirstName1, "Pleasw Enter First Name");
            }
        }

        private void txtmiddlename_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$";
            if (Regex.IsMatch(txtmiddlename1.Text, pattern))
            {
                errorAbove18.Clear();
            }
            else
            {
                errorAbove18.SetError(this.txtmiddlename1, "Pleasw Enter Middle Name");
            }
        }

        private void txtLastName1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$";
            if (Regex.IsMatch(txtLastName1.Text, pattern))
            {
                errorAbove18.Clear();
            }
            else
            {
                errorAbove18.SetError(this.txtLastName1, "Pleasw Enter Last Name");
            }
        }

        private void txtContact1_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(txtContact1.Text, pattern))
            {
                errorAbove18.Clear();
            }
            else
            {
                errorAbove18.SetError(this.txtFirstName1, "Please Provide Enter Valid Contact");
                return;
            }
        }

        private void txtEmail1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(txtEmail1.Text, pattern))
            {
                errorAbove18.Clear();
            }
            else
            {
                errorAbove18.SetError(this.txtEmail1, "Please provide valid Mail Address");
                return;
            }
        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$/-";
            if (Regex.IsMatch(txtaddress.Text, pattern))
            {
                errorAbove18.Clear();
            }
            else
            {
                errorAbove18.SetError(this.txtaddress, "Pleasw Enter Valid Address");
            }
        }

        private void txtCollageName2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
