using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestManagement.Admin;
using System.Drawing;

namespace PsyTestManagement
{
    public partial class frmAddQue : Form
    {
        string MarkingSystem;
        public string TestPaperName = null;
        public int TestPaperId { get; set; }
        
       
       public int Flag { get; set; }
        public frmAddQue()
        {
            InitializeComponent();
        }
        public frmAddQue(int testpaperid,int f)
        {
            InitializeComponent();
            TestPaperId=testpaperid;
            Flag = f;
        }
        public frmAddQue(int testpaperid)
        {
            InitializeComponent();
            TestPaperId=testpaperid;
            
        }
           

        public frmAddQue(string TestType, string TestPaperName)
        {
            InitializeComponent();
            label1.Text = TestType;
            label2.Text = TestPaperName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQNo.Text == "")
            {
                MessageBox.Show("Please enter QuestionNo");
                errorProvider1.SetError(this.txtQNo, "Please enter QuestionNo");
                return;
            }
            if (txtQue.Text == "")
            {
                MessageBox.Show("Please enter Question");
                errorProvider1.SetError(this.txtQue, "Please enter Question");
                return;
            }
            if (cmbbxMarkingSystem.Text == "")
            {
                MessageBox.Show("Please select Marking System");
                errorProvider1.SetError(this.cmbbxMarkingSystem, "Please select Marking System");
                return;
            }
            if (cmbbxbehaviorType.Text == "")
            {
                MessageBox.Show("Please select Behavior Type");
                errorProvider1.SetError(this.cmbbxbehaviorType, "Please select Behavior Type");
                return;
            }
            if (cmbbxQueGroup.Text == "")
            {
                MessageBox.Show("Please select QueGroup");
                errorProvider1.SetError(this.cmbbxQueGroup, "Please select QueGroup");
                return;
            }
            if (cmbbxQueType.Text == "")
            {
                MessageBox.Show("Please select QueType");
                errorProvider1.SetError(this.cmbbxQueType, "Please select QueType");
                return;
            }
           
            string BehaviorType = cmbbxbehaviorType.SelectedItem.ToString();
            string QueType = cmbbxQueType.SelectedItem.ToString();
            string QueGroup = cmbbxQueGroup.SelectedItem.ToString();
           int QNo=Convert.ToInt32(txtQNo.Text);

