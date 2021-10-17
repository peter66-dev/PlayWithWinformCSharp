using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int id) => OrderDAO.Instance.DeleteOrder(id);

        public int GetCountingOrders() => OrderDAO.Instance.GetCountingOrders();

        public OrderObject GetOrderByID(int id) => OrderDAO.Instance.GetOrderByID(id);

        public IEnumerable<OrderObject> GetOrders() => OrderDAO.Instance.GetOrderList();

        public void InsertOrder(int orderid, int memberid, decimal freight) => OrderDAO.Instance.InsertOrder(orderid, memberid, freight);

        public void UpdateOrder(OrderObject order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
