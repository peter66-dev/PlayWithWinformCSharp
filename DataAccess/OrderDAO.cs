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
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        SqlConnection connection;
        SqlCommand command;
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

        public List<OrderObject> GetOrderList()
        {
            List<OrderObject> list = new List<OrderObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight from [Order]", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderObject ord = new OrderObject()
                        {
                            OrderID = reader.GetInt32("OrderID"),
                            MemberID = reader.GetInt32("MemberID"),
                            OrderDate = reader.GetDateTime("OrderDate"),
                            RequiredDate = reader.GetDateTime("RequiredDate"),
                            ShippedDate = reader.GetDateTime("ShippedDate"),
                            Freight = reader.GetDecimal("Freight")
                        };
                        list.Add(ord);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        void SetRequiredDate(int orderid)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update [Order] set RequiredDate = dateadd(day, 2, OrderDate) where OrderID = @OrderID", connection);
            command.Parameters.AddWithValue("@OrderID", orderid);
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
        void SetShippedDate(int orderid)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update [Order] set ShippedDate = dateadd(day, 4, OrderDate) where OrderID = @OrderID", connection);
            command.Parameters.AddWithValue("@OrderID", orderid);
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
        public void InsertOrder(int orderid, int memberid, decimal freight)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("INSERT INTO [Order](OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight) " +
                "values(@OrderID, @MemberID, getdate(), getdate(), getdate(), @Freight)", connection);
            command.Parameters.AddWithValue("@MemberID", memberid);
            command.Parameters.AddWithValue("@OrderID", orderid);
            command.Parameters.AddWithValue("@Freight", freight);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SetRequiredDate(orderid);// RequiredDate sẽ mặc định orderdate+2
                SetShippedDate(orderid);// ShippedDate sẽ mặc định orderdate+4
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

        public void DeleteOrder(int orderID)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Delete [Order] where OrderID = @OrderID", connection);
            command.Parameters.AddWithValue("@OrderID", orderID);
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

        public void UpdateOrder(OrderObject order)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update [Order] set MemberID = @MemberID, OrderDate = @OrderDate, " +
                "RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, Freight = @Freight where OrderID = @OrderID", connection);
            command.Parameters.AddWithValue("@MemberID", order.MemberID);
            command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            command.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
            command.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
            command.Parameters.AddWithValue("@Freight", order.Freight);
            command.Parameters.AddWithValue("@OrderID", order.OrderID);
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

        public OrderObject GetOrderByID(int id)
        {
            OrderObject order = new OrderObject();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select MemberID, OrderDate, RequiredDate, ShippedDate, Freight from [Order] where OrderID = @OrderID", connection);
            command.Parameters.AddWithValue("@OrderID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        order.OrderID = id;
                        order.MemberID = reader.GetInt32("MemberID");
                        order.OrderDate = reader.GetDateTime("OrderDate");
                        order.RequiredDate = reader.GetDateTime("RequiredDate");
                        order.ShippedDate = reader.GetDateTime("ShippedDate");
                        order.Freight = reader.GetDecimal("Freight");
                    }
                }
                else
                {
                    order = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return order;
        }

        public List<OrderHistoryObject> GetOrderByMemberID(int memberID)
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select OrderID, OrderDate, RequiredDate, ShippedDate, Freight from [Order] where MemberID = @MemberID", connection);
            command.Parameters.AddWithValue("@MemberID", memberID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderHistoryObject order = new OrderHistoryObject();
                        order.OrderID = reader.GetInt32("OrderID");
                        order.MemberID = memberID;
                        order.OrderDate = reader.GetDateTime("OrderDate");
                        order.RequiredDate = reader.GetDateTime("RequiredDate");
                        order.ShippedDate = reader.GetDateTime("ShippedDate");
                        order.Freight = Math.Round(reader.GetDecimal("Freight"), 2);
                        order.Total = GetTotalMoneyOrderByOrderID(reader.GetInt32("OrderID"));
                        list.Add(order);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public int GetCountingOrders()
        {
            int count = 0;
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select count(OrderID) as Total from [Order]", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32("Total");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return count;
        }

        // -----------------------------------------      Order Management  ----------------------------------------- 
        public double GetTotalMoneyOrderByOrderID(int orderID)
        {
            double total = 0;
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select UnitPrice, Quantity, Discount from [OrderDetail] where OrderId = @OrderId", connection);
            command.Parameters.AddWithValue("@OrderId", orderID);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        decimal unitPrice = rs.GetDecimal("UnitPrice");
                        int quantity = rs.GetInt32("Quantity");
                        double discount = rs.GetDouble("Discount");// bug here
                        total += ((double)unitPrice * quantity * (double)(1 - discount));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return total;
        }

        public List<OrderHistoryObject> GetOrderHistoryList()
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight from [Order]", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderHistoryObject ord = new OrderHistoryObject()
                        {
                            OrderID = reader.GetInt32("OrderID"),
                            MemberID = reader.GetInt32("MemberID"),
                            OrderDate = reader.GetDateTime("OrderDate"),
                            RequiredDate = reader.GetDateTime("RequiredDate"),
                            ShippedDate = reader.GetDateTime("ShippedDate"),
                            Freight = reader.GetDecimal("Freight"),
                            Total = Math.Round(GetTotalMoneyOrderByOrderID(reader.GetInt32("OrderID")), 2)
                        };
                        list.Add(ord);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public List<OrderHistoryObject> GetOrderHistoryList(int start, int end)
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight from [Order] " +
                "where DATEPART(day, OrderDate) between @start and @end order by OrderDate asc", connection);
            command.Parameters.AddWithValue("@start", start);
            command.Parameters.AddWithValue("@end", end);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderHistoryObject ord = new OrderHistoryObject();
                        ord.OrderID = reader.GetInt32("OrderID");
                        ord.MemberID = reader.GetInt32("MemberID");
                        ord.OrderDate = reader.GetDateTime("OrderDate");
                        ord.RequiredDate = reader.GetDateTime("RequiredDate");
                        ord.ShippedDate = reader.GetDateTime("ShippedDate");
                        ord.Freight = reader.GetDecimal("Freight");
                        ord.Total = ord.OrderID == null ? 0 : Math.Round(GetTotalMoneyOrderByOrderID(ord.OrderID), 2);
                        list.Add(ord);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public List<OrderHistoryObject> SortByTotalAscending()
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select o.OrderID, o.MemberID,  (1-Discount) * Quantity * UnitPrice as Total, " +
                "o.OrderDate, o.RequiredDate, o.ShippedDate, o.Freight " +
                "from[Order] o left join[OrderDetail] d on o.OrderID = d.OrderId order by Total asc", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        OrderHistoryObject ord = new OrderHistoryObject()
                        {
                            OrderID = rs.GetInt32("OrderID"),
                            MemberID = rs.GetInt32("MemberID"),
                            OrderDate = rs.GetDateTime("OrderDate"),
                            RequiredDate = rs.GetDateTime("RequiredDate"),
                            ShippedDate = rs.GetDateTime("ShippedDate"),
                            Freight = Math.Round(rs.GetDecimal("Freight"), 2),
                            //Total = Math.Round(GetTotalMoneyOrderByOrderID(reader.GetInt32("OrderID")), 2)
                            Total = Math.Round(rs.GetDouble("Total"), 2)
                        };
                        list.Add(ord);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public List<OrderHistoryObject> SortByTotalDescending()
        {
            List<OrderHistoryObject> list = new List<OrderHistoryObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select o.OrderID, o.MemberID,  (1-Discount) * Quantity * UnitPrice as Total, " +
                "o.OrderDate, o.RequiredDate, o.ShippedDate, o.Freight " +
                "from[Order] o left join[OrderDetail] d on o.OrderID = d.OrderId order by Total desc", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderHistoryObject ord = new OrderHistoryObject();

                        ord.OrderID = reader.GetInt32("OrderID");
                        ord.MemberID = reader.GetInt32("MemberID");
                        ord.OrderDate = reader.GetDateTime("OrderDate");
                        ord.RequiredDate = reader.GetDateTime("RequiredDate");
                        ord.ShippedDate = reader.GetDateTime("ShippedDate");
                        ord.Freight = Math.Round(reader.GetDecimal("Freight"), 2);
                        //Total = Math.Round(GetTotalMoneyOrderByOrderID(reader.GetInt32("OrderID")), 2)
                        ord.Total = Math.Round(reader.GetDouble("Total"), 2);
                        list.Add(ord);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public double StatisticMoney(int startDate, int endDate)
        {
            double total = 0;
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select SUM((1-discount) * quantity * unitprice) as TOTAL " +
                "from[OrderDetail] where OrderId in (select OrderId from[Order] where DATEPART(day, OrderDate) between @StartDate and @EndDate)", connection);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    if (rs.Read())
                    {
                        total = Math.Round(rs.GetDouble(0), 2);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return total;
        }

        public void UpdateFreightByOrderID(int orderID, decimal freight)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update [order] set Freight = @Freight where OrderID = @OrderID", connection);
            command.Parameters.AddWithValue("@Freight", freight);
            command.Parameters.AddWithValue("@OrderID", orderID);
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
