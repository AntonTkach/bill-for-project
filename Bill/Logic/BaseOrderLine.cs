using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bill.Models
{
    public class BaseOrderLine 
    {
        public ArrayList createBaseOrderLineList()
            {
               ArrayList BaseLineArrayList = new ArrayList();
               BaseLineArrayList.Add(ChargeLine.orderSumma);
               BaseLineArrayList.Add(TaxLine.TaxResult);
               BaseLineArrayList.Add(OrderLine.BillID);

               return BaseLineArrayList;
            }
       
        
        

       
    }
}