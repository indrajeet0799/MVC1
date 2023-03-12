using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;


namespace Testmgt
{
    public partial class FrmStudentRegistration : Form
    {



        public FrmStudentRegistration()
        {
            InitializeComponent();
        }
          //-----------------------------COUNTRY NAME-----------------------------------//
        private void Form1_Load(object sender, EventArgs e)
        {
            clsAdmin obj = new clsAdmin();
            DataTable dt = new DataTable();
            dt = obj.Country();
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.ValueMember = "CountryId";
            cmbbxCountry.DataSource = dt;

            cmbbxCountry.ResetText();

            //------------------------AUTOINCREMENT STUDENTID'S----------------------------//

            SqlDataReader dr;
            dr = obj.StudentCode();
            while (dr.Read())
            {
                int StudentCode =Convert.ToInt32(dr["ID"].ToString());
                StudentCode = StudentCode + 1;
                string StudentID = "RTS";
                string code=StudentID + StudentCode;
                lblID.Text = code; 
            }
            dr.Close();
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void lblDOB_Click(object sender, EventArgs e)
        {
           

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void cmbbxCountry_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());
            clsAdmin obj = new clsAdmin(countryId);
            DataTable dt = new DataTable();
            dt = obj.State();
            cmbbxState.DisplayMember = "StateName";
            cmbbxState.ValueMember = "StateId";
            cmbbxState.DataSource = dt;

            cmbbxState.ResetText();
        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int stateId = Convert.ToInt32(cmbbxState.SelectedValue.ToString());
            clsAdmin obj = new clsAdmin(stateId);
            DataTable dt = new DataTable();
            dt = obj.City();
            cmbbxCity.DisplayMember = "CityName";
            cmbbxCity.ValueMember = "CityId";
            cmbbxCity.DataSource = dt;

            cmbbxCity.ResetText();
        }
        private void cmbbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "")
            {
                MessageBox.Show("Please enter FirstName");
                ErrorStudentRegistration.SetError(this.txtFirstname, "please enter FirstName");
                return;
            }

