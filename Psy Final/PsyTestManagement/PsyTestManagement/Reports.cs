using TestManagement.Admin;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TestManagement.Admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DataTable = System.Data.DataTable;

namespace PsyTestManagement
{
    public partial class Reports : Form
    {
       

       

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            chart2.Visible=false;
            chart3.Visible=false;   
            grdviewdailyclient.DataSource = null;
            chart1.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            btndaily.Visible = false;
            btnmonthly.Visible = false;
            btnyearly.Visible = false;
            calender.Visible = false;
            txttotalpayment.Visible = false;
            lbltotalpayment.Visible=false;
            txtsearch.Visible=false;
            lblsearch.Visible = false;
            DateTime a = dateTimePicker1.Value;
            DateTime b = dateTimePicker2.Value;
            clsAdmin objcsl = new clsAdmin(a, b);
            DataTable dt = new DataTable();
            dt = objcsl.dailypayment();

            grdviewdailyclient.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                chart1.Visible = false;
                grdviewdailyclient.Visible = true;
                grdviewdailyclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdviewdailyclient.DataSource = dt;
                grdviewdailyclient.Show();
                txttotalpayment.Visible = true;
                txttotalpayment.Visible = true;
                lbltotalpayment.Visible=true;
                
            }
            else
            {
                grdviewdailyclient.Visible = false;
                txttotalpayment.Visible = false;
            }


