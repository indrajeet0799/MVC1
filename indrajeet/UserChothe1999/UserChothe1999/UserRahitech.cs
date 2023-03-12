using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace UserChothe1999
{
    class UserRahitech
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=Chothe1999;Integrated Security=True");


        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserVillege { get; set; }
        public string UserTalukha { get; set; }

        public UserRahitech()
        {

        }



        public UserRahitech( string Name,string Villege,string Talukha)
        {
           
            UserName = Name;
            UserVillege = Villege;
            UserTalukha = Talukha;

        }

        public void ShowUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserRahitech", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowUser");
            cmd.Parameters.AddWithValue("@Uname", UserName);
            cmd.Parameters.AddWithValue("@Uvillege", UserVillege);
            cmd.Parameters.AddWithValue("@Utalukha",UserTalukha);
            cmd.ExecuteNonQuery();
            
            



            con.Close();
        }
            





    // public void btnShow()
       // {
       //     con.Open();
       //     SqlCommand cmd = new SqlCommand("insert into tblInformationChothe1999 values ('"+UserName+"','"+UserVillege+"','"+UserTalukha+"')", con);
       //     cmd.ExecuteNonQuery();


       //     con.Close();
       // }
        
       public UserRahitech(int Id)
       {
            UserId = Id;
       }
        public void DeleteUser()
        {
          con.Open();
          SqlCommand cmd = new SqlCommand("UserRahitech", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","DeleteUser");
            
           cmd.Parameters.AddWithValue("@Id", UserId);
            cmd.ExecuteNonQuery();


            


            con.Close();
        }
            
        
        
            
        


      // public void btnDelete()
      // {
       //    con.Open();
       //    SqlCommand cmd = new SqlCommand("delete from tblInformationChothe1999 where UserId=("+UserId+")",con);
        //   cmd.ExecuteNonQuery();

         //  con.Close();
       // }
            
       public UserRahitech (int Id, string Name,string Villege,string Talukha)
       {
           UserId = Id;
           UserName = Name;
            UserVillege = Villege;
           UserTalukha = Talukha;
        }

        public void UpdateUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserRahitech",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateUser");
            cmd.Parameters.AddWithValue("@Id", UserId);
            cmd.Parameters.AddWithValue("@Uname", UserName);
            cmd.Parameters.AddWithValue("@Uvillege", UserVillege);
            cmd.Parameters.AddWithValue("@Utalukha", UserTalukha);
            
            cmd.ExecuteNonQuery();


            con.Close();
        }
            
       // public void btnUpdate()
       // {
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("update tblInformationChothe1999 set UserName='"+UserName+"',UserVillage='"+UserVillege+"',UserTalukha= '"+UserTalukha+"' where UserId='"+UserId+"'",con);
         //   cmd.ExecuteNonQuery();


         //   con.Close();
       // }

        public DataTable GetUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserRahitech", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","SaveUser");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

            con.Close();
        }
        public SqlDataReader GetShow()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserRahitech", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveUser");
            cmd.Parameters.AddWithValue("@Id",UserId);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
            
            
                
            
        }



    }
            

        


    
}
