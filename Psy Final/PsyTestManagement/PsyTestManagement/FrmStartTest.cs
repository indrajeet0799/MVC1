using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Xml;
using TestManagement.Client;
using System.Runtime.CompilerServices;
using System.Drawing.Imaging;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Collections;
using Client_Student_Information_2;

namespace PsyTestManagement
{
    public partial class FrmStartTest : Form
    {
        int temp = 0;
        public int pos = 0;
        string[] AnsKey = null;
        int Questionid = 0;
        int Ans = 0;
        string markingSystem = null;
        int Mark1 = 0;
        int Mark2 = 0;
        string Behaviourtype = null;
        string Quetype = null;
        DateTime testsubmitteddate=DateTime.Now;
        int colour = 0;
        int LastButtonIndex;
        string STUDID = null;
       int QUESID = 0;
       DataTable dtQue = new DataTable();

        public string testname { get; set; }
        public int PaperId { get; set; }
        List<Button> questBtn = new List<Button>();
        public FrmStartTest()
        {
            InitializeComponent();

        }
        public FrmStartTest(string StudId,int PaperID)
        {
            InitializeComponent();
            lblStudentId.Text=StudId;
            PaperId = PaperID;

        }

        private void FrmStartTest_Load(object sender, EventArgs e)
        {
            
            rdbAlways.Checked=false;
            rdbFrequently.Checked=false;
            rdbOften.Checked=false;
            rdbNever.Checked=false;
            btnPrevious.Enabled=false;

            GetData(0);
            buttons();
           
        }
        private void buttons()
        {
            int count = 1;
            int X = 0;
            int Y = 0;
            for (int i = 0; i < 48; i++)
            {
                if (Y == 6)
                {
                    X = X + 30; Y = 0;
                }
                var btn = new Button();
                questBtn.Add(btn);
                btn.Text = count.ToString();
                btn.Name = "btn" + i;                
                btn.Size = new Size(35, 35);
                btn.Location = new Point((900 + X), 30 * (Y + 1));
                Y++;
                count++;                
                btn.Click += new EventHandler(this.button_Click);
                Controls.Add(btn);
                             
                btn.BackColor = Color.Red;
            }
            

        }
        public void Save()
        {
            string studID = lblStudentId.Text;
            int QueID = Convert.ToInt32(lblQueId.Text);
            AnsKey = markingSystem.Split(',');

            if (rdbAlways.Checked == true)
            {
                Ans = Convert.ToInt32(AnsKey[0]);
                questBtn[QueID - 1].BackColor = Color.Green;
            }
            else if (rdbFrequently.Checked == true)
            {
                Ans = Convert.ToInt32(AnsKey[1]);
                questBtn[QueID - 1].BackColor = Color.Green;
            }
            else if (rdbOften.Checked == true)
            {
                Ans = Convert.ToInt32(AnsKey[2]);
                questBtn[QueID - 1].BackColor = Color.Green;
            }
            else if (rdbNever.Checked == true)
            {
                Ans = Convert.ToInt32(AnsKey[3]);
                questBtn[QueID - 1].BackColor = Color.Green;
            }

            if (Quetype == "Positive")
            {
                Mark1 = Mark2 = Ans;
            }
            else if (Quetype == "Negative")
            {
                if (Ans == 3)
                {
                    Mark2 = 0;
                    Mark1 = Ans;
                }
                else if (Ans == 0)
                {
                    Mark2 = 3;
                    Mark1 = Ans;
                }
                else if (Ans == 1)
                {
                    Mark2 = 2;
                    Mark1 = Ans;
                }
                else if (Ans == 2)
                {
                    Mark2 = 1;
                    Mark1 = Ans;
                }
            }
            clsClient objsaveans = new clsClient(studID, Questionid, Behaviourtype, Ans, Mark1, Mark2, testsubmitteddate);
            objsaveans.SaveAns();
            rdbAlways.Checked = false;
            rdbFrequently.Checked = false;
            rdbOften.Checked = false;
            rdbNever.Checked = false;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Save();
           
            Button btn = sender as Button;
            int a = int.Parse(btn.Text);
            pos=a-1;

            GetData(pos);
          
        }

        public void GetData(int pos)
        {
            clsClient objQuestion = new clsClient(PaperId);
            DataTable dtQue = new DataTable();
            dtQue = objQuestion.GetQuestion();


            markingSystem = dtQue.Rows[pos][4].ToString();
            lblQuestion.Text = dtQue.Rows[pos][7].ToString();
            lblQueId.Text = dtQue.Rows[pos][0].ToString();
            Questionid = Convert.ToInt32(dtQue.Rows[pos][0].ToString());
            Quetype = dtQue.Rows[pos][5].ToString();
            Behaviourtype = dtQue.Rows[pos][3].ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Questionid == 47)
            {
                this.btnNext.Enabled = false;
            }

            btnSubmit.Enabled = true;
            btnPrevious.Enabled = true;
            Save();
            rdbAlways.Checked = false;
            rdbFrequently.Checked = false;
            rdbOften.Checked = false;
            rdbNever.Checked = false;
            pos = pos + 1;
            GetData(pos);
           
           
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
           
            btnNext.Enabled=true;
            Save();
           
            if (Questionid <= 1)
            {
                btnPrevious.Enabled = false;
            }
            else
            {
                btnPrevious.Enabled = true;
            }
            pos = pos - 1;
            GetData(pos);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Save();
            string studID = lblStudentId.Text;
            int StatusID = 5;
            DateTime submitteddate = DateTime.Now;

            clsClient objupdate = new clsClient(studID, StatusID, submitteddate);
            objupdate.submittedDate();

            if (pos<dtQue.Rows.Count)
            {
                btnSubmit.Enabled = false;
                MessageBox.Show("Please answer to all questions...!");
            }

            else
            {
                //btnNext.Enabled = false;
                btnSubmit.Enabled = true;
                MessageBox.Show("Your test has been submitted successfully...!");
            }
          
            this.Close();
            frmEnterExam obj = new frmEnterExam();
            obj.Show();

        }
      
    }
}