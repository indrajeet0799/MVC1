using PsyTestManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;
using Testmgt;
using System.Data.SqlClient;

namespace TestManagement
{
    public partial class frmDashboard : Form
    {
        
        public string staffName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int Pincode { get; set; }
        public int StaffId { get; set; }
        public frmDashboard()
        {
            InitializeComponent();
         
        }
        public frmDashboard(string SN, String CO, String EID, string PASS,string ADD,int Pin,int staffid)
        {
            InitializeComponent();
            staffName = SN;
            PhoneNo = CO;
            EmailID = EID;
            Password = PASS;
            Address = ADD;
            Pincode = Pin;
            StaffId = staffid;

        }



        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
            frmLayoutDashboard panel = new frmLayoutDashboard();
            panel.TopLevel = false;
            panel.AutoScroll = true;
            pnlDashboard.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void MenuStripTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SettingManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
            frmPayment panel = new frmPayment();
            panel.TopLevel = false;
            panel.AutoScroll = true;
            pnlDashboard.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }

        private void REPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
            Reports panel = new Reports();
            panel.TopLevel = false;
            panel.AutoScroll = true;
            pnlDashboard.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }

        private void ResultToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pnlDashboard.Controls.Clear();
            frmClientresult panel = new frmClientresult();
            panel.TopLevel = false;
            panel.AutoScroll = true;
            pnlDashboard.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }

        private void TestManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
            frmTestManagement panel = new frmTestManagement();
            panel.TopLevel = false;
            panel.AutoScroll = true;
            pnlDashboard.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
            
        }

        private void ClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
            frmStudentInfo panel = new frmStudentInfo();
            panel.TopLevel = false;
            panel.AutoScroll = true;
            pnlDashboard.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }

        private void ClientRegToolMenuStrip_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
            FrmStudentRegistration panel = new FrmStudentRegistration();
            panel.TopLevel = false;
            panel.AutoScroll = true;
            pnlDashboard.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }

        private void MenuStripTabs_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consellorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void LoadForm(object Form)
        {
           
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
           
            pnlDashboard.Controls.Clear();
            frmLayoutDashboard panel = new frmLayoutDashboard();
            panel.TopLevel = false;
            panel.AutoScroll = true;
            pnlDashboard.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }


        private void Panel_Dashboard(object sender, PaintEventArgs e)
        {
          
        }

        private void StaffInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
            frmStaff panel = new frmStaff();
            panel.TopLevel = false;
            panel.AutoScroll = true;
            pnlDashboard.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();

        }

        private void eDITPROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditAdmin objadmin = new frmEditAdmin(staffName, PhoneNo, EmailID,Address,Pincode);
            objadmin.Show();
        }

        private void cHANGEPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmChangePassword objchange = new frmChangePassword(StaffId, Password);
            objchange.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmLogin objlogin = new frmLogin();
            //objlogin.Show();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
