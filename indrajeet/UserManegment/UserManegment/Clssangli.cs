using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace UserManegment
{

    class Clssangli
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=vita;Integrated Security=True");


        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        

        public Clssangli()
        {

        }
            







     public Clssangli(string Name,string Address)
        {
            UserName = Name;
            UserAddress = Address;
        }
        public void Usersave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UName", UserName);
            cmd.Parameters.AddWithValue("@Uaddress", UserAddress);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //public void btnSave()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("insert into tblvita values('"+UserName+"','"+UserAddress+"')", con);
        //    cmd.ExecuteNonQuery();

        //    con.Close();
        //}
        public Clssangli(int Id)
        {
            UserId = Id;
        }
        public void deleteUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","delete");
            cmd.Parameters.AddWithValue("@Id", UserId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //public void btnDelete()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("delete from tblvita where UserId='"+UserId+"'", con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        public Clssangli(int Id,string Name,string Address)
        {
            UserId = Id;
            UserName = Name;
            UserAddress = Address;
        }
        public void UpdateUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Update");
            cmd.Parameters.AddWithValue("@Id", UserId);
            cmd.Parameters.AddWithValue("@UName", UserName);
            cmd.Parameters.AddWithValue("@Uaddress", UserAddress);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        //public void btnUpdate()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("update tblvita set UserName='"+UserName+"',UserAddress='"+UserAddress+"' where UserId='"+UserId+"'", con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        public DataTable GetUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowUser");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;


            con.Close();
        }
        public SqlDataReader GetShow()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "show");
            cmd.Parameters.AddWithValue("@Id", UserId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            
            
           
            con.Close();

        }
        
         

        



    }
}
