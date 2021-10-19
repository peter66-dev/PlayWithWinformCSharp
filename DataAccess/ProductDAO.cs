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
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        SqlConnection connection;
        SqlCommand command;
        //string ConnectionString = "Server=(local);uid=sa;pwd=sa;database=FStore";
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
        public List<ProductObject> GetProductList()
        {
            List<ProductObject> list = new List<ProductObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select ProductID, CategoryID, ProductName, Weight , UnitPrice, UnitsInStock From [Product]", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductObject pro = new ProductObject()
                        {
                            ProductID = reader.GetInt32("ProductID"),
                            CategoryID = reader.GetInt32("CategoryID"),
                            ProductName = reader.GetString("ProductName"),
                            Weight = reader.GetString("Weight"),
                            UnitPrice = Math.Round(reader.GetDecimal("UnitPrice"), 2),
                            UnitsInStock = reader.GetInt32("UnitsInStock"),
                        };
                        list.Add(pro);
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

        public void InsertProduct(int cateID, string proName, string weight, decimal unitPrice, int stocks)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("INSERT INTO [Product](CategoryID, ProductName, Weight, UnitPrice, UnitsInStock) " +
                "values(@CategoryID, @ProductName, @Weight, @UnitPrice, @UnitsInStock)", connection);
            command.Parameters.AddWithValue("@CategoryID", cateID);
            command.Parameters.AddWithValue("@ProductName", proName);
            command.Parameters.AddWithValue("@Weight", weight);
            command.Parameters.AddWithValue("@UnitPrice", Math.Round(unitPrice, 2));
            command.Parameters.AddWithValue("@UnitsInStock", stocks);
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

        public void DeleteProduct(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Delete [Product] Where ProductID = @ProductID", connection);
            command.Parameters.AddWithValue("@ProductID", id);

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

        public void UpdateProduct(ProductObject pro)//KHÔNG UPDATE PRODUCTID
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Update [Product] set CategoryID = @CategoryID, ProductName = @ProductName, " +
                "Weight = @Weight, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock where ProductID = @ProductID", connection);
            command.Parameters.AddWithValue("@ProductID", pro.ProductID);
            command.Parameters.AddWithValue("@CategoryID", pro.CategoryID);
            command.Parameters.AddWithValue("@ProductName", pro.ProductName);
            command.Parameters.AddWithValue("@Weight", pro.Weight);
            command.Parameters.AddWithValue("@UnitPrice", Math.Round(pro.UnitPrice, 2));
            command.Parameters.AddWithValue("@UnitsInStock", pro.UnitsInStock);

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

        public ProductObject GetProductByID(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select CategoryID, ProductName, Weight, UnitPrice, UnitsInStock from [Product] " +
                "where ProductID = @ProductID", connection);
            command.Parameters.AddWithValue("@ProductID", id);
            ProductObject pro = new ProductObject();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        pro.ProductID = id;
                        pro.CategoryID = reader.GetInt32("CategoryID");
                        pro.ProductName = reader.GetString("ProductName");
                        pro.Weight = reader.GetString("Weight");
                        pro.UnitPrice = Math.Round(reader.GetDecimal("UnitPrice"), 2);
                        pro.UnitsInStock = reader.GetInt32("UnitsInStock");
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
            return pro;
        }

        public List<ProductObject> GetProductByName(string name)
        {
            List<ProductObject> list = new List<ProductObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitsInStock from [Product] " +
                "where ProductName LIKE @Search ", connection);
            command.Parameters.AddWithValue("@Search", '%' + name + '%');
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductObject pro = new ProductObject()
                        {
                            ProductID = reader.GetInt32("ProductID"),
                            CategoryID = reader.GetInt32("CategoryID"),
                            ProductName = reader.GetString("ProductName"),
                            Weight = reader.GetString("Weight"),
                            UnitPrice = Math.Round(reader.GetDecimal("UnitPrice"), 2),
                            UnitsInStock = reader.GetInt32("UnitsInStock"),
                        };
                        list.Add(pro);
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
        public ProductObject GetProductByIDAndName(int id, string name)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select CategoryID, ProductName, Weight, UnitPrice, UnitsInStock from [Product] " +
                "where ProductID = @ProductID and ProductName LIKE @ProductName", connection);
            command.Parameters.AddWithValue("@ProductID", id);
            command.Parameters.AddWithValue("@ProductName", '%' + name + '%');
            ProductObject pro = new ProductObject();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        pro.ProductID = id;
                        pro.CategoryID = reader.GetInt32("CategoryID");
                        pro.ProductName = reader.GetString("ProductName");
                        pro.Weight = reader.GetString("Weight");
                        pro.UnitPrice = Math.Round(reader.GetDecimal("UnitPrice"), 2);
                        pro.UnitsInStock = reader.GetInt32("UnitsInStock");
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
            return pro;
        }

        public List<string> CheckQuantity(List<ProductObject> cart)//Hàm trả về tên các sản phẩm ko đủ số lượng để cung cấp
        {
            List<string> result = new List<string>();
            foreach (var pro in cart)
            {
                int quantity = GetQuantityByProID(pro.ProductID);// Số lượng trong kho
                if (quantity < pro.UnitsInStock)
                {
                    result.Add(pro.ProductName);
                }
            }
            return result;
        }

        int GetQuantityByProID(int proID)
        {
            int quantity = 0;
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select UnitsInStock from [Product] where ProductID = @ProductID", connection);
            command.Parameters.AddWithValue("@ProductID", proID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        quantity = reader.GetInt32("UnitsInStock");
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
            return quantity;
        }

        public void SubQuantityProduct(List<ProductObject> cart)
        {
            foreach (var p in cart)
            {
                int id = p.ProductID;
                int quantityBuy = p.UnitsInStock;
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand("update [Product] set UnitsInStock = UnitsInStock - @QuantityBuy where ProductID = @ProductID", connection);
                command.Parameters.AddWithValue("@QuantityBuy", quantityBuy);
                command.Parameters.AddWithValue("@ProductID", id);
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

        void SetNewQuantityProduct(int id, int quantityBuy)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update tblProduct set UnitsInStock = UnitsInStock - @QuantityBuy where ProductID = @ProductID", connection);
            command.Parameters.AddWithValue("@QuantityBuy", quantityBuy);
            command.Parameters.AddWithValue("@ProductID", id);
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
