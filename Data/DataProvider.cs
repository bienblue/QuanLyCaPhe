using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataProvider
    {

        private string connectionSTR = @"Data Source=DESKTOP-LJQK89A\SQLEXPRESS;Initial Catalog=quan_ly_cafe;Integrated Security=True";
        public SqlConnection connection;
        public SqlCommand cmd;
        public DataProvider()
        {
            try
            {
                connection = new SqlConnection(connectionSTR);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
                cmd = connection.CreateCommand();
            }
            catch (SqlException)
            {

            }
        }

        public DataTable GetDataToDataTable(string sqlExpess, CommandType type, params SqlParameter[] pm)
        {
            DataTable table = new DataTable();
            cmd = connection.CreateCommand();
            cmd.CommandType = type;
            cmd.CommandText = sqlExpess;
            cmd.Parameters.Clear();
            foreach (SqlParameter a in pm)
            {
                cmd.Parameters.Add(a);
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(table);
            return table;
        }
        public void ExcuteNonQuery(string sqlExpess, CommandType type, params SqlParameter[] pm)
        {
            cmd = connection.CreateCommand();
            cmd.CommandType = type;
            cmd.CommandText = sqlExpess;
            cmd.Parameters.Clear();
            foreach (SqlParameter a in pm)
            {
                cmd.Parameters.Add(a);
            }
            cmd.ExecuteNonQuery();
        }
        public object ExecuteScalar(string sqlExpess, CommandType type, params SqlParameter[] pm)
        {
            cmd = connection.CreateCommand();
            cmd.CommandType = type;
            cmd.CommandText = sqlExpess;
            cmd.Parameters.Clear();
            foreach (SqlParameter a in pm)
            {
                cmd.Parameters.Add(a);
            }
            return cmd.ExecuteScalar();
        }
    }
}
