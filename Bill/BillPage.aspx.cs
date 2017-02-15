using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bill
{
    public partial class BillPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) // This page is an insystem. Nobody will ever see it. Probably.
        {
            //TODO: Gather all the info 
            //???
            //PROFIT
            NumberCounter.Text = NumberCounterIncrement().ToString();
            //TODO: conver data to HTML
            //TODO: convert to pdf and export
            // These links seem promising http://stackoverflow.com/questions/2057836/how-can-i-return-a-pdf-from-a-web-request-in-asp-net
            // http://wkhtmltopdf.org/index.html
            // http://stackoverflow.com/questions/564650/convert-html-to-pdf-in-net 
        }

        protected int NumberCounterIncrement()
        {
            //TODO: store to file and take from it
            int number = 0;
            number++;
            return number;
        }

        protected void NumberCounter_Load(object sender, EventArgs e)
        {

        }
    }

}