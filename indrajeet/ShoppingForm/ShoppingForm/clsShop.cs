using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;

namespace ShoppingForm
{
     class clsShop
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=ShoppingList;Integrated Security=True");

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SizeId { get; set; }
        public decimal MRP { get; set; }
        public decimal RealPrice { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public int ContactNo { get; set; }
        public string Gender  { get; set; }
        public string State { get; set; }
        public string Password { get; set; }
       
        




        public clsShop()
        { }
       
        
        public clsShop(int Id)
        {
            TypeId = Id;        
        }

      public clsShop(string Name)
        {
            TypeName = Name;
        }
        public void btnSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Usershopping", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveType");
            cmd.Parameters.AddWithValue("@TypeName", TypeName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Usershopping",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveProduct");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsShop(string Name, int Id)
        {
            ProductName = Name;
            TypeId = Id;
        }
        public void btnSaveProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Usershopping", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "productName");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.ExecuteNonQuery();
            
            con.Close();
        }
        public DataTable getSizeType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Usershopping",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SizeType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public DataTable getSizeProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Usershopping", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag ", "GetSizeProduct");
            cmd.Parameters.AddWithValue("@TypeId",TypeId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        
        public clsShop( string Name, decimal mrp, decimal Price,int TId,int PId)

        {
            Size = Name;
            MRP = mrp;
            RealPrice = Price;          
            TypeId = TId;
            ProductId = PId;
        }
        public void btnSaveSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Usershopping", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "sizeDetail");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@Size",Size);
            cmd.Parameters.AddWithValue("@MRP",MRP);
            cmd.Parameters.AddWithValue("@RealPrice", RealPrice);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public clsShop(string type,string name,string email,string statename,string pass,string gender,int number)
        {
            
            Type = type;
            Name = name;
            EmailID = email;
            State = statename;
            Password = pass;
            Gender = gender;
            
         
            ContactNo = number;
        }
        public void btnRegister()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Usershopping", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "RegisterUser");
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@EmailID", EmailID);
            cmd.Parameters.AddWithValue("@ContactNo",ContactNo);
            cmd.Parameters.AddWithValue("@Gender",Gender);
            cmd.Parameters.AddWithValue("@State",State);
            cmd.Parameters.AddWithValue("@Password",Password);
            cmd.ExecuteNonQuery();


            con.Close();
        }

        

        

        


    }
    
}
