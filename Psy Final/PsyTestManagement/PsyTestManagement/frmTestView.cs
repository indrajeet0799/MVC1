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
using Font = System.Drawing.Font;
using System.IO;
using System.Net;
using System.Net.Mail;
using Rectangle = System.Drawing.Rectangle;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Security.AccessControl;
using PSYTestManagement;
using DGVPrinterHelper;
using Image = System.Drawing.Image;

//using System.Drawing.Imaging;
//using System.Drawing.Printing;



namespace PSYTestManagement
{
    public partial class frmTestView : Form

    {   public int TestpaperId { get; set; }
        private int _Line = 0;

        
        Bitmap bitmap;


        public frmTestView()
        {
            InitializeComponent();
        }
        public frmTestView(int testpaperid, string testpaper, string papername, int marks, string time)
        {
            InitializeComponent();
            TestpaperId = testpaperid;
            lblTesttype.Text = testpaper;
            lblPapername.Text = papername;
            lblmarks.Text = marks.ToString();
            lbltime.Text = time;
        }


        public void View_Load(object sender, EventArgs e)
        {

            clsAdmin view = new clsAdmin(TestpaperId);
            DataTable dt = new DataTable();
            dt = view.ViewPaper();
            dtgrdQuestions.DataSource = dt;
            dtgrdQuestions.Show();

            //View obj = new View();
            //DataTable dt1 = new DataTable();
            //dt1 = obj.Pdf();


            DataGridViewTextBoxColumn objcol4 = new DataGridViewTextBoxColumn();
            objcol4.DataPropertyName = "नेहमीच ";
            objcol4.Name = "नेहमीच";
            dtgrdQuestions.Columns.Add(objcol4);
            dtgrdQuestions.Columns[2].Width = 60;

            DataGridViewTextBoxColumn objcol3 = new DataGridViewTextBoxColumn();
            objcol3.DataPropertyName = "बऱ्याचदा ";
            objcol3.Name = "बऱ्याचदा";
            dtgrdQuestions.Columns.Add(objcol3);
            dtgrdQuestions.Columns[3].Width = 60;

            DataGridViewTextBoxColumn objcol2 = new DataGridViewTextBoxColumn();
            objcol2.DataPropertyName = "कधीतरी ";
            objcol2.Name = "कधीतरी";
            dtgrdQuestions.Columns.Add(objcol2);
            dtgrdQuestions.Columns[4].Width = 60;

            DataGridViewTextBoxColumn objcol = new DataGridViewTextBoxColumn();
            
            objcol.DataPropertyName = "कधीचनाही ";
            objcol.Name = "कधीचनाही";
            dtgrdQuestions.Columns.Add(objcol);
            dtgrdQuestions.Columns[5].Width = 70;

            DataGridViewTextBoxColumn objcol5 = new DataGridViewTextBoxColumn();
            objcol5.DataPropertyName = "गुण १";
            objcol5.Name = "गुण १";
            dtgrdQuestions.Columns.Add(objcol5);
            dtgrdQuestions.Columns[6].Width = 45;

            DataGridViewTextBoxColumn objcol6 = new DataGridViewTextBoxColumn();
            objcol6.DataPropertyName = "गुण २";
            objcol6.Name = "गुण २";
            dtgrdQuestions.Columns.Add(objcol6);
            dtgrdQuestions.Columns[7].Width = 45;

            this.dtgrdQuestions.DefaultCellStyle.Font = new Font("Arial", 14);
            this.dtgrdQuestions.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);

            dtgrdQuestions.Columns[0].Width = 45;
            dtgrdQuestions.Columns[1].Width = 260;
            //dtgrdQuestions.Columns[2].Width = 35;
            //dtgrdQuestions.Columns[3].Width = 35;
            //dtgrdQuestions.Columns[4].Width = 35;
            //dtgrdQuestions.Columns[5].Width = 35;
            //dtgrdQuestions.Columns[6].Width = 35;
            //dtgrdQuestions.Columns[7].Width = 35;



        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Time:" + " " + lbltime.Text + "  " + "  "+  lblPapername.Text + "Marks:" + " " + lblmarks.Text;
            printer.SubTitle = lblInstructions.Text;
            printer.SubTitleAlignment = StringAlignment.Near;
            //printer.SubTitle = lblmarks.Text;
            //printer.SubTitle = lbltime.Text;
            // printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "TestManagement";
            printer.FooterSpacing = 5;
          
            printer.PrintDataGridView(dtgrdQuestions);
            
        }
       
        



        private void lblmarks_Click(object sender, EventArgs e)
        {

        }

        private void dtgrdQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgrdQuestions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //var width = 50;
            //foreach (DataGridViewColumn dr in dtgrdQuestions.Columns)
            //{
            //    Width += dr.Width;
            //}
            //dtgrdQuestions.Height = Height;


            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

        
    

    }

    

