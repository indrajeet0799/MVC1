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
using System.Reflection.Emit;
using TestManagement;

namespace PsyTestManagement
{
    public partial class frmNewTestPaper : Form
    {
        public int temp { get; set; }
        public int TestPaperId = 0;


        public frmNewTestPaper()
        {
            InitializeComponent();

        }
        public frmNewTestPaper(int testpaperid, int temp)
        {
            InitializeComponent();
            grpbx.Visible = true;
            btnSubmit.Visible=true;
            btnNext.Visible = false;
            TestPaperId = testpaperid;
            this.temp = temp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clsAdmin objTest = new clsAdmin();
            DataTable dt2 = new DataTable();
            dt2 = objTest.GetTestType();
            cmbbxTestType.DisplayMember = "TestType";
            cmbbxTestType.ValueMember = "TestTypeId";
            cmbbxTestType.DataSource = dt2;



            clsAdmin objStatus = new clsAdmin();
            DataTable dt1 = new DataTable();
            dt1 = objStatus.GetStatus();
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DataSource = dt1;
            if (temp == 0)
            {
               
                clsAdmin obj1 = new clsAdmin(Convert.ToInt32(TestPaperId));
                SqlDataReader dr;
                dr = obj1.GetTestPaperDetails();
                while (dr.Read())
                {
                    txtTestPaper.Text = dr["TestPaperName"].ToString();
                    txtDuration.Text = dr["Duration"].ToString();
                    txtMarks.Text = dr["TotalMarks"].ToString();
                    cmbbxStatus.Text = dr["Status"].ToString();

                }
                dr.Close();
               
            }
        }

        private void cmbbxTestType_SelectedIndexChanged(object sender, EventArgs e)
        {

            int testtypeId = Convert.ToInt32(cmbbxTestType.SelectedValue.ToString());
            clsAdmin objTest = new clsAdmin(testtypeId);
            DataTable dt = new DataTable();
            dt = objTest.GetTestPaperbyType();
            cmbbxTestPaper.DisplayMember = "TestPaperName";
            cmbbxTestPaper.ValueMember = "TestPaperId";
            cmbbxTestPaper.DataSource = dt;

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddTestType obj = new frmAddTestType();
            obj.Show();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            grpbx.Visible = true;
            btnNext.Visible = true;
        }

        public void btnAddQue_Click(object sender, EventArgs e)
        {
            int isdelete = 0;
            if (txtTestPaper.Text == "")
            {
                MessageBox.Show("Please enter Test Paper Name");
                errorProvider1.SetError(this.txtTestPaper, "Please enter Test Paper Name");
                return;
            }
            if (txtDuration.Text == "")
            {
                MessageBox.Show("Please enter Duration of Paper");
                errorProvider1.SetError(this.txtDuration, "Please enter Duration of Paper");
                return;
            }
            if (txtMarks.Text == "")
            {
                MessageBox.Show("Please enter Marks");
                errorProvider1.SetError(this.txtMarks, "Please enter Marks");
                return;
            }
            if (cmbbxStatus.Text == "")
            {
                MessageBox.Show("Please select status");
                errorProvider1.SetError(this.cmbbxStatus, "Please select status");
                return;
            }
            else if (txtTestPaper.Text != "" && txtDuration.Text != "" && txtMarks.Text != "")
            {
                int TestTypeId = Convert.ToInt32(cmbbxTestType.SelectedValue.ToString());
                int TotalMarks = Convert.ToInt32(txtMarks.Text);
                int StatusId = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());

                clsAdmin objTest = new clsAdmin(txtTestPaper.Text, TestTypeId, txtDuration.Text,  TotalMarks, StatusId,isdelete);
                objTest.SaveTestPaper();

                string TestTypeName = cmbbxTestType.SelectedItem.ToString();


                frmAddQue obj = new frmAddQue(TestTypeName, txtTestPaper.Text);
                obj.Show();
            }
            else
            {
                MessageBox.Show("Please fill all Test Paper Details");
            }


        }

        private void cmbbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxStatus.SelectedText))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.cmbbxStatus, "Please select status.");
                return;
            }

        }
        private void cmbbxTestPaper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxTestPaper.SelectedItem != "")
            {
                int testpaperid = Convert.ToInt32(cmbbxTestPaper.SelectedValue.ToString());
            }

        }

        private void txtTestPaper_TextChanged(object sender, EventArgs e)
        {



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            grpbx.Visible = true;
        }




        private void txtTestPaper_Leave(object sender, EventArgs e)
        {
            if (txtTestPaper.Text == "")
            {
                txtTestPaper.Text = "Test Paper Name";
            }
        }

        private void txtTestPaper_Enter(object sender, EventArgs e)
        {
            if (txtTestPaper.Text == "Test Paper Name")
            {
                txtTestPaper.Text = "";
            }
        }

        private void txtDuration_Enter(object sender, EventArgs e)
        {
            if (txtDuration.Text == "Duration")
            {
                txtDuration.Text = "";
            }
        }

        private void txtDuration_Leave(object sender, EventArgs e)
        {
            if (txtDuration.Text == "")
            {
                txtDuration.Text = "Duration";
            }
        }

        private void txtMarks_Enter(object sender, EventArgs e)
        {
            if (txtMarks.Text == "Marks")
            {
                txtMarks.Text = "";
            }
        }

        private void txtMarks_Leave(object sender, EventArgs e)
        {
            if (txtMarks.Text == "")
            {
                txtMarks.Text = "Marks";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTestPaper.Text == "")
            {
                MessageBox.Show("Please enter Test Paper Name");
                errorProvider1.SetError(this.txtTestPaper, "Please enter Test Paper Name");
                return;
            }
            if (txtDuration.Text == "")
            {
                MessageBox.Show("Please enter Duration of Paper");
                errorProvider1.SetError(this.txtDuration, "Please enter Duration of Paper");
                return;
            }
            if (txtMarks.Text == "")
            {
                MessageBox.Show("Please enter Marks");
                errorProvider1.SetError(this.txtMarks, "Please enter Marks");
                return;
            }
            if (cmbbxStatus.Text == "")
            {
                MessageBox.Show("Please select status");
                errorProvider1.SetError(this.cmbbxStatus, "Please select status");
                return;
            }
            int StatusId = Convert.ToInt32(cmbbxStatus.SelectedValue);
            clsAdmin objedit = new clsAdmin(txtTestPaper.Text, txtDuration.Text, Convert.ToInt32(txtMarks.Text), StatusId, TestPaperId);
            objedit.EditTestPaper();
            MessageBox.Show("Your Question Paper Update Successfully");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void tnRefresh_Click(object sender, EventArgs e)
        {
            clsAdmin objTest = new clsAdmin();
            DataTable dt2 = new DataTable();
            dt2 = objTest.GetTestType();
            cmbbxTestType.DisplayMember = "TestType";
            cmbbxTestType.ValueMember = "TestTypeId";
            cmbbxTestType.DataSource = dt2;
        }
    }
    }
    
    
    

