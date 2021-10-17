using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetailObject> GetOrderDetailList() => OrderDetailDAO.Instance.GetOrderDetailList();
        public void InsertOrderDetail(OrderDetailObject order) => OrderDetailDAO.Instance.InsertOrderDetail(order);
    }
}
