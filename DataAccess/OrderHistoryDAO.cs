using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderHistoryDAO
    {
        private static OrderHistoryDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderHistoryDAO() { }
        public static OrderHistoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderHistoryDAO();
                    }
                    return instance;
                }
            }
        }

        SqlConnection connection;
        SqlCommand command;
        static string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("connectionSettings.json", true, true)
                                        .Build();
            connectionString = config["ConnectionString:FStoreDB"];
            return connectionString;
        }
        public List<OrderHistoryObject> GetOrdersHistory(int memberID)
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select o.OrderDate, o.ShippedDate, o.RequiredDate, d.ProductId, d.UnitPrice, d.Quantity, d.Discount " +
                "from tblOrder o left join tblOrderDetail d on d.OrderID = o.OrderID where o.OrderID in " +
                "(select OrderID from tblOrder where MemberID = @MemberID)", connection);
            command.Parameters.AddWithValue("@MemberID", memberID);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (rs.Read())
                {
                    OrderHistoryObject o = new OrderHistoryObject()
                    {
                        OrderDate = rs.GetDateTime("OrderDate"),
                        RequiredDate = rs.GetDateTime("RequiredDate"),
                        ShippedDate = rs.GetDateTime("ShippedDate"),
                        ProductID = rs.GetInt32("ProductID"),
                        UnitPrice = rs.GetDecimal("UnitPrice"),
                        QuantityBuy = rs.GetInt32("Quantity"),
                        Discount = rs.GetDouble("Discount")
                    };
                    list.Add(o);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return list;
        }
    }
}
