using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bill.Models
{
    public class OrderLine : BaseOrderLine
    {
        private static string id;
        public static  string BillID
        {
            get { return string.IsNullOrEmpty(id) ? string.Empty : id; }
            set { id = value; }
        }
        private static string orderid; // нам это дает другая группа 
        public static string OrderID
        {
            get { return string.IsNullOrEmpty(orderid) ? string.Empty : orderid; }
            set { orderid = value; }
        }
    }
}