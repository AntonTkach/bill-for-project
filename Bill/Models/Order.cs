using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bill.Models
{
    public class Order
    {
        private string id;
        public string ID
        {
            get { return string.IsNullOrEmpty(id) ? string.Empty : id; }
            set { id = value; }
        }

        
    }
}