            int count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i][6].ToString()!="")
                {
                    count += Convert.ToInt32(dt.Rows[i][6]);
                }
                
            }

            txttotalpayment.Text = count.ToString();

        }



        private void grdviewdailyclient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        //    int Height =0;
        //    foreach (DataGridViewRow dr in grdviewdailyclient.Rows)
        //    {
        //       Height += dr.Height;

        //    }
        //    Height+= grdviewdailyclient.ColumnHeadersHeight ;
            grdviewdailyclient.Height = grdviewdailyclient.Rows.GetRowsHeight(DataGridViewElementStates.None) + grdviewdailyclient.ColumnHeadersHeight + 2;
        }

        private void btndailypayment_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            //lblsearch.Visible = true;
            //txtsearch.Visible = true;
            lbltotalpayment.Visible = false;
            grdviewdailyclient.DataSource = null;
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            btndaily.Visible = false;
            btnmonthly.Visible = false;
            btnyearly.Visible = false;
            calender.Visible = false;
            txttotalpayment.Visible = false;
            lbltotalpayment.Visible = false;
            txtsearch.Visible = false;
            lblsearch.Visible = false;
            DateTime a = dateTimePicker1.Value;
            DateTime b = dateTimePicker2.Value;
            clsAdmin objcsl = new clsAdmin(a, b);
            DataTable dt = new DataTable();
            dt = objcsl.dailypayment();

            grdviewdailyclient.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                chart1.Visible = false;
                grdviewdailyclient.Visible = true;
                grdviewdailyclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdviewdailyclient.DataSource = dt;
                grdviewdailyclient.Show();
                txttotalpayment.Visible = true;
                txttotalpayment.Visible = true;
                lbltotalpayment.Visible = true;

            }
            else
            {
                grdviewdailyclient.Visible = false;
                txttotalpayment.Visible = false;
            }


            int count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][6].ToString() != "")
                {
                    count += Convert.ToInt32(dt.Rows[i][6]);
                }
            }

            txttotalpayment.Text = count.ToString();

        }

        private void btntesttype_Click(object sender, EventArgs e)
        {
            
            label1.Visible = true;
            label1.Text = "Test Types";
            label3.Text = "d";
            visible();
            chart1.Visible = true;
            chart2.Visible = false;
            chart3.Visible=false;
            getgraph();
            
        }

        private void dateTimePickerTesttype_ValueChanged(object sender, EventArgs e)
        {
        

        }

        private void btnagediffcount_Click(object sender, EventArgs e)
        {
        
              label1.Text = "Age Type Test";
            label3.Text = "d";
            visible();
            chart1.Visible = false;
            chart2.Visible = true;
            chart3.Visible = false;
            getgraph();
       
        
        }

        private void dateTimePickerAge_ValueChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnmonthly_Click(object sender, EventArgs e)
        {
            label3.Text = "m";
            getgraph();
           
           
        }

        private void dateTimePickermonthpayment_ValueChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btnyearlypayment_Click(object sender, EventArgs e)
        {
           
            label3.Text = "Y";
            getgraph();
        }

        private void dateTimePickeryearlypayment_ValueChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            grdviewdailyclient.DataSource = null;
            chart1.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            DateTime a = dateTimePicker1.Value;
            DateTime b = dateTimePicker2.Value;
            clsAdmin objcsl = new clsAdmin(a, b);
            DataTable dt = new DataTable();
            dt = objcsl.dailypayment();

            grdviewdailyclient.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                chart1.Visible = false;
                grdviewdailyclient.Visible = true;
                grdviewdailyclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdviewdailyclient.DataSource = dt;
                grdviewdailyclient.Show();
                txttotalpayment.Visible = true;
                lbltotalpayment.Visible = true;
                txtsearch.Visible = true;
                lblsearch.Visible = true;
            }
            else
            {
                grdviewdailyclient.Visible = false;
                txttotalpayment.Visible=false;
            }


            int count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][6].ToString() != "")
                {
                    count += Convert.ToInt32(dt.Rows[i][6]);
                }
            }

            txttotalpayment.Text = count.ToString();
        }
    

        private void dateTimePicker2_Leave(object sender, EventArgs e)
        {
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "d";
            visible();
            getgraph();

        }
        private void getgraph()
        {foreach(var Series in chart3.Series)
            {
                Series.Points.Clear();
            }
            foreach (var Series in chart2.Series)
            {
                Series.Points.Clear();
            }
            foreach (var Series in chart1.Series)
            {
                Series.Points.Clear();
            }
            grdviewdailyclient.Visible = false;
            txttotalpayment.Visible=false;
            chart1.Visible = true;
            label1.Visible = true;
            if (label1.Text == "Test Types")
            {
                chart1.Visible = true;
                chart2.Visible = false;
                chart3.Visible = false;
                if (label3.Text == "d")
                {
                   
                    DateTime a = Convert.ToDateTime( calender.Value.ToShortDateString());
                    clsAdmin cls = new clsAdmin(a);
                    DataTable dt = new DataTable();
                    dt = cls.dailytesttype();
                    if (dt.Rows.Count>0)
                    {
                        chart1.Series.Clear();
                        chart1.DataBindTable(dt.DefaultView, "TestType");
                    }
                    else
                    {
                        MessageBox.Show("no record found");
                        chart1.Visible = false;
                    }

                }
                else
                    if (label3.Text == "m")
                {
                   
                    int b=calender.Value.Month;
                    int c = calender.Value.Year;
                    clsAdmin cls = new clsAdmin(b,c);
                    DataTable dt = new DataTable();
                    dt = cls.monthlytesttype();
                    if (dt.Rows.Count>0)
                    {
                        chart1.Series.Clear();
                        chart1.DataBindTable(dt.DefaultView, "TestType");
                    }
                    else
                    {
                        MessageBox.Show("no record found");
                        chart1.Visible = false;
                    }
                }
               else if (label3.Text == "Y")
                {
                   
                    int b = calender.Value.Month;
                    int c = calender.Value.Year;
                    clsAdmin cls = new clsAdmin(b, c);
                    DataTable dt = new DataTable();
                    dt = cls.yearlytesttype();
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][0].ToString() != "")
                        {
                            chart1.Series.Clear();
                            chart1.DataBindTable(dt.DefaultView, "TestType");
                        }
                        else
                        {
                            MessageBox.Show("no record found");
                            chart1.Visible = false;
                        }
                    }
                }
            }
            else if (label1.Text == "Age Type Test")
            {
                chart1.Visible = false;
                chart2.Visible = true;
                chart3.Visible = false;
                if (label3.Text == "d")
                {
                    DateTime a = Convert.ToDateTime( calender.Value.ToShortDateString());
                    clsAdmin cls = new clsAdmin(a);
                    DataTable dt = new DataTable();
                    dt = cls.dailyagetypetest();
                    if (dt.Rows[0][0].ToString()!="")
                    {
                        chart2.Series.Clear();
                        chart2.DataBindTable(dt.DefaultView, "day");
                    }
                    else
                    {
                        MessageBox.Show("no record found");
                        chart2.Visible = false;
                    }

                }
                else
                    if (label3.Text == "m")
                {
                   
                    int b = calender.Value.Month;
                    int c = calender.Value.Year;
                    clsAdmin cls = new clsAdmin(b, c);
                    DataTable dt = new DataTable();
                    dt = cls.monthlyagetypetest();
                    if (dt.Rows[0][0].ToString() != "")
                    {
                        chart2.Series.Clear();
                        chart2.DataBindTable(dt.DefaultView, "month");
                    }
                    else
                    {
                        MessageBox.Show("no record found");
                        chart2.Visible = false;
                    }
                }
                else if (label3.Text == "Y")
                {
                    
                    int b = calender.Value.Month;
                    int c = calender.Value.Year;
                    clsAdmin cls = new clsAdmin(b, c);
                    DataTable dt = new DataTable();
                    dt = cls.yearlyagetypetest();
                    if (dt.Rows[0][0].ToString() != "")
                    {
                        chart2.Series.Clear();
                        chart2.DataBindTable(dt.DefaultView, "year");
                    }
                    else
                    {
                        MessageBox.Show("no record found");
                        chart2.Visible = false;
                    }
                }
            }
            else if (label1.Text == "payment")
            {
                chart1.Visible = false;
                chart2.Visible = false;
                chart3.Visible = true;
                if (label3.Text == "d")
                {
                    DateTime a = Convert.ToDateTime(calender.Value.ToShortDateString());
                    clsAdmin cls = new clsAdmin(a);
                    DataTable dt = new DataTable();
                    dt = cls.dailypaymentgraph();
                    if (dt.Rows[0][0].ToString() != "")
                    {
                        chart3.Series.Clear();
                        chart3.DataBindTable(dt.DefaultView, "date");
                    }
                    else
                    {
                        MessageBox.Show("no record found");
                        chart3.Visible = false;
                    }

                }
                else
                    if (label3.Text == "m")
                {
                   
                    int b = calender.Value.Month;
                    int c = calender.Value.Year;
                    clsAdmin cls = new clsAdmin(b, c);
                    DataTable dt = new DataTable();
                    dt = cls.monthlypaymentgraph();
                    if (dt.Rows.Count>0)
                    {
                        if (dt.Rows[0][0].ToString() != "")
                        {
                            chart3.Series.Clear();
                            chart3.DataBindTable(dt.DefaultView, "day");
                        }
                    }
                    else
                    {
                        MessageBox.Show("no record found");
                        chart3.Visible = false;
                    }
                }
                else if (label3.Text == "Y")
                {
                   
                    int b = calender.Value.Month;
                    int c = calender.Value.Year;
                    clsAdmin cls = new clsAdmin(b, c);
                    DataTable dt = new DataTable();
                    dt = cls.yearlypaymentgraph();
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][0].ToString() != "")
                        {
                            chart3.Series.Clear();
                            chart3.DataBindTable(dt.DefaultView, "year");
                        }
                    }
                    else
                    {
                        MessageBox.Show("no record found");
                        chart3.Visible = false;
                    }
                    
                }
            }
            //else if (label1.Text == cmbxmaxtest.SelectedItem.ToString())
            //{
            //    if (label3.Text == "d")
            //    {
            //        DateTime a = Convert.ToDateTime(calender.Value.ToShortDateString());
            //        clsAdmin cls = new clsAdmin(a);
            //        DataTable dt = new DataTable();
            //        dt = cls.dailyabove18maxtest();
            //        if (dt.Rows.Count > 0)
            //        {
            //            chart1.Series.Clear();
            //            chart1.DataBindTable(dt.DefaultView, "date");
            //        }
            //        else
            //        {
            //            MessageBox.Show("no record found");
            //        }

            //    }
            //    else
            //        if (label3.Text == "m")
            //    {
            //        // string a = calender.Value.ToShortDateString();
            //        int b = calender.Value.Month;
            //        int c = calender.Value.Year;
            //        clsAdmin cls = new clsAdmin(b, c);
            //        DataTable dt = new DataTable();
            //        dt = cls.monthlyabove18maxtest();
            //        if (dt.Rows.Count > 0)
            //        {
            //            chart1.Series.Clear();
            //            chart1.DataBindTable(dt.DefaultView, "day");
            //        }
            //        else
            //        {
            //            MessageBox.Show("no record found");
            //        }
            //    }
            //    else if (label3.Text == "Y")
            //    {
            //        // string a = calender.Value.ToShortDateString();
            //        int b = calender.Value.Month;
            //        int c = calender.Value.Year;
            //        clsAdmin cls = new clsAdmin(b, c);
            //        DataTable dt = new DataTable();
            //        dt = cls.yearlyabove18maxtest();
            //        if (dt.Rows.Count > 0)
            //        {
            //            chart1.Series.Clear();
            //            chart1.DataBindTable(dt.DefaultView, "year");
            //        }
            //        else
            //        {
            //            MessageBox.Show("no record found");
            //        }
            //    }
            //}
        }

        private void calender_ValueChanged(object sender, EventArgs e)
        {
            getgraph();
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            label1.Text = "payment";
            label3.Text = "d";
            visible();
            getgraph();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            (grdviewdailyclient.DataSource as DataTable).DefaultView.RowFilter = String.Format("[Student Name] like '%" + txtsearch.Text + "%' or EmailId like '%" + txtsearch.Text + "%' or Contactno like '%" + txtsearch.Text + "%' or TestType like '%" + txtsearch.Text + "%'");
        }
        public void visible()
        {
            label4.Visible = false;
            label5.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            lblsearch.Visible = false;
            txtsearch.Visible = false;
            lbltotalpayment.Visible = false;
            grdviewdailyclient.Visible = false;
            chart1.Visible = true;
            label1.Visible = true;
            btndaily.Visible = true;
            btnmonthly.Visible = true;
            btnyearly.Visible = true;
            calender.Visible = true;
        }
    }
}
