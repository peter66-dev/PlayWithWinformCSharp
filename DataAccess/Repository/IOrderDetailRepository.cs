using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public void InsertOrderDetail(OrderDetailObject order);
        public IEnumerable<OrderDetailObject> GetOrderDetailList();
    }
}
