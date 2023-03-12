using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;
namespace TestManagement.Admin
{
    public class clsAdmin
    {
        SqlConnection con = clsSqlConnection.con();
        public int StaffID { get; set; }
        public string StaffPosition { get; set; }
        public String StaffEmailID { get; set; }
        public string StaffPassword { get; set; }
        public int StudRegistrationId { get; set; }
        public DateTime StudRegistrationDate { get; set; }
        public string StaffName { get; set; }
        public Int64 PhoneNo { get; set; }
        public string Gender { get; set; }
        public string AddressInfo { get; set; }
        public int CityId { get; set; }
        public int StatusId { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int StateID { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public int isDelete { get; set; }
        public DateTime StaffRegistrationDate { get; set; }
        public string Status { get; set; }
        public string TestType { get; set; }
        public int TestPaperId { get; set; }
        public string TestName { get; set; }

        public string testtypeid { get; set; }
        public int TestTypeId { get; set; }
        public string TestPaperName { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        //public DateTime TestTypeRegistrationDate { get; set; }
       // public string TestPaperRegistrationDate { get; set; }
        public string Duration { get; set; }
        public int TotalMarks { get; set; }
        public int Fees { get; set; }
        public string QueType { get; set; }
        public string MarkingSystem { get; set; }
        public string BehaviorType { get; set; }
        public string QGroup { get; set; }
        public int QuestionNo { get; set; }

        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MotherName { get; set; }
        public string SchoolName { get; set; }
        public int QualificationId { get; set; }
        public int MediumId { get; set; }
        public decimal Percentage { get; set; }
        public DateTime StudentRegistrationDate { get; set; }
        public int StudentAge { get; set; }
        public DateTime DOB { get; set; }
        public string EmailID { get; set; }
        public String Contact { get; set; }
        public string Address { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public int PinCode { get; set; }
        public string FamilyType { get; set; }
        public string FamilyIncome { get; set; }
        public DateTime TestSubmittedDate { get; set; }
        public int age { get; set; }
        public string STD { get; set; }
        public string SocialType { get; set; }
        public string CollageName { get; set; }
        public string PaymentMode { get; set; }
        public string StudentName { get; set; }
        public int Pincode { get; set; }
     //   public DateTime PaymentDate { get; set; }
        public string InvoiceNo { get; set; }
        public int PaymentId { get; set; }
        public string TransactionId { get; set; }
        public string ConfirmPassword { get; set; }
        public int FeesStatusID { get; set; }
        public int TestStatusID { get; set; }

        public int Year { get; set; }
        public int Month { get; set; }
        public DateTime Year1 { get; set; }
        // public DateTime Month1 { get; set; }
        public string date { get; set; }
        public string Month2 { get; set; }
        public string Year2 { get; set; }
        public DateTime Month3 { get; set; }
        public DateTime Year3 { get; set; }

        public clsAdmin()
        {

        }
        //-------------------------------------Login------------------------------------//
        public clsAdmin( string staffemailID, string staffpassword)
        {         
            StaffEmailID = staffemailID;
            StaffPassword = staffpassword;
        }
        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Login");
    //        cmd.Parameters.AddWithValue("@staffposition",StaffPosition);
            cmd.Parameters.AddWithValue("@emailid", StaffEmailID);
            cmd.Parameters.AddWithValue("@password", StaffPassword);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }
        public clsAdmin(string staffemailID)
        {
            StaffEmailID = staffemailID;
        }
        public SqlDataReader Forgot_Pass()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Forgot");
            cmd.Parameters.AddWithValue("@emailid", StaffEmailID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }
        //--------------------------------Dashboard-----------------------------//
        public clsAdmin( string staffname, Int64 contactno,string addressinf, int cityid, int pincode)
        {
            
            StaffName = staffname;
            PhoneNo = contactno;
            AddressInfo = addressinf;
            CityId = cityid;
            PinCode = pincode;
        }
        public void UpdateProfile()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateProfile");
            cmd.Parameters.AddWithValue("@StaffName", StaffName);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@AddressInfo", AddressInfo);
            cmd.Parameters.AddWithValue("@CityId", CityId);
            cmd.Parameters.AddWithValue("@PINCode", PinCode);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //public clsAdmin(string confirmpass, int staffid)
        //{
        //    ConfirmPassword = confirmpass;
        //    StaffID = staffid;
        //}
        public DataTable ChangePassword()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ChangePassword");
            cmd.Parameters.AddWithValue("@ConfirmPassword", TestType);
            cmd.Parameters.AddWithValue("@StaffID", StatusId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataSet Chart()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Getgraph");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adpt.SelectCommand = cmd;
            adpt.Fill(ds);
            return ds;
            con.Close();

        }
        public SqlDataReader Daily_Client()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DailyClient");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }
        public SqlDataReader Daily_Test()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DailyTest");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }

        public SqlDataReader Monthly_Client()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "MonthlyClients");
            SqlDataReader dm;
            dm = cmd.ExecuteReader();
            return dm;

            con.Close();
        }
        public SqlDataReader Monthly_Test()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "MonthlyTests");
            SqlDataReader dm;
            dm = cmd.ExecuteReader();
            return dm;