            if (txtMiddleName.Text == "")
            {
                MessageBox.Show("Please enter MiddleName");
                ErrorStudentRegistration.SetError(this.txtMiddleName, "please enter MiddleName");
                return;
            }


            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter LastName");
                ErrorStudentRegistration.SetError(this.txtLastName, "please enter LastName");
                return;
            }

            if ((rdbtnMale.Checked && rdbtnFemale.Checked))
            {
                MessageBox.Show("please select a gender..");
                ErrorStudentRegistration.SetError(this.lblGender, "please select gender");
                return;
            }

            if (txtContact.Text == "")
            {
                MessageBox.Show("please enter your contact no");
                ErrorStudentRegistration.SetError(this.txtContact, "please enter your contact no");
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your Email");
                ErrorStudentRegistration.SetError(this.txtEmail, "please enter Email");
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter Address");
                ErrorStudentRegistration.SetError(this.txtAddress, "please enter Address");
                return;
            }
            if (cmbbxCountry.Text == "")
            {
                MessageBox.Show("Please enter country");
                ErrorStudentRegistration.SetError(this.cmbbxCountry, "please enter country");
                return;
            }
            if (cmbbxState.Text == "")
            {
                MessageBox.Show("Please enter state");
                ErrorStudentRegistration.SetError(this.cmbbxState, "please enter state");
                return;
            }
            if (cmbbxCity.Text == "")
            {
                MessageBox.Show("Please enter city");
                ErrorStudentRegistration.SetError(this.cmbbxCity, "please enter city");
                return;
            }
            if (txtPincode.Text == "")
            {
                MessageBox.Show("please enter your Pincode No");
                ErrorStudentRegistration.SetError(this.txtPincode, "please enter your pincode");
                return;
            }

            if (cmbbxFamilyType.Text == "")
            {
                MessageBox.Show("Please enter FamilyType");
                ErrorStudentRegistration.SetError(this.cmbbxFamilyType, "please enter FamilyType");
                return;
            }

            if (cmbbxSocialType.Text == "")
            {
                MessageBox.Show("Please enter SocialType");
                ErrorStudentRegistration.SetError(this.cmbbxSocialType, "please enter SocialType");
                return;
            }

            string StudentId = lblID.Text.ToString();
            string Firstname = txtFirstname.Text;
            string MiddleName = txtMiddleName.Text;
            string LastName = txtLastName.Text;
            
            string Gender = "";
            if(rdbtnMale.Checked)
            {
                Gender = rdbtnMale.Text;
            }
            if (rdbtnFemale.Checked)
            {
                Gender = rdbtnFemale.Text;
            }
            if(rdbtnOther.Checked)
            {
                Gender = rdbtnOther.Text;
            }
            DateTime DOB = Convert.ToDateTime(dateTimePicker1.Text);
            string EmailId = txtEmail.Text;
            string contact = txtContact.Text;
            string Address = txtAddress.Text;
            int Cityid = Convert.ToInt32(cmbbxCity.SelectedValue.ToString());
            int Pincode = Convert.ToInt32(txtPincode.Text);
            string MotherName = "";
            string Collage = "";
            string SchoolName ="";
            int qualificationId = 2;
            int MediumId = 1;
            decimal Percentage = 0;
            DateTime studentregistrationDate =System.DateTime.Now;
            int statusId = 4;
            string testTypeId = ",";
     //       DateTime testsubmitteddate = DateTime.Now;
            string familytype = cmbbxFamilyType.Text.ToString();
            string familyincome = txtIncome.Text;
            string cityname = cmbbxCity.Text.ToString();
            string statename = cmbbxState.Text.ToString();
            string countryname = cmbbxCountry.Text.ToString();
            int age1 = DateTime.Today.Year - dateTimePicker1.Value.Year;
            string STD = "0";
        //    string Type = cmbbxSocialType.Text.ToString();
            string socialtype =cmbbxSocialType.Text.ToString();
            int isdelete = 0;

            //bool isDelete = Convert.ToBoolean("0");



            clsAdmin objSaveReg = new clsAdmin(StudentId, Firstname,MiddleName,LastName,Gender, DOB, EmailId,contact, Address,Cityid,Pincode,MotherName, Collage, SchoolName, 
               qualificationId,MediumId, Percentage,studentregistrationDate,statusId,testTypeId,familytype,familyincome,age1,STD,socialtype, isdelete);
            objSaveReg.StudentRegistration();
            MessageBox.Show("Registered Sucessfully......!!!!");

          
           

            int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            if (age <= 18)
            {               
                SqlDataReader dr;
                dr = objSaveReg.StudentCode();
                while (dr.Read())
                {
                    int StudentCode = Convert.ToInt32(dr["ID"].ToString());
                    StudentCode = StudentCode + 1;
                    string StudentID = "RTS";
                    string code = StudentID + StudentCode;
                    lblID.Text = code;
                }
                dr.Close();
                              
                txtFirstname.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                txtPincode.Clear();
                txtAddress.Clear();
                txtContact.Clear();
                txtEmail.Clear();
                FrmBelow18 objBelow = new FrmBelow18(StudentId, Firstname, MiddleName, LastName, EmailId, contact, Address, cityname,
                 statename, countryname, Percentage,STD);
                objBelow.Show();
            }
            if (age >18)
            {
               
                
                SqlDataReader dr;
                dr = objSaveReg.StudentCode();
                while (dr.Read())
                {
                    int StudentCode = Convert.ToInt32(dr["ID"].ToString());
                    StudentCode = StudentCode + 1;
                    string StudentID = "RTS";
                    string code = StudentID + StudentCode;
                    lblID.Text = code;
                }
                dr.Close();
               
                txtFirstname.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                txtPincode.Clear();
                txtAddress.Clear();
                txtContact.Clear();
                txtEmail.Clear();
                FrmAbove18 objAd = new FrmAbove18(StudentId, Firstname, MiddleName, LastName, EmailId, contact, Address, cityname,
                   statename, countryname, Percentage);
                objAd.Show();
            }

        }

        


        private void txtbxFirstname_Enter(object sender, EventArgs e)
        {
            txtFirstname.Clear();
        }

        private void txtbxMiddleName_Enter(object sender, EventArgs e)
        {
            txtMiddleName.Clear();
        }

        private void txtbxLastName_Enter(object sender, EventArgs e)
        {
            txtLastName.Clear();
        }

        private void txtbxPincode_Enter(object sender, EventArgs e)
        {
            txtPincode.Clear();
        }

        private void txtbxFirstname_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";
            if(Regex.IsMatch(txtFirstname.Text,pattern))
            {
                ErrorStudentRegistration.Clear();
            }
            else
            {
                ErrorStudentRegistration.SetError(this.txtFirstname, "Please Enter First Name");
            }
        }

        private void txtbxMiddleName_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";
            if (Regex.IsMatch(txtMiddleName.Text, pattern))
            {
                ErrorStudentRegistration.Clear();
            }
            else
            {
                ErrorStudentRegistration.SetError(this.txtMiddleName, "Please Enter Middle Name");
            }
        }

        private void txtbxLastName_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";
            if (Regex.IsMatch(txtLastName.Text, pattern))
            {
                ErrorStudentRegistration.Clear();
            }
            else
            {
                ErrorStudentRegistration.SetError(this.txtLastName, "Please Enter Last Name");
            }
        }

        private void lblGender_Click(object sender, EventArgs e)
        {
            if (!(this.rdbtnMale.Checked || this.rdbtnFemale.Checked))

            {
                MessageBox.Show("Select Gender");
                return;
            }

        }

        private void txtbxContact_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{1}[0-9]{9}$";
           

            if (Regex.IsMatch(txtContact.Text, pattern))
            {
                ErrorStudentRegistration.Clear();
            }
            else
            {
                ErrorStudentRegistration.SetError(this.txtContact, "Please Enter Valid Contact");
                return;
            }

        }
        private void lblEnailID_Click(object sender, EventArgs e)
        {
           
        }

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA]\\.)+[a-zA-Z]{2,9})$";


            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                ErrorStudentRegistration.Clear();
            }
            else
            {
                ErrorStudentRegistration.SetError(this.txtEmail, "Please Enter valid Mail address");
                return;
            }
        }

        private void cmbbxCountry_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtbxStudentId_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void txtbxAddress_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$/-,";
            if (Regex.IsMatch(txtAddress.Text, pattern))
            {
                ErrorStudentRegistration.Clear();
            }
            else
            {
                ErrorStudentRegistration.SetError(this.txtAddress, "Please Enter Valid Address");
            }
        }

        private void txtbxPincode_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{6}$";

            if (Regex.IsMatch(txtPincode.Text, pattern))
            {
                ErrorStudentRegistration.Clear();
            }
            else
            {
                ErrorStudentRegistration.SetError(this.txtPincode, "Please Enter Valid Pincode");
                return;
            }
        }

        private void txtbxStudentId_Enter_1(object sender, EventArgs e)
        {
            
            
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxFamilyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-6]{6}$";

            if (Regex.IsMatch(txtIncome.Text, pattern))
            {
                ErrorStudentRegistration.Clear();
            }
            else
            {
                ErrorStudentRegistration.SetError(this.txtIncome, "Please Enter FamilyIncome");
                return;
            }
        }
    }
}
