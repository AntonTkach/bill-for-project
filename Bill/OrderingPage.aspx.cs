using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bill
{
    public partial class CheckOutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCheckOut_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("PaymentMethods.aspx");
        }
    }
}