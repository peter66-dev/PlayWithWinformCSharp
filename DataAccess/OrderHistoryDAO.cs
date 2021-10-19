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
            command = new SqlCommand("select o.OrderDate, o.ShippedDate, o.RequiredDate, d.OrderID, d.ProductId, d.UnitPrice, d.Quantity, d.Discount " +
                "from [Order] o left join [OrderDetail] d on d.OrderID = o.OrderID where o.OrderID in " +
                "(select OrderID from tblOrder where MemberID = @MemberID)", connection);
            command.Parameters.AddWithValue("@MemberID", memberID);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        OrderHistoryObject o = new OrderHistoryObject()
                        {
                            OrderDate = rs.GetDateTime("OrderDate"),
                            RequiredDate = rs.GetDateTime("RequiredDate"),
                            ShippedDate = rs.GetDateTime("ShippedDate"),
                            ProductID = rs.GetInt32("ProductID"),
                            OrderID = rs.GetInt32("OrderID"),
                            UnitPrice = rs.GetDecimal("UnitPrice"),
                            QuantityBuy = rs.GetInt32("Quantity"),
                            Discount = rs.GetDouble("Discount")
                        };
                        list.Add(o);
                    }
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

        public List<OrderHistoryObject> GetOrdersHistory()
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select o.OrderDate, o.ShippedDate, o.RequiredDate, d.ProductID, d.OrderID, d.UnitPrice, d.Quantity, d.Discount " +
                "from [Order] o left join [OrderDetail] d on d.OrderID = o.OrderID", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        OrderHistoryObject o = new OrderHistoryObject();
                        o.OrderDate = rs.GetDateTime(0);
                        o.ShippedDate = rs.GetDateTime(1);
                        o.RequiredDate = rs.GetDateTime(2);
                        o.ProductID = rs.GetInt32(3);
                        o.OrderID = rs.GetInt32(4);
                        o.UnitPrice = rs.GetDecimal(5);
                        o.QuantityBuy = rs.GetInt32(6);
                        o.Discount = rs.GetDouble(7); 
                        list.Add(o);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }
        public List<OrderHistoryObject> SortOrdersHistoryAscending()
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select o.OrderDate, o.ShippedDate, o.RequiredDate, d.ProductId, d.OrderID, d.UnitPrice, d.Quantity, d.Discount " +
                "from [Order] o left join [OrderDetail] d on d.OrderID = o.OrderID order by OrderDate asc", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        OrderHistoryObject o = new OrderHistoryObject()
                        {
                            OrderDate = rs.GetDateTime("OrderDate"),
                            RequiredDate = rs.GetDateTime("RequiredDate"),
                            ShippedDate = rs.GetDateTime("ShippedDate"),
                            ProductID = rs.GetInt32("ProductID"),
                            OrderID = rs.GetInt32("OrderID"),
                            UnitPrice = rs.GetDecimal("UnitPrice"),
                            QuantityBuy = rs.GetInt32("Quantity"),
                            Discount = rs.GetDouble("Discount")
                        };
                        list.Add(o);
                    }
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
        public List<OrderHistoryObject> SortOrdersHistoryDescending()
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select o.OrderDate, o.ShippedDate, o.RequiredDate, d.ProductId, d.OrderID, d.UnitPrice, d.Quantity, d.Discount " +
                "from [Order] o left join [OrderDetail] d on d.OrderID = o.OrderID order by OrderDate desc", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        OrderHistoryObject o = new OrderHistoryObject()
                        {
                            OrderDate = rs.GetDateTime("OrderDate"),
                            RequiredDate = rs.GetDateTime("RequiredDate"),
                            ShippedDate = rs.GetDateTime("ShippedDate"),
                            ProductID = rs.GetInt32("ProductID"),
                            OrderID = rs.GetInt32("OrderID"),
                            UnitPrice = rs.GetDecimal("UnitPrice"),
                            QuantityBuy = rs.GetInt32("Quantity"),
                            Discount = rs.GetDouble("Discount")
                        };
                        list.Add(o);
                    }
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

        public void DeleteOrderHistory(int orderid, int productID)
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("delete [OrderDetail] where OrderId = @OrderId and ProductId = @ProductId", connection);
            command.Parameters.AddWithValue("@OrderId", orderid);
            command.Parameters.AddWithValue("@ProductId", productID);
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
