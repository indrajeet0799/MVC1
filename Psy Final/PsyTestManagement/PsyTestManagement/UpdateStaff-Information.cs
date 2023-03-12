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
    public partial class frmUpdateStaff_Information : Form
    {
        public frmUpdateStaff_Information(int staffid,string StaffName, Int64 contactNo, string emailid, string addressinf,string pincode)
        {
            InitializeComponent();
            lblStaff_ID.Text = staffid.ToString();
            txtStaffName1.Text=StaffName;
            txtPhoneNo1.Text = contactNo.ToString();
            txtEmailID1.Text = emailid;
            txtAddressInf1.Text = addressinf;
           // cmbbxCity1.Text = cityNmae.ToString();
            txtPinCode1.Text = pincode.ToString();
        }

        private void grpbxStaffInfo2_Enter(object sender, EventArgs e)
        {
            clsAdmin objshop = new clsAdmin();
            DataTable dt = new DataTable();
            dt = objshop.Country();
            cmbbxCountry1.DisplayMember = "CountryName";
            cmbbxCountry1.ValueMember = "CountryId";

            cmbbxCountry1.DataSource = dt;

        }

        private void cmbbxCountry1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(cmbbxCountry1.SelectedValue.ToString());
            clsAdmin objshop = new clsAdmin(countryId);
            DataTable dt = new DataTable();
            dt = objshop.State();
            cmbbxState1.DisplayMember = "StateName";
            cmbbxState1.ValueMember = "StateId";

            cmbbxState1.DataSource = dt;
        }

        private void cmbbxState1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int StateId = Convert.ToInt32(cmbbxState1.SelectedValue.ToString());
            clsAdmin objshop = new clsAdmin(StateId);
            DataTable dt = new DataTable();
            dt = objshop.City();
            cmbbxCity1.DisplayMember = "CityName";
            cmbbxCity1.ValueMember = "CityId";

            cmbbxCity1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateStaff_Information_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cmbbxStaffPosition1.Text == "")
            {
                MessageBox.Show("select The Staff Position");
                updateerrorProvider1.SetError(this.cmbbxStaffPosition1, "select The Staff Position");

                return;
            }
            if (txtStaffName1.Text == "")
            {
                MessageBox.Show("Please enter StaffName");
                updateerrorProvider1.SetError(this.txtStaffName1, "please enter StaffName");
                return;
            }
            if (txtPhoneNo1.Text == "")
            {
                MessageBox.Show("please enter your contact no");
                updateerrorProvider1.SetError(this.txtPhoneNo1, "please enter your contact no");
                return;
            }
            if (txtEmailID1.Text == "")
            {
                MessageBox.Show("Please enter your Email");
                updateerrorProvider1.SetError(this.txtEmailID1, "please enter Email");
                return;
            }
            if (txtAddressInf1.Text == "")
            {
                MessageBox.Show("Please enter Address");
                updateerrorProvider1.SetError(this.txtAddressInf1, "please enter Address");
                return;
            }
            if (cmbbxCountry1.Text == "")
            {
                MessageBox.Show("Please enter country");
                updateerrorProvider1.SetError(this.cmbbxCountry1, "please enter country");
                return;
            }
            if (cmbbxState1.Text == "")
            {
                MessageBox.Show("Please enter state");
                updateerrorProvider1.SetError(this.cmbbxState1, "please enter state");
                return;
            }
            if (cmbbxCity1.Text == "")
            {
                MessageBox.Show("Please enter city");
                updateerrorProvider1.SetError(this.cmbbxCity1, "please enter city");
                return;
            }
            if (txtPinCode1.Text == "")
            {
                MessageBox.Show("please enter your Pincode No");
                updateerrorProvider1.SetError(this.txtPinCode1, "please enter your pincode");
                return;
            }







            int Staffid = Convert.ToInt32(lblStaff_ID.Text);
            string StaffPosition = cmbbxStaffPosition1.SelectedItem.ToString();
            string fullname = txtStaffName1.Text;
            Int64 Contactno = Convert.ToInt64(txtPhoneNo1.Text);
            string email = txtEmailID1.Text;
            string address = txtAddressInf1.Text;
           int cityid = Convert.ToInt32(cmbbxCity1.SelectedValue.ToString());
            int pincode = Convert.ToInt32(txtPinCode1.Text);
            clsAdmin obj = new clsAdmin(Staffid,StaffPosition,fullname,Contactno,email,address,cityid,pincode);
            obj.btnUpdate();
            MessageBox.Show("Update successfully");
            this.Close();

        }

        private void lblContact1_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxStaffPosition1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxStaffPosition1.SelectedText))
            {
                updateerrorProvider1.Clear();
            }
            else
            {
                updateerrorProvider1.SetError(this.cmbbxStaffPosition1, "select Staffposition");
                return;
            }
        }

        private void cmbbxCity1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStaffName1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";
            if (Regex.IsMatch(txtStaffName1.Text, pattern))
            {
                updateerrorProvider1.Clear();
            }
            else
            {
                updateerrorProvider1.SetError(this.txtStaffName1, "Type FullName Staff");
                return;
            }
        }

        private void txtEmailID1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmailID1.Text, pattern))
            {
                updateerrorProvider1.Clear();
            }
            else
            {
                updateerrorProvider1.SetError(this.txtEmailID1, "please enter valid email");
                return;
            }
        }

        private void txtPhoneNo1_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[7-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(txtPhoneNo1.Text, pattern))
            {
                updateerrorProvider1.Clear();
            }

            else
            {
                updateerrorProvider1.SetError(this.txtPhoneNo1, "please enter your correct contact no");
                return;
            }
        }

        private void txtAddressInf1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$/-,";
            if (Regex.IsMatch(txtAddressInf1.Text, pattern))
            {
                updateerrorProvider1.Clear();
            }
            else
            {
                updateerrorProvider1.SetError(this.txtAddressInf1, "Type Address Information");
                return;
            }
        }

        private void txtPinCode1_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-6]{6}$";
            if (Regex.IsMatch(txtPinCode1.Text, pattern))
            {
                updateerrorProvider1.Clear();
            }
            else
            {
                updateerrorProvider1.SetError(this.txtPinCode1, "please enter your correct pincode no");
                return;
            }
        }
    }
}
