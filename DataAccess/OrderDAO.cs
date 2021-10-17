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
            command = new SqlCommand("select OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight from tblOrder", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
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

        public void InsertOrder(OrderObject order)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("INSERT INTO tblOrder(MemberID, OrderDate, RequiredDate, ShippedDate, Freight) " +
                "values(@MemberID, @OrderDate, @RequiredDate, @ShippedDate, @Freight)", connection);
            command.Parameters.AddWithValue("@MemberID", order.MemberID);
            command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            command.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
            command.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
            command.Parameters.AddWithValue("@Freight", order.Freight);
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

        public void DeleteOrder(int orderID)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Delete tblOrder where OrderID = @OrderID", connection);
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
            command = new SqlCommand("update tblOrder set MemberID = @MemberID, OrderDate = @OrderDate, " +
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
            command = new SqlCommand("Select MemberID, OrderDate, RequiredDate, ShippedDate, Freight from tblOrder where OrderID = @OrderID", connection);
            command.Parameters.AddWithValue("@OrderID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    order.OrderID = id;
                    order.MemberID = reader.GetInt32("MemberID");
                    order.OrderDate = reader.GetDateTime("OrderDate");
                    order.RequiredDate = reader.GetDateTime("RequiredDate");
                    order.ShippedDate = reader.GetDateTime("ShippedDate");
                    order.Freight = reader.GetDecimal("Freight");
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


    }
}
