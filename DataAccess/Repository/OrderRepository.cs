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

        public OrderObject GetOrderByID(int id) => OrderDAO.Instance.GetOrderByID(id);

        public IEnumerable<OrderObject> GetOrders() => OrderDAO.Instance.GetOrderList();

        public void InsertOrder(OrderObject order) => OrderDAO.Instance.InsertOrder(order);

        public void UpdateOrder(OrderObject order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
