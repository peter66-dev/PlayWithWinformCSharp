using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberDAO
    {
        // Nơi thêm xóa sửa member

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
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

        public MemberObject GetMemberByID(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select Email, Companyname, City, Country, Password from tblMember where MemberID = @memberid", connection);
            command.Parameters.AddWithValue("@memberid", id);
            MemberObject mem = new MemberObject();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    mem.MemberID = id;
                    mem.Email = reader.GetString("Email").Trim();
                    mem.CompanyName = reader.GetString("CompanyName").Trim();
                    mem.City = reader.GetString("City").Trim();
                    mem.Country = reader.GetString("Country").Trim();
                    mem.Password = reader.GetString("Password").Trim();
                    mem.Role = reader.GetString("Role").Trim();
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
            return mem;
        }

        public MemberObject GetMemberByEmail(string email)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select Email, MemberID, Companyname, City, Country, Password from tblMember where Email LIKE @email", connection);
            command.Parameters.AddWithValue("@email", '%' + email + '%');
            MemberObject mem = new MemberObject();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    mem.MemberID = reader.GetInt32("MemberID");
                    mem.Email = reader.GetString("Email").Trim();
                    mem.CompanyName = reader.GetString("CompanyName").Trim();
                    mem.City = reader.GetString("City").Trim();
                    mem.Country = reader.GetString("Country").Trim();
                    mem.Password = reader.GetString("Password").Trim();
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
            return mem;
        }

        public List<MemberObject> GetMemberList()
        {
            List<MemberObject> list = new List<MemberObject>();
            connection = new SqlConnection(GetConnectionString());
            string SQL = "Select MemberID, Email, CompanyName, City, Country, Password, Role from tblMember";
            command = new SqlCommand(SQL, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new MemberObject
                        {
                            MemberID = reader.GetInt32("MemberID"),
                            CompanyName = reader.GetString("CompanyName").Trim(),
                            Email = reader.GetString("Email").Trim(),
                            Password = reader.GetString("Password").Trim(),
                            Role = reader.GetString("Role").Trim(),
                            City = reader.GetString("City").Trim(),
                            Country = reader.GetString("Country")
                        });
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

        public MemberObject GetMemberByEmailPassword(string emailLogin, string pswLogin)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select MemberID, Email, Companyname, City, Country, Password, Role from tblMember where Email = @Email and Password = @Password", connection);
            command.Parameters.AddWithValue("@Email", emailLogin);
            command.Parameters.AddWithValue("@Password", pswLogin);
            MemberObject mem = new MemberObject();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    mem.MemberID = reader.GetInt32("MemberID");
                    mem.Email = reader.GetString("Email").Trim();
                    mem.CompanyName = reader.GetString("CompanyName").Trim();
                    mem.City = reader.GetString("City").Trim();
                    mem.Country = reader.GetString("Country").Trim();
                    mem.Password = reader.GetString("Password").Trim();
                    mem.Role = reader.GetString("Role").Trim();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error at GetMemberByEmailPassword: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return mem;
        }

        public List<MemberObject> GetMemberByIDAndEmail(int id, string email)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select Companyname, City, Country, Password, Role from tblMember where Email = @Email and MemberID = @MemberID", connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@MemberID", id);
            List<MemberObject> list = new List<MemberObject>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MemberObject mem = new MemberObject();
                    mem.MemberID = id;
                    mem.Email = email;
                    mem.CompanyName = reader.GetString("CompanyName").Trim();
                    mem.City = reader.GetString("City").Trim();
                    mem.Country = reader.GetString("Country").Trim();
                    mem.Password = reader.GetString("Password").Trim();
                    mem.Role = reader.GetString("Role").Trim();
                    list.Add(mem);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error at GetMemberByEmailPassword: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public void InsertMember(MemberObject mem)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Insert INTO tblMember(Email, CompanyName, City, Country, Password, Role) " +
                "values(@Email, @CompanyName, @City, @Country, @Password, @Role)", connection);
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = mem.Email;
            command.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = mem.CompanyName;
            command.Parameters.Add("@City", SqlDbType.VarChar).Value = mem.City;
            command.Parameters.Add("@Country", SqlDbType.VarChar).Value = mem.Country;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = mem.Password;
            command.Parameters.Add("@Role", SqlDbType.VarChar).Value = mem.Role;
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

        public void UpdateMember(MemberObject mem)//Không update role
        {
            connection = new SqlConnection(GetConnectionString());
            string SQL = "Update tblMember set Email = @Email, City = @City, CompanyName = @CompanyName, Country = @Country, Password = @Password Where MemberID = @MemberID";
            command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@Email", mem.Email);
            command.Parameters.AddWithValue("@City", mem.City);
            command.Parameters.AddWithValue("@CompanyName", mem.CompanyName);
            command.Parameters.AddWithValue("@Country", mem.Country);
            command.Parameters.AddWithValue("@Password", mem.Password);
            command.Parameters.AddWithValue("@MemberID", mem.MemberID);
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

        public void DeleteMember(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Delete tblMember Where MemberID = @MemberID", connection);
            command.Parameters.AddWithValue("@MemberID", id);
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
