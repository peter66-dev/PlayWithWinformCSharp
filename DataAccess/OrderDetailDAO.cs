using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        static string GetConnectionString()
        {
            string connectionString = "";
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("connectionSettings.json", true, true)
                                        .Build();
            connectionString = config["ConnectionString:FStoreDB"];
            return connectionString;
        }
        SqlConnection connection;
        SqlCommand command;
        public List<OrderDetailObject> GetOrderDetailList()
        {
            List<OrderDetailObject> list = new List<OrderDetailObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select OrderID, ProductID, UnitPrice, Quantity, Discount from [OrderDetail]", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (rs.Read()) {
                    OrderDetailObject o = new OrderDetailObject()
                    {
                        OrderID = rs.GetInt32("OrderID"),
                        ProductID = rs.GetInt32("ProductID"),
                        UnitPrice = rs.GetDecimal("UnitPrice"),
                        Quantity = rs.GetInt32("Quantity"),
                        Discount = rs.GetDouble("Discount"),
                    };
                    list.Add(o);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public void InsertOrderDetail(OrderDetailObject order)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("insert into [OrderDetail](OrderID, ProductID, UnitPrice, Quantity, Discount) " +
                "values(@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)", connection);
            command.Parameters.AddWithValue("@OrderID", order.OrderID);
            command.Parameters.AddWithValue("@ProductID", order.ProductID);
            command.Parameters.AddWithValue("@UnitPrice", order.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", order.Quantity);
            command.Parameters.AddWithValue("@Discount", order.Discount);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
