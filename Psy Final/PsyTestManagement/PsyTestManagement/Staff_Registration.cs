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
using TestManagement.Admin;

namespace PsyTestManagement
{
    public partial class frmStaff_Registration : Form
    {
        public frmStaff_Registration()
        {
            InitializeComponent();
        }

        private void grpbxStaffInfo1_Enter(object sender, EventArgs e)
        {
            clsAdmin objshop = new clsAdmin();
            DataTable dt = new DataTable();
            dt = objshop.Country();
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.ValueMember = "CountryId";

            cmbbxCountry.DataSource = dt;

            cmbbxCountry.ResetText();
        }
        
        private void cmbbxStaffPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxStaffPosition.SelectedText))
            {
                errorStaffReg.Clear();
            }
            else
            {
                errorStaffReg.SetError(this.cmbbxStaffPosition, "select Staffposition");
                return;
            }
        }

        private void txtPinCode_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-6]{6}$";
            if (Regex.IsMatch(txtPinCode.Text, pattern))
            {
                errorStaffReg.Clear();
            }
            else
            {
                errorStaffReg.SetError(this.txtPinCode, "please enter your correct pincode no");
                return;
            }
        }

        private void lblPinCode_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int StateId = Convert.ToInt32(cmbbxState.SelectedValue.ToString());
            clsAdmin objshop = new clsAdmin(StateId);
            DataTable dt = new DataTable();
            dt = objshop.City();
            cmbbxCity.DisplayMember = "CityName";
            cmbbxCity.ValueMember = "CityId";

            cmbbxCity.DataSource = dt;
            cmbbxCity.ResetText();
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());
            clsAdmin objshop = new clsAdmin(countryId);
            DataTable dt = new DataTable();
            dt = objshop.State();
            cmbbxState.DisplayMember = "StateName";
            cmbbxState.ValueMember = "StateId";

            cmbbxState.DataSource = dt;

           cmbbxState.ResetText();

        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void txtAddressInf_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$/-,";
            if (Regex.IsMatch(txtAddressInf.Text, pattern))
            {
                errorStaffReg.Clear();
            }
            else
            {
                errorStaffReg.SetError(this.txtAddressInf, "Type Address Information");
                return;
            }
        }

        private void dtpStaffReg_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*])";
            if (Regex.IsMatch(txtPassword.Text, pattern))
            {
                errorStaffReg.Clear();
            }
            else
            {
                errorStaffReg.SetError(this.txtPassword, "enter  your password");
                return;
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbbxStaffPosition.Text == "")
            {
                MessageBox.Show("select The Staff Position");
                errorStaffReg.SetError(this.cmbbxStaffPosition, "select The Staff Position");
                
                return;
            }
            if (txtStaffName.Text == "")
            {
                MessageBox.Show("Please enter StaffName");
                errorStaffReg.SetError(this.txtStaffName, "please enter StaffName");
                return;
            }
            if ((rdbbtnMale.Checked && rdbbtnFemale.Checked))
            {
                MessageBox.Show("please select a gender..");
                errorStaffReg.SetError(this.lblGender, "please select gender");
                return;
            }

            if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("please enter your contact no");
                errorStaffReg.SetError(this.txtPhoneNo, "please enter your contact no");
                return;
            }
            if (txtEmailID.Text == "")
            {
                MessageBox.Show("Please enter your Email");
                errorStaffReg.SetError(this.txtEmailID, "please enter Email");
                return;
            }
            if (txtAddressInf.Text == "")
            {
                MessageBox.Show("Please enter Address");
                errorStaffReg.SetError(this.txtAddressInf, "please enter Address");
                return;
            }
            if (cmbbxCountry.Text == "")
            {
                MessageBox.Show("Please enter country");
                errorStaffReg.SetError(this.cmbbxCountry, "please enter country");
                return;
            }
            if (cmbbxState.Text == "")
            {
                MessageBox.Show("Please enter state");
                errorStaffReg.SetError(this.cmbbxState, "please enter state");
                return;
            }
            if (cmbbxCity.Text == "")
            {
                MessageBox.Show("Please enter city");
                errorStaffReg.SetError(this.cmbbxCity, "please enter city");
                return;
            }
            if (txtPinCode.Text == "")
            {
                MessageBox.Show("please enter your Pincode No");
                errorStaffReg.SetError(this.txtPinCode, "please enter your pincode");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your Password");
                errorStaffReg.SetError(this.txtPassword, "please enter your Password");
                return;
            }
            string StaffPosition = cmbbxStaffPosition.SelectedItem.ToString();
            string staffinf=txtStaffName.Text;
            string Gender = "";
            if(rdbbtnMale.Checked)
            {
                Gender = rdbbtnMale.Text;
            }
            if (rdbbtnFemale.Checked)
            {
                Gender = rdbbtnFemale.Text;
            }
            if (rdbbtnOther.Checked)
              {
                Gender= rdbbtnOther.Text;   
              }  
            Int64 Contactno = Convert.ToInt64(txtPhoneNo.Text);
            string emailid = txtEmailID.Text;
            DateTime Orderdate = DateTime.Now;
            DateTime Odate = (Orderdate);
            string address=txtAddressInf.Text;
           // string StaffPosition = cmbbxStaffPosition.SelectedItem.ToString();
            int cityid=Convert.ToInt32(cmbbxCity.SelectedValue.ToString());
            int pincode= Convert.ToInt32(txtPinCode.Text);
            int statusid = 1;
            string password=txtPassword.Text;
            int isdelete = 0;

            clsAdmin obj = new clsAdmin(StaffPosition, staffinf, Contactno, emailid, Gender, address, cityid, pincode, statusid, password, Orderdate, isdelete);
            obj.SaveStaffinformation();
            MessageBox.Show("Save SuccessFully");

            this.Close();

        }
        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
             string pattern = @"^[7-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(txtPhoneNo.Text, pattern))
            {
                errorStaffReg.Clear();
            }
            
            else
            {
                errorStaffReg.SetError(this.txtPhoneNo, "please enter your correct contact no");
                return;
            }
        }
        private void txtEmailID_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmailID.Text, pattern))
            {
               errorStaffReg.Clear();
            }
            else
            {
                errorStaffReg.SetError(this.txtEmailID, "please enter valid email");
                return;
            }
        }
        private void rdbbtnOther_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdbbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rdbbtnMale_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";
            if (Regex.IsMatch(txtStaffName.Text, pattern))
            {
                errorStaffReg.Clear();
            }
            else
            {
                errorStaffReg.SetError(this.txtStaffName, "Type FullName Staff");
                return;
            }
        }
        private void lblGender_Click(object sender, EventArgs e)
        {
            if (!(rdbbtnMale.Checked && rdbbtnFemale.Checked))
            {
                errorStaffReg.SetError(this.lblGender, "select A gender !....");
                return;
            }
           
        }

        private void txtStaffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;
            //if(char.IsLetter(ch)==true)
            //{
            //    e.Handled = false;
            //}
            //else if (ch==8)
            //{
            //    e.Handled = false;
            //}
            //else if (ch == 32)
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void lblStaffPosition_Click(object sender, EventArgs e)
        {

        }
    }
}
