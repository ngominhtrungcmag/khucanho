using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace KhuCanHo.Database
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        private string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=ApartmentManagement;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }



        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExcuteNonQuery(string query)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

     

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public int ExecuteScalar(string query)
        {
            int data = -1;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = (Int32)command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
    //
}
