using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Bill.Models
{
    public class TaxLine : BaseOrderLine
    {
        public static double Tax { get; set; }
        public static double TaxResult { get; set; }

        public  double TaxCalculate()
        {
            Tax = 0.2;
            return TaxResult = ChargeLine.orderSumma * Tax;
        }
    }
}