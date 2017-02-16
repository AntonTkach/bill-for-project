using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bill.Models
{
    public class OrderLine : BaseOrderLine
    {
        private string orderId;
        public string OrderID
        {
            get { return string.IsNullOrEmpty(orderId) ? string.Empty : orderId; }
            set { orderId = value; }
        }

    }
}