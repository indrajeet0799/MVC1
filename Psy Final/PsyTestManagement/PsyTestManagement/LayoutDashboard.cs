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


namespace TestManagement
{
    public partial class frmLayoutDashboard : Form
    {
        public frmLayoutDashboard()
        {
            InitializeComponent();
        }

      
        private void frmLayoutDashboard_Load(object sender, EventArgs e)
        {
            //------------------------------Get_Graph---------------------------------//
            clsAdmin objt = new clsAdmin();
            DataSet ds = new DataSet();
            ds = objt.Chart();

            ChartMonthlyGraph.DataSource = ds;
            ChartMonthlyGraph.Series["Monthly Clients"].XValueMember = "Month";


            ChartMonthlyGraph.Series["Monthly Clients"].YValueMembers = "Count";

            ChartMonthlyGraph.Titles.Add("Monthly Clients");

            //-----------------------------Daily_Client Count----------------------------//
            clsAdmin obj =new clsAdmin();
            SqlDataReader dr;
            dr = obj.Daily_Client();
            while(dr.Read())
            {
                lblDailyClient.Text = dr["DailyClient"].ToString();
            }

            //--------------------------------------Daily_test Count----------------------------------//
            clsAdmin obj1 = new clsAdmin();
            SqlDataReader dm;
            dm = obj1.Daily_Test();
            while (dm.Read())
            {
                lblDailyTest.Text = dm["DailyTests"].ToString();
            }
            //------------------------------------Monthly_Client Count----------------------------//

            clsAdmin obj2 = new clsAdmin();
            SqlDataReader dn;
            dn = obj2.Monthly_Client();
            while (dn.Read())
            {
                lblMonthlyClient.Text = dn["RegistrationDate"].ToString();
            }
            //------------------------------------Monthly_Test Count----------------------------//

            clsAdmin obj3 = new clsAdmin();
            SqlDataReader dt;
            dt = obj3.Monthly_Test();
            while (dt.Read())
            {
                lblMonthlyTest.Text = dt["SubmittedDate"].ToString();
            }
        }
        public void fillChart()
        {

        }

        private void ChartMonthlyGraph_Click(object sender, EventArgs e)
        {

        }

        private void btnMonthlyClients_Click(object sender, EventArgs e)
        {
        }

        private void lblClientCount_Click(object sender, EventArgs e)
        {

        }

        private void btnMonthlyTests_Click(object sender, EventArgs e)
        {

        }

        private void lblTestCount_Click(object sender, EventArgs e)
        {

        }
    }
}
