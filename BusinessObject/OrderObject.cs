using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderObject
    {
        public int OrderID { get; set; }
        public int MemberID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public decimal Freight { get; set; }
        public OrderObject()
        {

        }

        public OrderObject(int oId, int mID, DateTime oDate, DateTime rDate, DateTime sDate, decimal freight)
        {
            OrderID = oId;
            MemberID = mID;
            OrderDate = oDate;
            RequiredDate = rDate;
            ShippedDate = sDate;
            Freight = freight;
        }
    }
}
