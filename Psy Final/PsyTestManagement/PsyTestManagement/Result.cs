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
using System.Threading;
using System.Security.Cryptography.X509Certificates;


namespace TestManagement.Admin
   
{
    public partial class Result : Form
    {
        public int Count = 0;
        Bitmap bitmap;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIFFRJ2;Initial Catalog=TestManagement;Integrated Security=True");
        public Result()
        {
            InitializeComponent();

        }
        public string studid { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string age { get; set; }
        public string gender { get; set; }

        public Result(string studid1,string firstname1, string age1, string gender1)
        {
            InitializeComponent();
            studid = studid1;
            firstname = firstname1;
            age = age1;
            gender = gender1;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            

            clsAdmin frm = new clsAdmin(studid);
            DataTable dt = new DataTable();

            dt = frm.Getsum();
            decimal satwik = 0;
            decimal rajas = 0;
            decimal tamas = 0;
            decimal mark2 = 0;
            decimal vyaktitvank = 0;



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == "सात्विक")


                {
                    if (Convert.ToInt32(dt.Rows[i][2].ToString()) == 3)
                    {
                        Count += Convert.ToInt32(dt.Rows[i][2].ToString());
                    }
                    else
                    {
                        satwik += Convert.ToInt32(dt.Rows[i][2].ToString());
                    }
                }
                else

                            if (dt.Rows[i][1].ToString() == "राजस")
                {


                    if (Convert.ToInt32(dt.Rows[i][2].ToString()) == 3)
                    {
                        Count += Convert.ToInt32(dt.Rows[i][2].ToString());
                    }
                    else
                    {
                        rajas += Convert.ToInt32(dt.Rows[i][2].ToString());
                    }
                }

                else
                         if (dt.Rows[i][1].ToString() == "तामस")
                {
                    if (Convert.ToInt32(dt.Rows[i][2].ToString()) == 3)
                    {
                        Count += Convert.ToInt32(dt.Rows[i][2].ToString());
                    }
                    else
                    {
                        tamas += Convert.ToInt32(dt.Rows[i][2].ToString());
                    }
                }
            }


            lblstotal.Text = satwik.ToString();
            lblgadabadaank.Text = Count.ToString();
            lblrtotal.Text = rajas.ToString();
            lblttotal.Text = tamas.ToString();


            lblspraman.Text = ((satwik * 6 / (satwik + rajas + tamas)).ToString("0.00"));
            lblrpraman.Text = ((rajas * 6 / (satwik + rajas + tamas)).ToString("0.00"));
            lbltpraman.Text = ((tamas * 6 / (satwik + rajas + tamas)).ToString("0.00"));

           
            decimal a =(decimal.Parse(lblspraman.Text));
            decimal b =(decimal.Parse(lblrpraman.Text));
           decimal c = decimal.Parse(lbltpraman.Text);
            lblspercentage.Text = ((100 * a) / 3).ToString("00.00");
            lblrpercentage.Text = ((100 * b) / 2).ToString("00.00");
            lbltpercentage.Text = ((100 * c) / 1).ToString("00.00");


            
             clsAdmin frm1 = new clsAdmin(studid);
            DataTable dt1=new DataTable();

                dt1=frm1.Getvyaktitvank();
            
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    mark2 += Convert.ToInt32(dt1.Rows[i][2].ToString());

                }
                vyaktitvank = (mark2 - Convert.ToInt32(lblgadabadaank.Text));
                lblvyaktitwank.Text = vyaktitvank.ToString();
            chart2.Series["Ideal Satv"].Points.AddXY(1, 2.3, 3.75);
            chart2.Series["सत्व"].Points.AddXY(1.5, a);
            chart2.Series["Ideal Rajas"].Points.AddXY(3, 1.5, 2.5);
            chart2.Series["राजस"].Points.AddXY(3.5, b);
            chart2.Series["Ideal Tamas"].Points.AddXY(5, 0.7, 1.3);
            chart2.Series["तामस"].Points.AddXY(5.5, c);

            //chart3.Series["गडबडांक"].Points.AddXY(5, lblgadabadaank.Text);
            chart3.Series["P10"].Points.AddXY(1, 53);
            chart3.Series["Q1"].Points.AddXY(1, 11);
            chart3.Series["P40"].Points.AddXY(1, 8);
            chart3.Series["P60"].Points.AddXY(1, 8);
            chart3.Series["Q3"].Points.AddXY(1, 8);
            chart3.Series["P90"].Points.AddXY(1, 9);

            chart3.Series["व्यक्तित्वांक"].Points.AddXY(1, 0, lblvyaktitwank.Text);





            chart3.Series["P10"].Points.AddXY(3, 78);
            chart3.Series["Q1"].Points.AddXY(3, 18);
            chart3.Series["P40"].Points.AddXY(3, 9);
            chart3.Series["P60"].Points.AddXY(3, 14);
            chart3.Series["Q3"].Points.AddXY(3, 10);
            chart3.Series["P90"].Points.AddXY(3, 15);


            chart3.Series["सत्वांक"].Points.AddXY(3, 0, lblspercentage.Text);


            chart3.Series["P10"].Points.AddXY(5, 57);
            chart3.Series["Q1"].Points.AddXY(5, 13);
            chart3.Series["P40"].Points.AddXY(5, 12);
            chart3.Series["P60"].Points.AddXY(5, 14);
            chart3.Series["Q3"].Points.AddXY(5, 11);
            chart3.Series["P90"].Points.AddXY(5, 16);


            chart3.Series["राजसांक"].Points.AddXY(5, lblrpercentage.Text);


            chart3.Series["P10"].Points.AddXY(7, 13);
            chart3.Series["Q1"].Points.AddXY(7, 34);
            chart3.Series["P40"].Points.AddXY(7, 24);
            chart3.Series["P60"].Points.AddXY(7, 29);
            chart3.Series["Q3"].Points.AddXY(7, 20);
            chart3.Series["P90"].Points.AddXY(7, 41);


            chart3.Series["तामसांक"].Points.AddXY(7, lbltpercentage.Text);




            chart3.Series["P10"].Points.AddXY(9, 17);
            chart3.Series["Q1"].Points.AddXY(9, 4);
            chart3.Series["P40"].Points.AddXY(9, 3);
            chart3.Series["P60"].Points.AddXY(9, 5);
            chart3.Series["Q3"].Points.AddXY(9, 4);
            chart3.Series["P90"].Points.AddXY(9, 9);


            chart3.Series["गडबडांक"].Points.AddXY(9, lblgadabadaank.Text);


            lblfirstname.Text = firstname;
            lblage.Text = age;
            lblgender.Text=gender;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Resultgraph rg = new Resultgraph(lblspraman.Text, lblrpraman.Text, lbltpraman.Text);
            rg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            btnidealgraph.Visible = false;
            btnprint.Visible = false;
            int height = panel1.Height;
            int width = panel1.Width;
            panel1.Height = panel1.Height * panel1.Width ;
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
            panel1.Height = height;
            panel1.Width = width;
       //     printPreviewDialog1.Document = printDocument1;
       //    printDocument1.DefaultPageSettings = 
              printDialog1.Document = printDocument1;
             printDialog1.ShowDialog();
           // printPreviewDialog1.ShowDialog();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void lblage_Click(object sender, EventArgs e)
        {

        }

        private void lblgender_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
