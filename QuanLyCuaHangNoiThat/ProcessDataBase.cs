using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangNoiThat
{
    internal class ProcessDataBase
    {
        public string string_connect = @"Data Source=DESKTOP-J7RQ5CS\MAICONG;Initial Catalog=QLCUAHANGNOITHAT;Integrated Security=True";
        public SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public void Open()
        {
            sqlConnection = new SqlConnection(string_connect);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        public void Close()
        {
            if (sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
        public DataTable table(string query)//lay bang du lieu
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(string_connect))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public void Excute(string query)//thuc thi cac cau lenh truy van
        {

            using (SqlConnection sqlConnection = new SqlConnection(string_connect))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thuc thi cau lenh
                sqlConnection.Close();
            }
        }
        public string GetValue(string strQuery)
        {
            string value;
            using (SqlConnection sqlConnection = new SqlConnection(string_connect))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(strQuery, sqlConnection);
                value = sqlCommand.ExecuteScalar().ToString();//thuc thi cau lenh
                sqlConnection.Close();
            }
            return value;
        }

    }
}
