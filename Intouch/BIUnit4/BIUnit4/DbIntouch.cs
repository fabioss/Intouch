namespace BIUnit4
{
    using Microsoft.ApplicationBlocks.Data;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class DbIntouch
    {
        private static string conn = Cript_Decript.DeCifra(ConfigurationManager.ConnectionStrings["CONEXAO.INTOUCH"].ConnectionString);

        public static DataSet ExecuteDataset(string cmd)
        {
            SqlConnection connection = new SqlConnection(conn);
            DataSet set = new DataSet();
            set = SqlHelper.ExecuteDataset(connection, CommandType.Text, cmd);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return set;
        }

        public static DataTable ExecuteDataTable(string cmd)
        {
            SqlConnection connection = new SqlConnection(conn);
            DataTable table = new DataTable();
            table = SqlHelper.ExecuteDataset(connection, 1, cmd).Tables[0];
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return ((table.Rows.Count == 0) ? null : table);
        }

        public static void ExecuteNonQuery(string cmd)
        {
            SqlConnection connection = new SqlConnection(conn);
            DataTable table = new DataTable();
            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, cmd);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static int ExecuteNonQuery_Retorno(string cmd)
        {
            SqlConnection connection = new SqlConnection(conn);
            return SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, cmd);
        }

        public static string ExecuteScalar(string cmd)
        {
            SqlConnection connection = new SqlConnection(conn);
            DataTable table = new DataTable();
            string str = SqlHelper.ExecuteScalar(connection, CommandType.Text, cmd).ToString();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return str;
        }
    }
}

