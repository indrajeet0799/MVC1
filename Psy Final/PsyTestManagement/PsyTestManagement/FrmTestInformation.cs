using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Client;

namespace PsyTestManagement
{
    public partial class FrmTestInformation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4MS3KTQO;Initial Catalog=TestManagement;Integrated Security=True");
        int pos = 0;
        string StudentId = null;
        string TestPaperName = null;
        int  TotalMarks = 0;
        string Duration = null;
        public int TESTPAPERID { get; set; }

        public FrmTestInformation()
        {
            InitializeComponent();
        }
        public FrmTestInformation(int testpaperid,string papername)
        {
            InitializeComponent();
            TESTPAPERID = testpaperid;
            lblTestPaper.Text = papername;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FrmStartTest fst = new FrmStartTest(lblTest.Text);
            //pos=pos+1;

            //ClsAdmin objQuestion = new ClsAdmin();
            //DataTable dt = new DataTable();
            //dt = objQuestion.GetTest();
            //lblTest.Text=dt.Rows[pos][0].ToString();
            //lblMarks.Text=dt.Rows[pos][2].ToString();
            //lblDuration.Text=dt.Rows[pos][1].ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStartTset_Click(object sender, EventArgs e)
        {

            string studentid = txtStudId.Text;

            clsClient obj = new clsClient(studentid);
            SqlDataReader dr;
            dr = obj.GetID();
            while (dr.Read())
            {
                StudentId = (dr["StudentId"].ToString());
                if (studentid == StudentId)
                {
                    FrmStartTest objfrmStartTest = new FrmStartTest(StudentId, TESTPAPERID);
                    objfrmStartTest.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter correct Input");
                }
            }
        }   


        

        private void txtStudId_Leave(object sender, EventArgs e)
        {
            string pattern = "[^(A-Z)]{3}-[0-9]{3}";
            if (Regex.IsMatch(txtStudId.Text, pattern)==true)
            {
                errorProvider1.Clear();
                string studentid = txtStudId.Text;

                clsClient obj = new clsClient(studentid);
                SqlDataReader dr;
                dr = obj.GetID();
                while (dr.Read())
                {
                     StudentId = (dr["StudentId"].ToString());
                    if(studentid == StudentId)
                    {
                        FrmStartTest objfrmStartTest = new FrmStartTest(StudentId, TESTPAPERID);
                        objfrmStartTest.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter correct Input");
                    }
                    
                }

            }
            else
            {
                
                errorProvider1.SetError(this.txtStudId, "Please provide your valid ID....!");
                this.txtStudId.Focus();
                return;
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}


    


