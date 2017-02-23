using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bill.Models
{
    public class ChargeLine : BaseOrderLine
    {
        public static  double orderSumma { get; set; }
    }
}