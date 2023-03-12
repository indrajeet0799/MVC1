using PsyTestManagement;
using PSYTestManagement;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TestManagement.Admin;

namespace TestManagement
{
    public partial class frmTestManagement : Form
    {
        string TestType;
        string TestName;
        int TestPaperId;
        public frmTestManagement()
        {
            InitializeComponent();
        }
        DataTable dtrefresh = new DataTable();
        
        private void frmTestManagement_Load(object sender, EventArgs e)
        {
            // grdTestPaper.Refresh();

            clsAdmin objAdmin = new clsAdmin();         /* Loding Test Paper Table from Database to DataGridView */
            dtrefresh = objAdmin.GetTestPaper();
            grdTestPaper.DataSource = dtrefresh;
            grdTestPaper.Show();
            grdTestPaper.AllowUserToAddRows = false;

            DataGridViewButtonColumn objBtn = new DataGridViewButtonColumn();        /* Adding Button Column of View to DataGridView */
            grdTestPaper.Columns.Add(objBtn);
            objBtn.HeaderText = "View";
            objBtn.Text = "View";
            objBtn.UseColumnTextForButtonValue = true;
            objBtn.FlatStyle = FlatStyle.Flat;
            objBtn.DefaultCellStyle.ForeColor = Color.White;
            objBtn.DefaultCellStyle.BackColor = Color.HotPink;
            objBtn.Name = "btnView";
            objBtn.Width = 80;



            DataGridViewButtonColumn objBtn1 = new DataGridViewButtonColumn();       /* Adding Button Column of Add Question to DataGridView */
            grdTestPaper.Columns.Add(objBtn1);
            objBtn1.HeaderText = "Add Question";
            objBtn1.Text = "Add Question";
            objBtn1.UseColumnTextForButtonValue = true;
            objBtn1.FlatStyle = FlatStyle.Flat;
            objBtn1.DefaultCellStyle.ForeColor = Color.White;
            objBtn1.DefaultCellStyle.BackColor = Color.Blue;
            objBtn1.Name = "btnAddQuestion";
            objBtn1.Width = 150;



            DataGridViewImageColumn objBtn2 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
            grdTestPaper.Columns.Add(objBtn2);
            objBtn2.HeaderText = "";
            objBtn2.Width = 25;
            objBtn2.Image = Image.FromFile(Application.StartupPath + "/Resources/Delete.jpg");
            objBtn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            objBtn2.Name = "btnDelete";



            DataGridViewImageColumn objBtn3 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
            grdTestPaper.Columns.Add(objBtn3);
            objBtn3.HeaderText = "";
            objBtn3.Width = 25;
            objBtn3.Image = Image.FromFile(Application.StartupPath + "/Resources/Edit.jpg");
            objBtn3.ImageLayout = DataGridViewImageCellLayout.Stretch;
            objBtn3.Name = "btnEdit";

            grdTestPaper.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);         /* Bold font Style for Data Grid View Header Row */

            grdTestPaper.Columns["TestPaperId"].Visible = false;        /* Hiding Test Paper Id in Data Grid View */
            grdTestPaper.Columns["TotalMarks"].Visible = false;
            grdTestPaper.Columns["Duration"].Visible = false;
            grdTestPaper.Columns["TestType"].Width = 250;
            grdTestPaper.Columns["TestPaperName"].Width = 500;
            grdTestPaper.Columns["Status"].Width = 150;

        }
        private void btnNewTestPaper_Click(object sender, EventArgs e)
        {
            frmNewTestPaper objTestPaper = new frmNewTestPaper();        /* Open New TestPaper Form */
            objTestPaper.Show();
            // Hide();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clsAdmin objAdmin = new clsAdmin();         /* Loding Test Paper Table from Database to DataGridView */
            dtrefresh = objAdmin.GetTestPaper();
            grdTestPaper.DataSource = dtrefresh;
            grdTestPaper.Show();
            grdTestPaper.AllowUserToAddRows = false;

            //DataGridViewButtonColumn objBtn = new DataGridViewButtonColumn();        /* Adding Button Column of View to DataGridView */
            //grdTestPaper.Columns.Add(objBtn);
            //objBtn.HeaderText = "View";
            //objBtn.Text = "View";
            //objBtn.UseColumnTextForButtonValue = true;
            //objBtn.FlatStyle = FlatStyle.Flat;
            //objBtn.DefaultCellStyle.ForeColor = Color.White;
            //objBtn.DefaultCellStyle.BackColor = Color.HotPink;
            //objBtn.Name = "btnView";
            //objBtn.Width = 80;



            //DataGridViewButtonColumn objBtn1 = new DataGridViewButtonColumn();       /* Adding Button Column of Add Question to DataGridView */
            //grdTestPaper.Columns.Add(objBtn1);
            //objBtn1.HeaderText = "Add Question";
            //objBtn1.Text = "Add Question";
            //objBtn1.UseColumnTextForButtonValue = true;
            //objBtn1.FlatStyle = FlatStyle.Flat;
            //objBtn1.DefaultCellStyle.ForeColor = Color.White;
            //objBtn1.DefaultCellStyle.BackColor = Color.Blue;
            //objBtn1.Name = "btnAddQuestion";
            //objBtn1.Width = 150;



            //DataGridViewImageColumn objBtn2 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
            //grdTestPaper.Columns.Add(objBtn2);
            //objBtn2.HeaderText = "";
            //objBtn2.Width = 25;
            //objBtn2.Image = Image.FromFile(@"C:\Users\Dell\Desktop\PsyTestManagement\PsyTestManagement\Resources\Delete.jpeg");
            //objBtn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //objBtn2.Name = "btnDelete";



            //DataGridViewImageColumn objBtn3 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
            //grdTestPaper.Columns.Add(objBtn3);
            //objBtn3.HeaderText = "";
            //objBtn3.Width = 25;
            //objBtn3.Image = Image.FromFile(@"C:\Users\Dell\Desktop\PsyTestManagement\PsyTestManagement\Resources\Delete (1).jpeg");
            //objBtn3.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //objBtn3.Name = "btnEdit";

            grdTestPaper.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);         /* Bold font Style for Data Grid View Header Row */