            con.Close();
        }

        //--------------------------------------------------Student_Reg--------------------------------------------------------//
        public clsAdmin(string studentId, string firstName, string middleName, string lastname, string gender, DateTime dob, string emailID,
           string contact, string address, int cityId, int pincode, string mothername, string collagename, string schoolName, int qualificationId, int mediumId,
           decimal percentage, DateTime studentregistrationDate, int statusId, string testTypeId,
          string familytype, string familyincome, int Age1, string std, string socialtype,int isdelete)
        {
            StudentId = studentId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastname;
            Gender = gender;
            DOB = dob;
            EmailID = emailID;
            Contact = contact;
            Address = address;
            CityId = cityId;
            PinCode = pincode;
            MotherName = mothername;
            SchoolName = schoolName;
            QualificationId = qualificationId;
            MediumId = mediumId;
            Percentage = percentage;
            StudentRegistrationDate = studentregistrationDate;
            StatusId = statusId;
            testtypeid = testTypeId;
            //      TestSubmittedDate = testsubmitteddate;
            FamilyType = familytype;
            FamilyIncome = familyincome;
            age = Age1;
            STD = std;
            SocialType = socialtype;
            CollageName = collagename;
            isDelete = isdelete;
        }

        public void StudentRegistration()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "StudentRegistration");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@Middlename", MiddleName);
            cmd.Parameters.AddWithValue("@Lastname", LastName);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@emailid", EmailID);
            cmd.Parameters.AddWithValue("@Contactno", Contact);
            cmd.Parameters.AddWithValue("@AddressInfo", Address);
            cmd.Parameters.AddWithValue("@CityId", CityId);
            cmd.Parameters.AddWithValue("@PINCode", PinCode);
            cmd.Parameters.AddWithValue("@MotherName", MotherName);
            cmd.Parameters.AddWithValue("@collagename", CollageName);
            cmd.Parameters.AddWithValue("@SchoolName", SchoolName);
            cmd.Parameters.AddWithValue("@QualificationId", QualificationId);
            cmd.Parameters.AddWithValue("@MediumId", MediumId);
            cmd.Parameters.AddWithValue("@Percentage", Percentage);
            cmd.Parameters.AddWithValue("@studentregistrationdate", StudentRegistrationDate);
            cmd.Parameters.AddWithValue("@statusId", StatusId);
            cmd.Parameters.AddWithValue("@testTID", testtypeid);
            cmd.Parameters.AddWithValue("@FamilyType", FamilyType);
            cmd.Parameters.AddWithValue("@FamilyIncome", FamilyIncome);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@STD", STD);
            cmd.Parameters.AddWithValue("@SocialType", SocialType);
            cmd.Parameters.AddWithValue("@isDelete", isDelete);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader Above18Fetch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Above18Fetch");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }
        public SqlDataReader Below18Fetch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Above18Fetch");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }
        public DataTable TestList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "TestList");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable PaperList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "PaperList");
            cmd.Parameters.AddWithValue("@TestTypeId", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public SqlDataReader StudentCode()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "StudentID");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }
        public DataTable Qualification()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Qualification");
   //         cmd.Parameters.AddWithValue("@QualificationId", QualificationId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable Medium()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Medium");
            //         cmd.Parameters.AddWithValue("@QualificationId", QualificationId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsAdmin(string studentId, string mothername, string collagename,decimal percentage, int qualificationid)
        {
            StudentId = studentId;
            MotherName = mothername;
            CollageName = collagename;
            Percentage = percentage;
            QualificationId = qualificationid;
        }
        public void UpdateAForm()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "UpdateAForm");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@MotherName", MotherName);
            cmd.Parameters.AddWithValue("@collagename", CollageName);
            cmd.Parameters.AddWithValue("@Percentage", Percentage);
            cmd.Parameters.AddWithValue("@QualificationId", QualificationId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsAdmin(string studentID, string mothername, string schoolname, string std, decimal percentage, int mediumId)
        {
            StudentId = studentID;
            MotherName = mothername;
            SchoolName = schoolname;
            STD = std;
            Percentage = percentage;
            MediumId = mediumId;
        }
        public void UpdateBForm()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "UpdateBForm");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@MotherName", MotherName);
            cmd.Parameters.AddWithValue("@SchoolName", SchoolName);
            cmd.Parameters.AddWithValue("@STD", STD);
            cmd.Parameters.AddWithValue("@Percentage", Percentage);
            cmd.Parameters.AddWithValue("@MediumId", MediumId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsAdmin(string studentid,int testtypeid,int testpaperid,int teststatusid,int feesstatusid/*,DateTime testsubmitteddate*/)
        {
            StudentId = studentid;
            TestTypeId = testtypeid;
            TestPaperId = testpaperid;
            TestStatusID = teststatusid;
            FeesStatusID = feesstatusid;
         //   TestSubmittedDate = testsubmitteddate;
        }
        public void SuggestedSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SuggestedTest");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@TestTypeId", TestTypeId);
            cmd.Parameters.AddWithValue("@TestPaperId", TestPaperId);
            cmd.Parameters.AddWithValue("@statusId", TestStatusID);
            cmd.Parameters.AddWithValue("@statusfeesid", FeesStatusID);
    //        cmd.Parameters.AddWithValue("@TestSubmittedDate", TestSubmittedDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // ----------------------------------------------------Student_Info----------------------------------------------//
        public DataTable StudentInfoShow()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "StudentInfoShow");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //public ClsAdmin(int registrationid, int isdelete)
        //{
        //    RegistrationId = registrationid;
        //    IsDelete = isdelete;
        //}
        public void ISDelete()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Delete");
            cmd.Parameters.AddWithValue("@RegistrationId", TestPaperId);
            cmd.Parameters.AddWithValue("@isDelete", isDelete);
            // cmd.Parameters.AddWithValue("@RegistrationId", RegistrationId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsAdmin(string studentid, string firstname, string middlename, string lastname, string mothername, string emailid, string addressinfo, string schoolname, string familyincome, string contactno, decimal percentage, int cityid)
        {
            StudentId = studentid;
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
            MotherName = mothername;
            EmailID = emailid;
            AddressInfo = addressinfo;
            SchoolName = schoolname;
            FamilyIncome = familyincome;
            Contact = contactno;
            Percentage = percentage;
            CityId = cityid;
        }
        public void btnBUpdate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "BUpdate");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@MotherName", MotherName);
            cmd.Parameters.AddWithValue("@EmailId", EmailID);
            cmd.Parameters.AddWithValue("@AddressInfo", AddressInfo);
            cmd.Parameters.AddWithValue("@SchoolName", SchoolName);
            cmd.Parameters.AddWithValue("@FamilyIncome", FamilyIncome);
            cmd.Parameters.AddWithValue("@Contactno", Contact);
            cmd.Parameters.AddWithValue("@Percentage", Percentage);
            cmd.Parameters.AddWithValue("@CityId", CityId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsAdmin(string studentid, string firstname, string middlename, string lastname, string emailid, string addressinfo,string collagename, string familyincome, string contactno, decimal percentage, int cityid)
        {
            StudentId = studentid;
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
            EmailID = emailid;
            AddressInfo = addressinfo;
            CollageName = collagename;
            FamilyIncome = familyincome;
            Contact = contactno;
            Percentage = percentage;
            CityId = cityid;

        }
        public void btnAUpdate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AUpdate");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@EmailId", EmailID);
            cmd.Parameters.AddWithValue("@AddressInfo", AddressInfo);
            cmd.Parameters.AddWithValue("@collagename", CollageName);
            cmd.Parameters.AddWithValue("@FamilyIncome", FamilyIncome);
            cmd.Parameters.AddWithValue("@Contactno", Contact);
            cmd.Parameters.AddWithValue("@Percentage", Percentage);
            cmd.Parameters.AddWithValue("@CityId", CityId);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable below18gridview()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "below18 gridview");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable above18gridview()
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "above18 gridview");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        //    con.Close();
        }



        //------------------------------------------Staff_Info---------------------------------//
        public DataTable Country()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Country");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public clsAdmin(int countryid)
        {
            CountryID = countryid;
        }
        public DataTable State()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "State");
            cmd.Parameters.AddWithValue("@CountryId", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
       

        public DataTable City()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "City");
            cmd.Parameters.AddWithValue("@StateId", CountryID);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public clsAdmin(string staff,string staffname,Int64 phoneno,string emaliid,string gender,string addresinf,int cityid,int pincode,int statusid,string password,DateTime regitrationdate, int isdelete)
        {
            StaffPosition = staff;
            StaffName = staffname;
            PhoneNo=phoneno;
            StaffEmailID = emaliid;
            Gender = gender;    
            AddressInfo=addresinf;
            CityID= cityid;
            PinCode= pincode;
            StatusId= statusid;
            StaffPassword= password;
           StaffRegistrationDate = regitrationdate;
            isDelete = isdelete;


        }
        public void SaveStaffinformation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "StaffRegitration");
            cmd.Parameters.AddWithValue("@StaffPosition", StaffPosition);
            cmd.Parameters.AddWithValue("@StaffName", StaffName);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@EmailId", StaffEmailID);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@AddressInfo", AddressInfo);
            cmd.Parameters.AddWithValue("@CityId", CityID);
            cmd.Parameters.AddWithValue("@PINCode", PinCode);
            cmd.Parameters.AddWithValue("@StateId", StatusId);
            cmd.Parameters.AddWithValue("@Password", StaffPassword);
            cmd.Parameters.AddWithValue("@StaffRegistrationDate", StaffRegistrationDate);
            cmd.Parameters.AddWithValue("@isDelete", isDelete);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public DataTable grdView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GridViewStaff");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public clsAdmin(int Staffid,string staffposition,string staffinf,Int64 contactno,string email,string addressinf,int cityid,int pincode)
        {
            StaffID=Staffid;
            StaffPosition = staffposition;
            StaffName =staffinf;
            PhoneNo = contactno;
            StaffEmailID =email;
            AddressInfo=addressinf;
            CityId=cityid;
            PinCode=pincode;
        }
        public void btnUpdate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "update");
            cmd.Parameters.AddWithValue("@staffid", StaffID);
            cmd.Parameters.AddWithValue("@StaffPosition", StaffPosition);
            cmd.Parameters.AddWithValue("@StaffName", StaffName);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@EmailId", StaffEmailID);
            cmd.Parameters.AddWithValue("@AddressInfo", AddressInfo);
            cmd.Parameters.AddWithValue("@CityId", CityId);
            cmd.Parameters.AddWithValue("@PINCode", PinCode);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //public ClsAdmin(int Staffid)
        //{
        //    StaffId = Staffid;
        //    //isDelete = isdelete;

        //}
        public void btndelete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Delete");
            cmd.Parameters.AddWithValue("@StaffId", CountryID);
            cmd.Parameters.AddWithValue("@isDelete", isDelete);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //------------------------------------------Test_Management--------------------------------//
        public clsAdmin(string Testtype, int Statusid)
        {
            TestType = Testtype;
            StatusId = Statusid;
        }
        //public clsAdmin(string Testtype, string Testname)
        //{
        //    TestType = Testtype;
        //    TestName = Testname;
        //}
        public clsAdmin(int TestPaperid, int Isdelete)
        {
            TestPaperId = TestPaperid;
            isDelete = Isdelete;
        }
        //public DataTable GetStatus()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "GetStatus");
        //    cmd.Parameters.AddWithValue("@StatusId", StatusId);
        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    adpt.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //    return dt;
        //    con.Close();
        //}
        public void SaveTestType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveTestType");
            cmd.Parameters.AddWithValue("@TestType", TestType);
            cmd.Parameters.AddWithValue("@TestTypeRegistrationDate", Convert.ToDateTime(DateTime.Now.ToString()));
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetTestPaper()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestPaper");
    //        cmd.Parameters.AddWithValue("@TestPaperId", TestPaperId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetTestPaperbyType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestPaperbyType");
            cmd.Parameters.AddWithValue("@TestTypeId", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable ViewPaper()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewPaper");
            cmd.Parameters.AddWithValue("@TestPaperId", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void Delete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateIsDelete");
            cmd.Parameters.AddWithValue("@TestPaperId", CountryID);
            //cmd.Parameters.AddWithValue("@IsDelete", isDelete);           
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public clsAdmin(string testpapername, string duration, int marks, int statusid, int testpaperid)
        {
            TestPaperName = testpapername;
            Duration = duration;
            TotalMarks = marks;
            StatusId = statusid;
            TestPaperId = testpaperid;

        }
        //public clsAdmin(int testtypeid)
        //{
        //    TestTypeId = testtypeid;
        //}
        //public clsAdmin(string testpapername)
        //{
        //    TestPaperName = testpapername;
        //}
        public clsAdmin(string testpapername, int testtypeid, string duration, int totalmarks, int statusid,int Isdelete)
        {
            // TestPaperId=testpaperid;    
            TestPaperName = testpapername;
            TestTypeId = testtypeid;
            Duration = duration;
            TotalMarks = totalmarks;
            StatusId = statusid;
            isDelete = Isdelete;


        }
        public clsAdmin(int testpaperid, int questionno, string behaviortype, string markingsystem, string quetype, string qgroup, string que)
        {
            TestPaperId = testpaperid;
            QuestionNo = questionno;
            BehaviorType = behaviortype;
            MarkingSystem = markingsystem;
            QueType = quetype;
            QGroup = qgroup;

            Question = que;

        }

        public clsAdmin(int questionno, string behaviortype, string markingsystem, string quetype, string qgroup, string que, int queId)
        {
            QuestionNo = questionno;
            BehaviorType = behaviortype;
            MarkingSystem = markingsystem;
            QueType = quetype;
            QGroup = qgroup;

            Question = que;
            QuestionId = queId;

        }

        public DataTable GetTestType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Flag", "GetTestType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetTestPapers()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestPaper");
            cmd.Parameters.AddWithValue("@TestTypeId", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        
        public void SaveTestPaper()
        {
            con.Open();

            SqlCommand cmd1 = new SqlCommand("SPTMAdmin", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Flag", "SaveTestPaper");
            cmd1.Parameters.AddWithValue("@TestPaperName", TestPaperName);
            cmd1.Parameters.AddWithValue("@TestTypeId", TestTypeId);
            cmd1.Parameters.AddWithValue("@Duration", Duration);
            cmd1.Parameters.AddWithValue("@TotalMarks", TotalMarks);
            cmd1.Parameters.AddWithValue("@StatusId", StatusId);
            cmd1.Parameters.AddWithValue("@IsDeleted", isDelete);
            cmd1.Parameters.AddWithValue("TestPaperRegistrationDate", Convert.ToDateTime(DateTime.Now.ToString()));
            cmd1.ExecuteNonQuery();
            con.Close();

        }

        public void SaveQuestion()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveQuestion");
            cmd.Parameters.AddWithValue("@QuestionNo", QuestionNo);
            cmd.Parameters.AddWithValue("@TestPaperId", TestPaperId);
            cmd.Parameters.AddWithValue("@BehaviorType", BehaviorType);
            cmd.Parameters.AddWithValue("@MarkingSystem", MarkingSystem);
            cmd.Parameters.AddWithValue("@QueType", QueType);
            cmd.Parameters.AddWithValue("@QGroup", QGroup);

            cmd.Parameters.AddWithValue("@Question", Question);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable GetQuestion()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetQuestion");
            cmd.Parameters.AddWithValue("@TestPaperId", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public void DeleteQuestion()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteQuestion");
            cmd.Parameters.AddWithValue("@QuestionId", CountryID);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void EditQuestion()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EditQuestion");
            // cmd.Parameters.AddWithValue("@TestPaperId", TestPaperId);
            cmd.Parameters.AddWithValue("@QuestionNo", QuestionNo);
            cmd.Parameters.AddWithValue("@BehaviorType", BehaviorType);
            cmd.Parameters.AddWithValue("@MarkingSystem", MarkingSystem);
            cmd.Parameters.AddWithValue("@QueType", QueType);
            cmd.Parameters.AddWithValue("@QGroup", QGroup);

            cmd.Parameters.AddWithValue("@Question", Question);
            cmd.Parameters.AddWithValue("@QuestionId", QuestionId);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable GetStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStatus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsAdmin(int testpaperid, string behaviourtype, string quetype, string qgroup)
        {
            TestPaperId = testpaperid;
            BehaviorType = behaviourtype;
            QueType = quetype;
            QGroup = qgroup;
        }
        public SqlDataReader GETDATA()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GETDATA");
            cmd.Parameters.AddWithValue("@BehaviorType", BehaviorType);
            cmd.Parameters.AddWithValue("@QueType", QueType);
            cmd.Parameters.AddWithValue("@QGroup", QGroup);
            cmd.Parameters.AddWithValue("@TestPaperId", TestPaperId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }
        public SqlDataReader GetTestPaperId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestpaperId");
            cmd.Parameters.AddWithValue("@TestPaperName", StaffEmailID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }
        public DataTable GetTestPaperDet()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestPaperDet");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public SqlDataReader GetTestPaperDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestPaperDetails");
            cmd.Parameters.AddWithValue("@TestPaperId", CountryID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();

        }
        public void EditTestPaper()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EditTestPaper");
            cmd.Parameters.AddWithValue("@TestPaperName", TestPaperName);
            cmd.Parameters.AddWithValue("@Duration", Duration);
            cmd.Parameters.AddWithValue("@TotalMarks", TotalMarks);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@TestPaperId", TestPaperId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       
        //------------------------------------------------Result--------------------------------------------------------//
        public DataTable Getsum()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "getsum");
            cmd.Parameters.AddWithValue("@StudentId", StaffEmailID);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
            con.Close();


        }
        public DataTable Getvyaktitvank()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "getvyaktitvank");
            cmd.Parameters.AddWithValue("@StudentId", StaffEmailID);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            return dt1;
            con.Close();

        }
        public DataTable getclientresult()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "clientresult");
           
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
            con.Close();
        }
        public void Deleteresult()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteResult");
            cmd.Parameters.AddWithValue("@StudentId", StaffEmailID);
           // cmd.Parameters.AddWithValue("@isDelete", isDelete);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //------------------------------------------------------Reports-------------------------------------------------------//

        //public clsAdmin(int month1, int Year1)
        //{
        //    Month = month1;
        //    Year = Year1;
        //}
        public clsAdmin(DateTime month3, DateTime year3)
        {
            Month3 = month3;
            Year3 = year3;
        }
        //public clsAdmin(string month2, string year2)
        //{
        //    Month2 = month2;
        //    Year2 = year2;
        //}
        public clsAdmin(DateTime year1)
        {
            //Month1 = month1;
            Year1 = year1;
        }
        // public clsAdmin(int year1)
        // {
        //     Year = year1;
        // }

        // public clsAdmin()
        // {

        // }
        //public clsAdmin(string date1)
        //{
        //    date = date1;
        //}
        public DataTable dailytesttype()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Testtypedaily");
            cmd.Parameters.AddWithValue("@inputyear1", Year1);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable monthlytesttype()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Testtypemonthly");
            cmd.Parameters.AddWithValue("@inputmonth", TestPaperId);
            cmd.Parameters.AddWithValue("@inputyear", isDelete);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable yearlytesttype()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Testtypeyearly");
            //cmd.Parameters.AddWithValue("@inputmonth", Month);
            cmd.Parameters.AddWithValue("@inputyear", isDelete);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }


        //// for monthly Test Type
        // public DataTable monttesttype()
        // {
        //     con.Open();
        //     SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
        //     cmd.CommandType = CommandType.StoredProcedure;
        //     cmd.Parameters.AddWithValue("@Flag", "Testtype");
        //     cmd.Parameters.AddWithValue("@inputmonth", Month);
        //     cmd.Parameters.AddWithValue("@inputyear", Year);
        //     SqlDataReader dr = cmd.ExecuteReader();
        //     DataTable dt = new DataTable();
        //     dt.Load(dr);
        //     return dt;

        // }
        public DataTable dailypayment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Dailypayment");
            cmd.Parameters.AddWithValue("@inputmonth1", Month3);
            cmd.Parameters.AddWithValue("@inputyear1", Year3);
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            // dt.Load(dr);
            adpt.Fill(dt);
            return dt;

        }
        public DataTable dailyagetypetest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Agetypedaily");
            //cmd.Parameters.AddWithValue("@inputmonth", Month);
            cmd.Parameters.AddWithValue("@inputyear1", Year1);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable monthlyagetypetest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AgetypeMonthly");
            cmd.Parameters.AddWithValue("@inputmonth", TestPaperId);
            cmd.Parameters.AddWithValue("@inputyear", isDelete);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable yearlyagetypetest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AgetypeYearly");
            //cmd.Parameters.AddWithValue("@inputmonth", Month);
            cmd.Parameters.AddWithValue("@inputyear", isDelete);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable dailypaymentgraph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "dailipayment");
            //cmd.Parameters.AddWithValue("@inputmonth", Month);
            cmd.Parameters.AddWithValue("@inputyear1", Year1);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable monthlypaymentgraph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "MonthlyPayment");
            cmd.Parameters.AddWithValue("@inputmonth", TestPaperId);
            cmd.Parameters.AddWithValue("@inputyear", isDelete);
            SqlDataAdapter adpt = new SqlDataAdapter()