            clsAdmin objget = new clsAdmin(TestPaperId,BehaviorType,QueType,QueGroup);
            SqlDataReader dr;
            dr = objget.GETDATA();
            if(dr.HasRows == true)
            {
                MessageBox.Show("Question cant be added in this group");
                dr.Close();
            }
            else
            {
                clsAdmin objque = new clsAdmin(TestPaperId, QNo, BehaviorType, MarkingSystem, QueType, QueGroup, txtQue.Text);
                objque.SaveQuestion();
                MessageBox.Show("Question Save Successful");
                cmbbxbehaviorType.SelectedItem = null;

                cmbbxQueType.SelectedItem = null;
                cmbbxQueGroup.SelectedItem = null;
                txtQue.Clear();
                txtQNo.Clear();
                btnUpdate.Visible = false;
            }
           
        }
        private void cmbbxMarkingSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbbxMarkingSystem.SelectedItem.ToString() == "Odd Marking System")
            {
                MarkingSystem = "3,2,1,0"; 
            }
            else if(cmbbxMarkingSystem.SelectedItem.ToString() == "Even Marking System")
                    {
                MarkingSystem = "0,1,2,3";
            }
        }
        private void AddQue_Load(object sender, EventArgs e)
        {

            clsAdmin objId = new clsAdmin(label2.Text);
            SqlDataReader dr1;
            dr1 = objId.GetTestPaperId();
            while (dr1.Read())
            {
                TestPaperId = Convert.ToInt32(dr1["TestPaperId"].ToString());
            }
            dr1.Close();

            clsAdmin obj = new clsAdmin(TestPaperId);
            DataTable dt = new DataTable();
            dt = obj.GetQuestion();
            grdQuestionDetails.DataSource = dt;
            grdQuestionDetails.Show();
           
            if (dt.Rows.Count > 0)
            {
                grdQuestionDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdQuestionDetails.Show(); 
            }
            else {
                grdQuestionDetails.Visible = false;

            }

            DataGridViewImageColumn objBtn2 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
            grdQuestionDetails.Columns.Add(objBtn2);
            objBtn2.HeaderText = "";
            objBtn2.Width = 35;
     
            objBtn2.Image = Image.FromFile(Application.StartupPath + "/Resources/Delete.jpg");
            objBtn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            objBtn2.Name = "btnDelete";


            DataGridViewImageColumn objBtn3 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
            grdQuestionDetails.Columns.Add(objBtn3);
            objBtn3.HeaderText = "";
            objBtn3.Width = 35;
            objBtn3.Image = Image.FromFile(Application.StartupPath + "/Resources/Edit.jpg");
            objBtn3.ImageLayout = DataGridViewImageCellLayout.Stretch;
            objBtn3.Name = "btnEdit";
            grdQuestionDetails.Columns[3].Width = 260;
            grdQuestionDetails.Columns[0].Visible = false;
            grdQuestionDetails.Columns[1].Width = 100;
            grdQuestionDetails.Columns[2].Width = 50;

         //   grdQuestionDetails.Autos
        }

        public void grdQuestionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //(grdQuestionDetails.Columns[e.ColumnIndex].HeaderText == "Delete")
            if(e.ColumnIndex==8)

            {
                 int QuestionId = Convert.ToInt32(grdQuestionDetails.CurrentRow.Cells[0].Value);
                 
                clsAdmin objDel = new clsAdmin(QuestionId);
                objDel.DeleteQuestion();
                MessageBox.Show("Question Delete Successful");
            }
            else if (e.ColumnIndex == 9)//if(grdQuestionDetails.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                 int QuestionId = Convert.ToInt32(grdQuestionDetails.CurrentRow.Cells[0].Value.ToString());
                txtQNo.Text = grdQuestionDetails.CurrentRow.Cells[2].Value.ToString();
                cmbbxbehaviorType.Text = grdQuestionDetails.CurrentRow.Cells[4].Value.ToString();
                txtQue.Text = grdQuestionDetails.CurrentRow.Cells[3].Value.ToString();
                MarkingSystem = grdQuestionDetails.CurrentRow.Cells[5].Value.ToString();
                cmbbxQueType.Text = grdQuestionDetails.CurrentRow.Cells[6].Value.ToString();
                 cmbbxQueGroup.Text = grdQuestionDetails.CurrentRow.Cells[7].Value.ToString();

                if (MarkingSystem == "3,2,1,0")
                {
                    cmbbxMarkingSystem.Text = "Odd Marking System";
                }
                else if (MarkingSystem == "0,1,2,3")
                {

                    cmbbxMarkingSystem.Text = "Even Marking System";
                }

            }
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mark;
           int  QuestionId = Convert.ToInt32(grdQuestionDetails.CurrentRow.Cells[0].Value.ToString());
            string BehaviorType = cmbbxbehaviorType.Text.ToString();
            int QuestionNo = Convert.ToInt32(txtQNo.Text);
            string Question = txtQue.Text;
            string QueGroup = cmbbxQueGroup.Text.ToString();
            string QueType = cmbbxQueType.Text.ToString();

           
            
            clsAdmin objEdit = new clsAdmin(QuestionNo,BehaviorType, MarkingSystem, QueType, QueGroup, Question,QuestionId);
            objEdit.EditQuestion();
            MessageBox.Show("Question Update Successful");
            btnAdd.Visible = true;

            cmbbxbehaviorType.SelectedItem = null;

            cmbbxQueType.SelectedItem = null;
            cmbbxQueGroup.SelectedItem = null;
            txtQue.Clear();
            txtQNo.Clear();
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxbehaviorType.SelectedItem = null;
            cmbbxQueType.SelectedItem = null;
            cmbbxQueGroup.SelectedItem = null;
            txtQue.Clear();
            txtQNo.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (grdQuestionDetails.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Question like '{0}%'or TestPaperName like '{0}%'or BehaviorType like '{0}%'or QGroup like '{0}%'or QueType like '{0}%'", txtSearch.Text );
        }
       
        private void btnExel_Click(object sender, EventArgs e)
        {
            if (grdQuestionDetails.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelapp = new Microsoft.Office.Interop.Excel.Application();
                xcelapp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < grdQuestionDetails.Columns.Count + 1; i++)
                {
                    xcelapp.Cells[1, i] = grdQuestionDetails.Columns[i - 1].HeaderText;

                }
                for (int i = 0; i < grdQuestionDetails.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grdQuestionDetails.Columns.Count-2; j++)
                    {
                        xcelapp.Cells[i + 2, j +1] = grdQuestionDetails.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelapp.Columns.AutoFit();
                xcelapp.Visible = true;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        { 
       
            grdQuestionDetails.Columns.Clear();

            clsAdmin obj = new clsAdmin(TestPaperId);
            DataTable dt = new DataTable();
            dt = obj.GetQuestion();
            grdQuestionDetails.DataSource = dt;
            grdQuestionDetails.Show();

            if (dt.Rows.Count > 0)
            {
                grdQuestionDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdQuestionDetails.Show();
            }
            else
            {
                grdQuestionDetails.Visible = false;

            }

            DataGridViewImageColumn objBtn2 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
            grdQuestionDetails.Columns.Add(objBtn2);
            objBtn2.HeaderText = "";
            objBtn2.Width = 35;
            objBtn2.Image = Image.FromFile(Application.StartupPath + "/Resources/Delete.jpeg");
            objBtn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            objBtn2.Name = "btnDelete";


            DataGridViewImageColumn objBtn3 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
            grdQuestionDetails.Columns.Add(objBtn3);
            objBtn3.HeaderText = "";
            objBtn3.Width = 35;
            objBtn3.Image = Image.FromFile(Application.StartupPath + "/Resources/Edit.jpg");
            objBtn3.ImageLayout = DataGridViewImageCellLayout.Stretch;
            objBtn3.Name = "btnEdit";
            grdQuestionDetails.Columns[3].Width = 260;
            grdQuestionDetails.Columns[0].Visible = false;
            grdQuestionDetails.Columns[1].Width = 100;
            grdQuestionDetails.Columns[2].Width = 50;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Questions added in your Testpaper Successfully");
            this.Close();
        }

        private void grdQuestionDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //var height = 50;
            //foreach(DataGridViewRow dr in grdQuestionDetails.Rows)
            //{
            //    height+=dr.Height;
            //    grdQuestionDetails.Height=height;
            //}

        }

        private void grdQuestionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            grdQuestionDetails.Visible = false;
            dataGridView1.Visible = true;
            DataGridViewTextBoxColumn obj1 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(obj1);
            obj1.HeaderText = "QuestionId";
            obj1.DataPropertyName = "QuestionId";

            DataGridViewTextBoxColumn obj2 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(obj2);
            obj2.HeaderText = "TestPaperName";
            obj2.DataPropertyName = "TestPaperName";

            DataGridViewTextBoxColumn obj3 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(obj3);
            obj3.HeaderText = "QuestionNo";
            obj1.DataPropertyName = "QuestionNo";

            DataGridViewTextBoxColumn obj4 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(obj4);
            obj4.HeaderText = "Question";
            obj1.DataPropertyName = "Question";

            DataGridViewTextBoxColumn obj5 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(obj5);
            obj5.HeaderText = "BehaviorType";
            obj1.DataPropertyName = "BehaviorType";

            DataGridViewTextBoxColumn obj6 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(obj6);
            obj6.HeaderText = "MarkingSystem";
            obj1.DataPropertyName = "MarkingSystem";

            DataGridViewTextBoxColumn obj7 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(obj7);
            obj7.HeaderText = "QueType";
            obj1.DataPropertyName = "QueType";

            DataGridViewTextBoxColumn obj8 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(obj8);
            obj8.HeaderText = "QGroup";
            obj1.DataPropertyName = "QGroup";
            // grdQuestionDetails.Rows.Clear();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = null;
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;
            int xlRow;
            string strFileName;
            openFD.Filter = "Excel office |*.xls; *xlsx";
            //openFD.ShowDialog();
            if(openFD.ShowDialog() == DialogResult.OK)
            { 
            strFileName = openFD.FileName;
                if (strFileName != "")
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(strFileName);
                    xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                    xlRange = xlWorksheet.UsedRange;

                    int i = 0;

                    for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                    {
                        if (xlRange.Cells[xlRow, 1].Text != "")
                        {
                            i++;
                            dataGridView1.Rows.Add(i, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text);
                            dt.Columns.Add();
                        }
                    }
                    xlWorkbook.Close();
                    xlApp.Quit();
                }
            }
            else
            {
                dataGridView1.Visible=false;
                grdQuestionDetails.Visible = true;
                grdQuestionDetails.Columns.Clear();


                clsAdmin obj = new clsAdmin(TestPaperId);
                DataTable dt1 = new DataTable();
                dt1 = obj.GetQuestion();
                grdQuestionDetails.DataSource = dt1;
                grdQuestionDetails.Show();

                if (dt1.Rows.Count > 0)
                {
                    grdQuestionDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    grdQuestionDetails.Show();
                }
                else
                {
                    grdQuestionDetails.Visible = false;

                }

                DataGridViewImageColumn objBtn2 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
                grdQuestionDetails.Columns.Add(objBtn2);
                objBtn2.HeaderText = "";
                objBtn2.Width = 35;
                objBtn2.Image = Image.FromFile(Application.StartupPath + "/Resources/Delete.jpg");
                objBtn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                objBtn2.Name = "btnDelete";


                DataGridViewImageColumn objBtn3 = new DataGridViewImageColumn();      /* Adding Button Column of Delete? to DataGridView */
                grdQuestionDetails.Columns.Add(objBtn3);
                objBtn3.HeaderText = "";
                objBtn3.Width = 35;
                objBtn3.Image = Image.FromFile(Application.StartupPath + "/Resources/Edit.jpg");
                objBtn3.ImageLayout = DataGridViewImageCellLayout.Stretch;
                objBtn3.Name = "btnEdit";
                grdQuestionDetails.Columns[3].Width = 260;
                grdQuestionDetails.Columns[0].Visible = false;
                grdQuestionDetails.Columns[1].Width = 100;
                grdQuestionDetails.Columns[2].Width = 50;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int QuestionNo = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                // int TestPaperId = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                string BehaviorType = dataGridView1.Rows[i].Cells[4].Value.ToString();
                MarkingSystem = dataGridView1.Rows[i].Cells[5].Value.ToString();
                string QueType = dataGridView1.Rows[i].Cells[6].Value.ToString();
                string QueGroup = dataGridView1.Rows[i].Cells[7].Value.ToString();
                string Question = dataGridView1.Rows[i].Cells[3].Value.ToString();
                clsAdmin objque = new clsAdmin(TestPaperId, QuestionNo, BehaviorType, MarkingSystem, QueType, QueGroup, Question);
                objque.SaveQuestion();

                dataGridView1.Visible = false;

            }
            MessageBox.Show("Question Save Successful");
        }
    }
}