            grdTestPaper.Columns["TestPaperId"].Visible = false;        /* Hiding Test Paper Id in Data Grid View */
            grdTestPaper.Columns["TotalMarks"].Visible = false;
            grdTestPaper.Columns["Duration"].Visible = false;
            grdTestPaper.Columns["TestType"].Width = 250;
            grdTestPaper.Columns["TestPaperName"].Width = 500;
            grdTestPaper.Columns["Status"].Width = 150;
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")           /* On Button Search Click Search By Alphabet in Data Grid View */
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")           /* Validations for Search-Bar */
            {
                txtSearch.Text = " Search...";
                txtSearch.ForeColor = Color.Silver;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (grdTestPaper.DataSource as DataTable).DefaultView.RowFilter = String.Format("TestType like '%" + txtSearch.Text + "%' or TestName like '%" + txtSearch.Text + "%'");           /* On Button Search Click Search By Alphabet in Data Grid View */
        }
        private void grdTestPaper_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var Height = 50;
            foreach (DataGridViewRow dr in grdTestPaper.Rows)
            {
                Height += dr.Height;
            }
            grdTestPaper.Height = Height;
        }
        private void grdTestPaper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            /*if (grdTestPaper.Columns[e.ColumnIndex].HeaderText == "View")  */     /* On Button View Click Open the Test View Form */
            {

                //int TestPaperId = Convert.ToInt32(grdTestPaper.CurrentRow.Cells[0].Value.ToString());
                //string Testtype = grdTestPaper.CurrentRow.Cells[2].Value.ToString();
                //string PaperName = grdTestPaper.CurrentRow.Cells[1].Value.ToString();
                //int Marks = Convert.ToInt32(grdTestPaper.CurrentRow.Cells[3].Value.ToString());
                //string Time = grdTestPaper.CurrentRow.Cells[4].Value.ToString();
                string Testtype = grdTestPaper.CurrentRow.Cells[6].Value.ToString();
                string PaperName = grdTestPaper.CurrentRow.Cells[5].Value.ToString();
                int Marks = Convert.ToInt32(grdTestPaper.Rows[grdTestPaper.CurrentRow.Index].Cells[7].Value.ToString());
                string Time = grdTestPaper.Rows[grdTestPaper.CurrentRow.Index].Cells[8].Value.ToString();
                int TestpaperId = Convert.ToInt32(grdTestPaper.Rows[grdTestPaper.CurrentRow.Index].Cells[4].Value.ToString());


                frmTestView objTestView = new frmTestView(TestpaperId, Testtype, PaperName, Marks, Time);
                objTestView.Show();
            }
            /* if (grdTestPaper.Columns[e.ColumnIndex].HeaderText == "Add Question") */      /* On Button Add Question Click Open the Add Question Form And Passing Test Type and Test Name */
            if (e.ColumnIndex == 1)
            {
                int Flag = 0;
                //  int TestPaperId = Convert.ToInt32(grdTestPaper.CurrentRow.Cells[4].Value);
                int TestpaperId = Convert.ToInt32(grdTestPaper.Rows[grdTestPaper.CurrentRow.Index].Cells[4].Value.ToString());
                frmAddQue objAddQue = new frmAddQue(TestpaperId, Flag);
                objAddQue.Show();
            }
            if (e.ColumnIndex == 2)
            //if (grdTestPaper.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                if (MessageBox.Show("Are you sure to Delete??", "Delete???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)      /* Validation and Warrning Box on Button Delete Click */
                {
                    try
                    {
                        //int IsDeleted = 1;
                        int TestPaperId = Convert.ToInt32(grdTestPaper.CurrentRow.Cells[4].Value.ToString());       /* On Button Delete Click Delete Test Paper only from Data Grid View not from Database */
                        clsAdmin objAdmin1 = new clsAdmin(TestPaperId);
                        objAdmin1.Delete();

                        grdTestPaper.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Deleted Rows Successfully...!!!");
                        //  grdTestPaper.Refresh();
                    }
                    catch
                    {
                        MessageBox.Show("Deleted Rows Problem...!!!");      /* Message Box For Problem in Detele Test Paper */
                    }
                }
            }
            // if (grdTestPaper.Columns[e.ColumnIndex].HeaderText == "Edit")       /* On Button Edit Click Open the Edit Question Form */
            if (e.ColumnIndex == 3)
            {
                int temp = 0;
                int TestPaperId = Convert.ToInt32(grdTestPaper.CurrentRow.Cells[4].Value);
                frmNewTestPaper objEditQue = new frmNewTestPaper(TestPaperId, temp);
                objEditQue.Show();
                // grdTestPaper.Refresh();
            }
        }

        private void grdTestPaper_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == 2)
            //{
            //    var cell = grdTestPaper.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //    cell.ToolTipText = "Delete";
            //}
            //if (e.ColumnIndex == 3)
            //{
            //    var cell = grdTestPaper.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //    cell.ToolTipText = "Edit";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

