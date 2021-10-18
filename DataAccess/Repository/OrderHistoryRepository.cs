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
        public List<OrderHistoryObject> GetOrdersHistory(int memberID) => OrderHistoryDAO.Instance.GetOrdersHistory(memberID);
    }
}
