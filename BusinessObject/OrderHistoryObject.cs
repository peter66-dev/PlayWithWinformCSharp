using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderHistoryObject : OrderObject
    {
        public double Total { get; set; }

        public OrderHistoryObject() : base()
        {
            Total = 0;
        }

        public OrderHistoryObject(double total, int oId, int mID, DateTime oDate, DateTime rDate, DateTime sDate, decimal freight) : base(oId, mID, oDate, rDate, sDate, freight)
        {
            Total = total;
        }
    }
}
