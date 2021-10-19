using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderHistoryRepository : IOrderHistoryRepository
    {
        public void DeleteOrderHistory(int orderid, int productID) => OrderHistoryDAO.Instance.DeleteOrderHistory(orderid, productID);

        public List<OrderHistoryObject> GetOrdersHistory(int memberID) => OrderHistoryDAO.Instance.GetOrdersHistory(memberID);

        public List<OrderHistoryObject> GetOrdersHistory() => OrderHistoryDAO.Instance.GetOrdersHistory();

        public List<OrderHistoryObject> SortOrdersHistoryAscending() => OrderHistoryDAO.Instance.SortOrdersHistoryAscending();

        public List<OrderHistoryObject> SortOrdersHistoryDescending() => OrderHistoryDAO.Instance.SortOrdersHistoryDescending();
    }
}
