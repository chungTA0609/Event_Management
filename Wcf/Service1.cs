using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDb();
        }

        SqlConnection conn;
        SqlCommand comm;

        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = @"DESKTOP-PD5JGU6\SQLEXPRESS";//Database Account
            connStringBuilder.InitialCatalog = "EVENT_MANAGEMENT";//Database Name
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int InsertAccount(Account account)
        {
            try
            {
                comm.CommandText = "INSERT INTO Account VALUES(@id, @userName, @password, @type, @email, @phoneNumber, @createTime);";
                comm.Parameters.AddWithValue("id", account.Id);
                comm.Parameters.AddWithValue("userName", account.UserName);
                comm.Parameters.AddWithValue("password", account.Password);
                comm.Parameters.AddWithValue("type", account.Type);
                comm.Parameters.AddWithValue("email", account.Email);
                comm.Parameters.AddWithValue("phoneNumber", account.PhoneNumber);
                comm.Parameters.AddWithValue("createTime", account.CreatedTime);

                comm.CommandType = CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
