using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPshopmanagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string Type = drpType.SelectedItem.ToString();
            string EmailID = txtEmailid.Text;
            string Password = txtpass.Text;
            // if (txtEmailid.Text != "" && txtpass.Text !="")
            // {
            cls obj = new cls(drpType.Text,txtEmailid.Text,txtpass.Text);
                SqlDataReader dr;
                dr = obj.btnLogin();
            // while (dr.Read())
            // {
            //  txtEmailid.Text = dr["EmailID"].ToString();
            // txtpass.Text = dr["Password"].ToString();
            if (dr.HasRows == true)
            {
                if (drpType.Text == "Customer")
                {
                    cls obj1 = new cls();
                    DataTable dt = new DataTable();
                    dt = obj1.Customer();


                    Session["tblProduct"] = dt;
                    // Response.Write("<script language='javascript'>alert('customer login successfull')</script>");
                    Response.Redirect("Admin");
                }
                else
                {

                }
                if (drpType.Text == "Admin")
                {
                    cls obj1 = new cls();
                    DataTable dt = new DataTable();
                    dt = obj1.admin();


                    Session["tblProduct"] = dt;
                    // Response.Write("<script language='javascript'>alert('customer login successfull')</script>");
                    Response.Redirect("Admin");
                }
                else
                {

                }
                dr.Close();






            }
        }
    }
}