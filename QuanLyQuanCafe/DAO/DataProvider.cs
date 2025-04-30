using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider? instance;
        private readonly string connectionString = "Server=DESKTOP-E6M7R93\\SQLEXPRESS;Database=QuanLyQuanCafe1;Trusted_Connection=True;Encrypt=False;";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }

        private DataProvider() { }

        // Thêm tham số vào SqlCommand đúng thứ tự
        private void AddParameters(SqlCommand command, object[] parameters)
        {
            // Duyệt qua từng tham số trong command.CommandText
            int index = 0;
            foreach (var token in command.CommandText.Split(new[] { ' ', '\n', '\r', '\t', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (token.StartsWith("@") && index < parameters.Length && !command.Parameters.Contains(token))
                {
                    command.Parameters.AddWithValue(token, parameters[index]);
                    index++;
                }
            }
        }


        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    // Tự động gán giá trị cho các tham số trong query
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains("@"))
                        {
                            string paramName = item.Replace(",", "").Replace(")", "").Replace("(", "").Trim();
                            if (!command.Parameters.Contains(paramName))
                            {
                                command.Parameters.AddWithValue(paramName, parameters[i]);
                                i++;
                            }
                        }
                    }
                }

                int result = command.ExecuteNonQuery();
                return result;
            }
        }




        public object ExecuteScalar(string query, object[]? parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        AddParameters(command, parameters);

                    return command.ExecuteScalar();
                }
            }
        }

        public DataTable ExecuteQuery(string query, object[]? parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        AddParameters(command, parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }
    }
}
