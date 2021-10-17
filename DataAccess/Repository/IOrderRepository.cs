using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public IEnumerable<OrderObject> GetOrders();
        public OrderObject GetOrderByID(int id);
        public void InsertOrder(OrderObject order);
        public void DeleteOrder(int id);
        public void UpdateOrder(OrderObject order);
            
    }
}
