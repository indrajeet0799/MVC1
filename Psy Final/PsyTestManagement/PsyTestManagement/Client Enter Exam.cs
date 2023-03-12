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
using System.Text.RegularExpressions;
using TestManagement.Client;
using PsyTestManagement;

namespace Client_Student_Information_2
{
    public partial class frmEnterExam : Form
    {
        public frmEnterExam()
        {
            InitializeComponent();
        }
        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmStud_Reg obj = new frmStud_Reg();
            obj.Show();
        }
        private void frmEnterExam_Load(object sender, EventArgs e)
        {
            clsClient obp = new clsClient();
            DataTable dt = new DataTable();
            dt = obp.Testpapercmb();
            cmbbxSelecttesttype.DisplayMember = "TestPaperName";
            cmbbxSelecttesttype.ValueMember = "TestPaperId";
            cmbbxSelecttesttype.DataSource = dt;
            cmbbxSelecttesttype.Show();
        }

        private void btnEnterExam_Click(object sender, EventArgs e)
        {
            string PaperName = cmbbxSelecttesttype.Text;
            int Paperid = Convert.ToInt32(cmbbxSelecttesttype.SelectedValue);
            FrmTestInformation obj = new FrmTestInformation(Paperid, PaperName);
            obj.Show();
            this.Close();
        }

        private void cmbbxSelecttesttype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
