using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderHistoryRepository
    {
        public List<OrderHistoryObject> GetOrdersHistory(int memberID);
        public List<OrderHistoryObject> GetOrdersHistory();
        public List<OrderHistoryObject> SortOrdersHistoryDescending();
        public List<OrderHistoryObject> SortOrdersHistoryAscending();
        public void DeleteOrderHistory(int orderid, int productID);
    }
}
