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

        public List<OrderHistoryObject> GetOrderByMemberID(int memberID) => OrderDAO.Instance.GetOrderByMemberID(memberID);

        public List<OrderHistoryObject> GetOrderHistoryList() => OrderDAO.Instance.GetOrderHistoryList();

        public List<OrderHistoryObject> GetOrderHistoryList(int start, int end) => OrderDAO.Instance.GetOrderHistoryList(start, end);

        public IEnumerable<OrderObject> GetOrders() => OrderDAO.Instance.GetOrderList();

        public void InsertOrder(int orderid, int memberid, decimal freight) => OrderDAO.Instance.InsertOrder(orderid, memberid, freight);

        public List<OrderHistoryObject> SortByTotalAscending() => OrderDAO.Instance.SortByTotalAscending();

        public List<OrderHistoryObject> SortByTotalDescending() => OrderDAO.Instance.SortByTotalDescending();

        public double StatisticMoney(int startDate, int endDate) => OrderDAO.Instance.StatisticMoney(startDate, endDate);

        public void UpdateFreightByOrderID(int orderID, decimal freight) => OrderDAO.Instance.UpdateFreightByOrderID(orderID, freight);

        public void UpdateOrder(OrderObject order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
