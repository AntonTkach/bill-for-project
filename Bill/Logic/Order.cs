using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bill.Models
{
    public class Order
    {
        
       
        public double getTaxLines()
        {
            return TaxLine.TaxResult;
        }
        
        public double getChargeLine()
        {
            return ChargeLine.orderSumma;
        }
        public string getOrderLine()
        {
            return OrderLine.BillID;
        }
        
    }
}