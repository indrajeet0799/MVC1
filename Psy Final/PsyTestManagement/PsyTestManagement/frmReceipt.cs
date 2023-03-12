using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.Admin;
using System.Data.SqlClient;

namespace TestManagement
{
    public partial class frmReceipt : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-B3UBKFN;Initial Catalog=TestManagement;Integrated Security=True");

        SqlCommand cmd;
        string sql;
        string InvoiceNo;
        int PaymentId;
        string Transid;
        Bitmap bmp;
        string StudentId;
        int TestPaperId;
        string PaymentMode;
        //int RegistrationFees;
        //int CouncelingFees;
        //int GST;
        //int Total;

        public frmReceipt(string Studentid, string Fullname, string AddressInfo, string CityName, string Pincode, string TestType, string TestPaperName, int Fees, string Transid, int TestPaperid,string paymentMode,int RegistrationFees,int CouncelingFees,int GST,int Total,string ReferenceName,string phone,string email)
        {
            InitializeComponent();
            
            lblStudentAddress.Text = AddressInfo;
            lblCityName.Text = CityName;
            lblPincode.Text = Pincode;
            lblTestType.Text = TestType;
            lblTestName.Text = TestPaperName;
            lblAmount.Text = Fees.ToString();
            //PaymentId = Paymentid;
            lblFullName.Text = Fullname;
            lblTransId.Text = Transid;
            lblStudId.Text = Studentid;
            TestPaperId = TestPaperid;
            PaymentMode = paymentMode;
            lblRegFees.Text = RegistrationFees.ToString();
            lblCouncelingFees.Text = CouncelingFees.ToString();
            lblGDS.Text = GST.ToString();
            lblTotal.Text = Total.ToString();
            lblReference.Text = ReferenceName;
            lblPhoneNo.Text = phone;
            lblEmail.Text = email;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentId = lblStudId.Text;
            int StatusId = 6;
            clsAdmin objAdmin = new clsAdmin(StudentId, TestPaperId, StatusId);
            objAdmin.UpdatePaymentStatusId();
            MessageBox.Show("Saved...");

            //clsAdmin objAdmin1 = new clsAdmin(Convert.ToInt32(StudentId), TestPaperId, lblTransId.Text, lblinvoiceNo.Text, Convert.ToInt32(StatusId).ToString(), lblAmount.Text, PaymentMode); 
            //objAdmin1.SavePaymentData();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            StudentId = lblStudId.Text;
            int StatusId = 6;
            clsAdmin objAdmin = new clsAdmin(StudentId, TestPaperId, StatusId);
            objAdmin.UpdatePaymentStatusId();


            btnPrint.Visible = false;
            clsAdmin objAdmin1 = new clsAdmin(StatusId, TestPaperId, lblTransId.Text, StudentId, lblinvoiceNo.Text, lblAmount.Text, PaymentMode); 
            objAdmin1.SavePaymentData();
            
            btnSave.Visible = false;

            //============= To Print the Receipt Form =============//        

            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            try
            {

                sql = "select max(InvoiceNo) from tblPayment";
                cmd = new SqlCommand(sql, con);
                con.Open();
                var maxInvoiceId = cmd.ExecuteScalar() as string;
                if (maxInvoiceId == null)
                {
                    InvoiceNo = "INRTS-000001";
                }
                else
                {
                    int intval = int.Parse(maxInvoiceId.Substring(6, 6));
                    intval++;
                    InvoiceNo = String.Format("INRTS-{0:000000}", intval);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblinvoiceNo.Text = InvoiceNo;
        }

    }
}