;
            adpt.SelectCommand = cmd;
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            //dt.Load(dr);
            adpt.Fill(dt);
            return dt;
        }
        public DataTable yearlypaymentgraph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "YearlyPayment");
            //cmd.Parameters.AddWithValue("@inputmonth", Month);
            cmd.Parameters.AddWithValue("@inputyear", isDelete);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        //public DataTable dailyabove18maxtest()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "dailipayment");
        //    //cmd.Parameters.AddWithValue("@inputmonth", Month);
        //    cmd.Parameters.AddWithValue("@inputyear1", Year1);

        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);
        //    return dt;
        //}
        //public DataTable monthlyabove18maxtest()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "MonthlyPayment");
        //    cmd.Parameters.AddWithValue("@inputmonth", Month);
        //    cmd.Parameters.AddWithValue("@inputyear", Year);

        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);
        //    return dt;
        //}
        //public DataTable yearlyabove18maxtest()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "YearlyPayment");
        //    //cmd.Parameters.AddWithValue("@inputmonth", Month);
        //    cmd.Parameters.AddWithValue("@inputyear", Year);

        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);
        //    return dt;
        //}

        // public SqlDataReader Payment()
        // {
        //     con.Open();
        //     SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
        //     cmd.CommandType = CommandType.StoredProcedure;
        //     cmd.Parameters.AddWithValue("@Flag", "Dailysum");
        //     cmd.Parameters.AddWithValue("@inputmonth2", Month2);
        //     cmd.Parameters.AddWithValue("@inputyear2", Year2);
        //     SqlDataReader dr;
        //     dr = cmd.ExecuteReader();
        //     return dr;

        // }

        // public DataTable monthlypayment()
        // {
        //     con.Open();
        //     SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
        //     cmd.CommandType = CommandType.StoredProcedure;
        //     cmd.Parameters.AddWithValue("@Flag", "MonthlyPayment");
        //     cmd.Parameters.AddWithValue("@inputyear", Year);
        //     SqlDataAdapter adpt = new SqlDataAdapter();
        //     adpt.SelectCommand = cmd;
        //     DataTable dt = new DataTable();
        //     adpt.Fill(dt);
        //     return dt;
        // }
        // public DataTable Yearlypayment()
        // {
        //     con.Open();
        //     SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
        //     cmd.CommandType = CommandType.StoredProcedure;
        //     cmd.Parameters.AddWithValue("@Flag", "YearlyPayment");
        //     cmd.Parameters.AddWithValue("@inputyear", Year);
        //     SqlDataAdapter adpt = new SqlDataAdapter();
        //     adpt.SelectCommand = cmd;
        //     DataTable dt = new DataTable();
        //     adpt.Fill(dt);
        //     return dt;
        // }
        // public DataTable Agetype()
        // {
        //     con.Open();
        //     SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
        //     cmd.CommandType = CommandType.StoredProcedure;
        //     cmd.Parameters.AddWithValue("@Flag", "Agetype");
        //     cmd.Parameters.AddWithValue("@inputyear", Year);
        //     SqlDataReader dr = cmd.ExecuteReader();
        //     DataTable dt = new DataTable();
        //     dt.Load(dr);
        //     return dt;

        // }
        //----------------------------------------------------Payment-------------------------------------//
        public clsAdmin(string fullName, string testName, int fees, string paymentMode)
        {
            //============ This Constructor for frmAddPayment ================//

            StudentName = fullName;
            TestName = testName;
            Fees = fees;
            PaymentMode = paymentMode;
        }

        public DataTable GetUnPaidPayment()
        {
            //============= To Show Data in DataGridView =============//

            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetUnPaidPayment");
            cmd.Parameters.AddWithValue("@PaymentDate", Convert.ToDateTime(DateTime.Now.ToString()));
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }


        public SqlDataReader GetReceipt()
        {
            //============ To Fetch Data for frmReceipt ================//

            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetReceipt");
            cmd.Parameters.AddWithValue("@StudentId", StaffEmailID);
            cmd.Parameters.AddWithValue("@TestPaperName", StaffPassword);
            //cmd.Parameters.AddWithValue("@PaymentDate", Convert.ToDateTime(DateTime.Now.ToString()));
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            //con.Close();
        }

        public void SavePaymentData()
        {
            //============ To Update Payment Status in DataTable ================//

            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SavePaymentData");
            cmd.Parameters.AddWithValue("@StudentId", MarkingSystem); 
            cmd.Parameters.AddWithValue("@TestPaperId", QuestionNo);
            cmd.Parameters.AddWithValue("@TransactionId", BehaviorType);
            cmd.Parameters.AddWithValue("@Fees", QGroup); 
            cmd.Parameters.AddWithValue("@InvoiceNo", QueType);
            cmd.Parameters.AddWithValue("@StatusId", TestPaperId); 
            cmd.Parameters.AddWithValue("@PaymentMode", BehaviorType); 
            cmd.Parameters.AddWithValue("@PaymentDate", Convert.ToDateTime(DateTime.Now.ToString()));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsAdmin(string studentId, int testPaperId, int statusId)
        {
            StudentId = studentId;
            TestPaperId = testPaperId;
            StatusId = statusId;
        }
        public void UpdatePaymentStatusId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdatePaymentStatusId");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@TestPaperId", TestPaperId);
            cmd.Parameters.AddWithValue("@FeesStatusID", StatusId);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable GetPaidPayment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPaidPayment");
            cmd.Parameters.AddWithValue("@PaymentDate", Convert.ToDateTime(DateTime.Now.ToString()));
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            //con.Close();

        }
    }
}
