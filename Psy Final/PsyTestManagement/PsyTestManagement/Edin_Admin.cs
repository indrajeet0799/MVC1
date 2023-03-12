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

namespace PsyTestManagement
{
    public partial class frmEditAdmin : Form
    {
        public frmEditAdmin(string StaffName,string Contact,string EmailID,string Address,int Pincode)
        {
            InitializeComponent();
            txtStaffName1.Text = StaffName;
            txtPhoneNo1.Text = Contact;
            txtAddressInf1.Text = Address;
            txtPinCode1.Text = Pincode.ToString();
        }

        private void frmEdit_Admin_Load(object sender, EventArgs e)
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

        private void btnupdate_Click(object sender, EventArgs e)
        {           
            string fullname = txtStaffName1.Text;
            Int64 Contactno = Convert.ToInt64(txtPhoneNo1.Text);
            string address = txtAddressInf1.Text;
            int cityid = Convert.ToInt32(cmbbxCity1.SelectedValue.ToString());
            int pincode = Convert.ToInt32(txtPinCode1.Text);
            clsAdmin obj = new clsAdmin( fullname, Contactno, address, cityid, pincode);
            obj.UpdateProfile();
            MessageBox.Show("Update successfully");
            this.Close();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
