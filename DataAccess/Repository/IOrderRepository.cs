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
        public void InsertOrder(int orderid, int memberid, decimal freight);
        public void DeleteOrder(int id);
        public void UpdateOrder(OrderObject order);
        public int GetCountingOrders();
        public List<OrderHistoryObject> GetOrderHistoryList();
        public List<OrderHistoryObject> GetOrderByMemberID(int memberID);
        public List<OrderHistoryObject> SortByTotalAscending();
        public List<OrderHistoryObject> SortByTotalDescending();
        public double StatisticMoney(int startDate, int endDate);
        public void UpdateFreightByOrderID(int orderID, decimal freight);
        public List<OrderHistoryObject> GetOrderHistoryList(int start, int end);

    }
}
