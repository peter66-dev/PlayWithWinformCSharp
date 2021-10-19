using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderHistoryObject
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int QuantityBuy { get; set; }
        public double Discount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }

        public OrderHistoryObject()
        {

        }

        public OrderHistoryObject(DateTime order, DateTime required, DateTime shipped, int orderid, int proID, decimal price, int quantity, float discount)
        {
            OrderDate = order;
            RequiredDate = required;
            ShippedDate = shipped;
            ProductID = proID;
            OrderID = orderid;
            UnitPrice = price;
            QuantityBuy = quantity;
            Discount = discount;
        }
    }
}
