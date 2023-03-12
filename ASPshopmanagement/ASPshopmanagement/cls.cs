using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ASPshopmanagement
{
    public class cls
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=ShoppingList;Integrated Security=True");
        public int TypeID { get; set; }
        public string Type { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SizeID { get; set; }
        public string Size { get; set; }
        public decimal MRP { get; set; }
        public decimal RealPRice { get; set; }
        public int RegisterId { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public Int64 Contact { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string PassWord { get; set; }
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int Discount { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public decimal discountPrice { get; set; }
        public bool isDelete { get; set; }

        public cls()
        { }


        public cls(string typename, string emailid, string pass)
        {
            TypeName = typename;
            EmailID = emailid;
            PassWord = pass;

        }
        public SqlDataReader btnLogin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserRegister", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "login detail");
            cmd.Parameters.AddWithValue("@TypeName", TypeName);
            cmd.Parameters.AddWithValue("@REmailId", EmailID);
            cmd.Parameters.AddWithValue("@RPass", PassWord);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();


        }
        public DataTable admin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserRegister", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Admin");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public DataTable Customer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserRegister", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "customergrd");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        //public DataTable Customer1()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("UserRegister", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "customergrd");

        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    adpt.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //    return dt;

        //    con.Close();
        //}
    }
}