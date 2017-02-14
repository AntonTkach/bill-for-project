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
            //TODO: convert to pdf and export
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