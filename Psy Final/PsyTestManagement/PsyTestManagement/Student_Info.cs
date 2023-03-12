using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Cache;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PsyTestManagement
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }
        private void frmStudent_Info_Load(object sender, EventArgs e)
        {           
            clsAdmin objB = new clsAdmin();
            DataTable dtB = new DataTable();
            dtB = objB.above18gridview();
            grdStudentInfo.DataSource = dtB;
            grdStudentInfo.Show();
            buttons();

            grdStudentInfo.Columns["RegistrationId"].Visible = false;
            grdStudentInfo.Columns["SchoolName"].Visible = false;
            grdStudentInfo.Columns["MotherName"].Visible = false;
            grdStudentInfo.Columns["CollageName"].Visible = false;
            grdStudentInfo.Columns["FamilyIncome"].Visible = false;
            grdStudentInfo.Columns["Percentage"].Visible = false;
            grdStudentInfo.Columns["STD"].Visible = false;
     //       grdStudentInfo.Columns["Qualification"].Visible = false;
            grdStudentInfo.Columns["StudentRegistrationDate"].Visible = false;
            grdStudentInfo.Columns["AddressInfo"].Visible = false;

            grdStudentInfo.Visible = true;
        }


        private void grdStudent_Info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RegistrationID = Convert.ToInt32(this.grdStudentInfo.CurrentRow.Cells[2].Value.ToString());
            string StudentID = this.grdStudentInfo.CurrentRow.Cells[3].Value.ToString();
            string FN = this.grdStudentInfo.CurrentRow.Cells[4].Value.ToString();
            string Gender = this.grdStudentInfo.CurrentRow.Cells[5].Value.ToString();
            string EmailID = this.grdStudentInfo.CurrentRow.Cells[6].Value.ToString();
            string Contact = this.grdStudentInfo.CurrentRow.Cells[7].Value.ToString();
            string Address = this.grdStudentInfo.CurrentRow.Cells[8].Value.ToString();
        //    string cityname = this.grdStudentInfo.CurrentRow.Cells[9].Value.ToString();
            string mothername = this.grdStudentInfo.CurrentRow.Cells[9].Value.ToString();
            string STD = this.grdStudentInfo.CurrentRow.Cells[10].Value.ToString();
            string schoolname = this.grdStudentInfo.CurrentRow.Cells[11].Value.ToString();
      //      string Qualification = this.grdStudentInfo.CurrentRow.Cells[13].Value.ToString();
            string collagename = this.grdStudentInfo.CurrentRow.Cells[12].Value.ToString();
            DateTime StudentRegistrationdate = DateTime.Parse(this.grdStudentInfo.CurrentRow.Cells[13].Value.ToString());
            int age = Convert.ToInt32(this.grdStudentInfo.CurrentRow.Cells[14].Value.ToString());
            decimal percentage = Convert.ToDecimal(this.grdStudentInfo.CurrentRow.Cells[15].Value.ToString());
            string familyincome = this.grdStudentInfo.CurrentRow.Cells[16].Value.ToString();


            var FullName = FN;
            char[] seperator = { ' ' };
            string[] fullname = null;                   
            fullname = FullName.Split(seperator); 

            string first = fullname[0];
            string middle = fullname[1];
            string last = fullname[2];

            DateTime DOB = DateTime.Now;
           
            
            if (e.ColumnIndex == 0)
            {
                if (age < 18)
                {
                    FrmBelow18 ObjB = new FrmBelow18(StudentID, first, middle, last, mothername, EmailID, Contact, Address, schoolname, percentage, familyincome);
                    ObjB.Show();
                }


                else if (age > 18)
                {
                    FrmAbove18 ObjA = new FrmAbove18(StudentID, first, middle, last, EmailID, Contact, Address, collagename, percentage, familyincome);
                    ObjA.Show();
                }
            }
            if (e.ColumnIndex == 1)
            {
                int isdelete = 1;
                int id = Convert.ToInt32(grdStudentInfo.Rows[e.RowIndex].Cells[2].Value.ToString());
                clsAdmin obj = new clsAdmin(id,isdelete);
                obj.ISDelete();
                grdStudentInfo.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Deleted Successfully");
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
                clsAdmin objA = new clsAdmin();
                DataTable dtA = new DataTable();
                dtA = objA.above18gridview();
                grdStudentInfo.DataSource = dtA;
                grdStudentInfo.Show();
                      
                clsAdmin objB = new clsAdmin();
                DataTable dtB = new DataTable();
                dtB = objB.below18gridview();
                grdStudentInfo.DataSource = dtB;
                grdStudentInfo.Show();           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void buttons()
        {
            DataGridViewImageColumn btn = new DataGridViewImageColumn();
            btn.HeaderText = "";
            grdStudentInfo.Columns.Add(btn);
            btn.Width = 25;
            btn.Image = Image.FromFile(Application.StartupPath+"/Resources/Edit.jpg");           
            btn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            btn.ToolTipText = "Edit";
            btn.Name = "btnEdit";
            btn.DisplayIndex = 15;

            DataGridViewImageColumn btn1 = new DataGridViewImageColumn();
            btn1.HeaderText = "";
            grdStudentInfo.Columns.Add(btn1);
            btn1.Width = 25;
            btn1.Image = Image.FromFile(Application.StartupPath + "/Resources/Delete.jpg");
            btn1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            btn1.ToolTipText = "Delete";
            btn1.Name = "btnDelete";
            btn1.DisplayIndex = 16;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clsAdmin objB = new clsAdmin();
            DataTable dtB = new DataTable();
            dtB = objB.below18gridview();
            grdStudentInfo.DataSource = dtB;
            grdStudentInfo.Show();

            grdStudentInfo.Columns["RegistrationId"].Visible = false;
    //        grdStudentInfo.Columns["Qualification"].Visible = false;
     //       grdStudentInfo.Columns["SchoolName"].Visible = false;
            grdStudentInfo.Columns["MotherName"].Visible = false;
            grdStudentInfo.Columns["CollageName"].Visible = false;
            grdStudentInfo.Columns["FamilyIncome"].Visible = false;
            grdStudentInfo.Columns["Percentage"].Visible = false;
            //       grdStudentInfo.Columns["STD"].Visible = false;
            grdStudentInfo.Columns["StudentRegistrationDate"].Visible = false;
            grdStudentInfo.Columns["AddressInfo"].Visible = false;
        }

        private void btnAbove18Fetch_Click(object sender, EventArgs e)
        {
            clsAdmin objB = new clsAdmin();
            DataTable dtB = new DataTable();
            dtB = objB.above18gridview();
            grdStudentInfo.DataSource = dtB;
            grdStudentInfo.Show();

            grdStudentInfo.Columns["RegistrationId"].Visible = false;
            //       grdStudentInfo.Columns["Qualification"].Visible = false;
            grdStudentInfo.Columns["SchoolName"].Visible = false;
            grdStudentInfo.Columns["MotherName"].Visible = false;
     //       grdStudentInfo.Columns["CollageName"].Visible = false;
            grdStudentInfo.Columns["FamilyIncome"].Visible = false;
            grdStudentInfo.Columns["Percentage"].Visible = false;
            grdStudentInfo.Columns["STD"].Visible = false;
            grdStudentInfo.Columns["StudentRegistrationDate"].Visible = false;
            grdStudentInfo.Columns["AddressInfo"].Visible = false;

        }

        private void btnExcel1_Click(object sender, EventArgs e)
        {
            if (grdStudentInfo.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < grdStudentInfo.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = grdStudentInfo.Columns[i - 1].HeaderText;

                }
                for (int k = 0; k < grdStudentInfo.Rows.Count - 1; k++)
                {
                    for (int j = 2; j < grdStudentInfo.Columns.Count; j++)
                    {
                        xcelApp.Cells[k + 2, j + 1] = grdStudentInfo.Rows[k].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (grdStudentInfo.DataSource as DataTable).DefaultView.RowFilter =
                 String.Format("FullName like '%" + txtSearch.Text + "%'");

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
