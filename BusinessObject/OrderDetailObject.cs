using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetailObject
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }//nó ko cho lấy float sang float nên để double 
        public double Total { get; set; }

        public OrderDetailObject()
        {

        }
        public OrderDetailObject(int oID, int pID, decimal unitPrice, int quantity, double disc, double total)
        {
            OrderID = oID;
            ProductID = pID;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = disc;
            Total = total;
        }
    }
}
