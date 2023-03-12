using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPshopmanagement
{
    public partial class Customer1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            grdcustomer.DataSource = Session["Customer"];
            grdcustomer.DataBind();
        }
    }
}