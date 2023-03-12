using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections;

namespace TestManagement.Client
{
    public class clsClient
    {
        SqlConnection con = clsSqlConnection.con();
        public string TestName { get; set; }

        public int TestTypeId { get; set; }

        public string Duration { get; set; }

        public int TotalMarks { get; set; }

        public int QuesId { get; set; }

        public string Question { get; set; }

        public string BehaviorTYpe { get; set; }

        public int Ans { get; set; }

        public string Type { get; set; }

        public int Qgroup { get; set; }

        public int Mark1 { get; set; }

        public int Mark2 { get; set; }

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
        public string Gender { get; set; }
        public int CityId { get; set; }
        public int StatusId { get; set; }
        public int isDelete { get; set; }
        public int testtid { get; set; }
        public string CollageName { get; set; }
        public int TestPaperId { get; set; }
        public int TestStatusID { get; set; }
        public int FeesStatusID { get; set; }


        public clsClient()
        {

        }
        public clsClient(int tid)
        {
            testtid = tid;
        }
        public clsClient(string studentId, string firstName, string middleName, string lastname, string gender, DateTime dob, string emailID,
          string contact, string address, int cityId, int pincode, string mothername, string collagename, string schoolName, int qualificationId, 
          int mediumId, decimal percentage, DateTime studentregistrationDate, int statusId, string familytype, string familyincome, int Age1,
          string std, string socialtype, int isdelete)
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
            CollageName = collagename;
            SchoolName = schoolName;
            QualificationId = qualificationId;
            MediumId = mediumId;
            Percentage = percentage;
            StudentRegistrationDate = studentregistrationDate;
            StatusId = statusId;
            FamilyType = familytype;
            FamilyIncome = familyincome;
            age = Age1;
            STD = std;
            SocialType = socialtype;
            isDelete = isdelete;
        }
        public void StudentRegistration()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "StudentRegisration");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@Middlename", MiddleName);
            cmd.Parameters.AddWithValue("@Lastname", LastName);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@emailid", EmailID);
            cmd.Parameters.AddWithValue("@Contactno", Contact);
      //      cmd.Parameters.AddWithValue("@AddressInfo", Address);
      //      cmd.Parameters.AddWithValue("@CityId", CityId);
      //      cmd.Parameters.AddWithValue("@PINCode", PinCode);
      //      cmd.Parameters.AddWithValue("@MotherName", MotherName);
      //      cmd.Parameters.AddWithValue("@collagename", CollageName);
      //      cmd.Parameters.AddWithValue("@SchoolName", SchoolName);
      //      cmd.Parameters.AddWithValue("@QualitificationId", QualificationId);
      //      cmd.Parameters.AddWithValue("@MediumId", MediumId);
      //      cmd.Parameters.AddWithValue("@Percentage", Percentage);
            cmd.Parameters.AddWithValue("@studentregistrationdate", StudentRegistrationDate);
           cmd.Parameters.AddWithValue("@statusId", StatusId);
            cmd.Parameters.AddWithValue("@FamilyType", FamilyType);
            cmd.Parameters.AddWithValue("@FamilyIncome", FamilyIncome);
           cmd.Parameters.AddWithValue("@Age", age);
     //       cmd.Parameters.AddWithValue("@STD", STD);
            cmd.Parameters.AddWithValue("@SocialType", SocialType);
            cmd.Parameters.AddWithValue("@IsDeleted", isDelete);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsClient(string studentid, int testtypeid, int testpaperid, int teststatusid, int feesstatusid/*,DateTime testsubmitteddate*/)
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
        public SqlDataReader StudentCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "StudentCode");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }
        public DataTable PaperList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "PaperList");
            cmd.Parameters.AddWithValue("@TestTypeId", testtid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable TestList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "TestType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable Testpapercmb()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TestPaperName");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsClient(string studentid)
        {
            StudentId = studentid;

        }
        public SqlDataReader GetID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetID");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }
        public DataTable GetQuestion()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetQuestion");
            cmd.Parameters.AddWithValue("@TestPaperId", testtid);
            //cmd.Parameters.AddWithValue("@Question", Question);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtQue = new DataTable();
            adpt.Fill(dtQue);
            return dtQue;
            con.Close();
        }
        public clsClient(string StudId, int QueId, string BehaviorType, int ans, int mark1, int mark2, DateTime testSubmittedDate)
        {
            StudentId = StudId;
            QuesId = QueId;
            BehaviorTYpe = BehaviorType;
            Ans = ans;
            Mark1 = mark1;
            Mark2 = mark2;
            TestSubmittedDate = testSubmittedDate;
        }

        public void SaveAns()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "getdata");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@QueId", QuesId);
            cmd.Parameters.AddWithValue("@BehaviorType", BehaviorTYpe);
            cmd.Parameters.AddWithValue("@Ans", Ans);
            cmd.Parameters.AddWithValue("@Mark1", Mark1);
            cmd.Parameters.AddWithValue("@Mark2", Mark2);
            cmd.Parameters.AddWithValue("@TestSubmittedDate", TestSubmittedDate);

            SqlDataReader dr1;
            dr1 = cmd.ExecuteReader();

            if (dr1.HasRows == true)
            {
                dr1.Close();

                SqlCommand cmd2 = new SqlCommand("SPTMClient", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@Flag", "UpdateAans");
                cmd2.Parameters.AddWithValue("@QueId", QuesId);
                cmd2.Parameters.AddWithValue("@Ans", Ans);
                cmd2.Parameters.AddWithValue("@Mark1", Mark1);
                cmd2.Parameters.AddWithValue("@Mark2", Mark2);
                cmd2.ExecuteNonQuery();

                con.Close();

            }

            else
            {

                dr1.Close();

                SqlCommand cmd1 = new SqlCommand("SPTMClient", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@Flag", "SaveAns");
                cmd1.Parameters.AddWithValue("@StudentId", StudentId);
                cmd1.Parameters.AddWithValue("@QueId", QuesId);
                cmd1.Parameters.AddWithValue("@BehaviorType", BehaviorTYpe);
                cmd1.Parameters.AddWithValue("@Ans", Ans);
                cmd1.Parameters.AddWithValue("@Mark1", Mark1);
                cmd1.Parameters.AddWithValue("@Mark2", Mark2);
                cmd1.Parameters.AddWithValue("@TestSubmittedDate", TestSubmittedDate);
                cmd1.ExecuteNonQuery();
                con.Close();
            }


        }
        public clsClient(string testPaperName, string duration, int totalMarks)
        {
            testPaperName = TestName;
            duration = Duration;
            totalMarks = TotalMarks;
        }
        public DataTable GetTest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTest");
            //cmd.Parameters.AddWithValue("@TestName", TestName);
            cmd.Parameters.AddWithValue("@Duration", Duration);
            cmd.Parameters.AddWithValue("@TotalMarks", TotalMarks);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public clsClient(int Queid, int ans)
        {
            QuesId = QuesId;
            Ans = ans;
            //Mark1=mark1;
            //Mark2=mark2;
        }

        public void UpdateAans()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateAans");
            cmd.Parameters.AddWithValue("@QueId", QuesId);
            cmd.Parameters.AddWithValue("@Ans", Ans);
            cmd.Parameters.AddWithValue("@Mark1", Mark1);
            cmd.Parameters.AddWithValue("@Mark2", Mark2);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public SqlDataReader GetPaymentD()
        {
            //============= To Show Data in DataGridView =============//

            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPaymentD");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        public DataTable gettesttype()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "gettesttype");
            cmd.Parameters.AddWithValue("@TestTypeId", testtid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
        public clsClient(string studentid,int statusid,DateTime testSubmittedDate)
        {
            StudentId = studentid;
            StatusId = statusid;
            TestSubmittedDate = testSubmittedDate;
        }
        public void submittedDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTMClient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TestSubmittedDate");
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@TestSubmittedDate", TestSubmittedDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
