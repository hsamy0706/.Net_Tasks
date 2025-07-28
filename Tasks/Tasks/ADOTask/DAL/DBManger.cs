using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.ADOTask.DAL
{
   public static class DBManger
    {
        private static string connectionString = "Data Source=.\\SQLExpress;Initial Catalog=mydb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        
        static SqlCommand sqlCommand = new SqlCommand();

        static DBManger()
        {
            sqlCommand.Connection = sqlConnection;
            
        }

        public static void ExcuteQuery(string query, Action<SqlDataReader> readAction, SqlParameter[] parameters = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(query))
                {
                    sqlCommand.CommandText = query;

                    if (sqlConnection.State == System.Data.ConnectionState.Closed)
                        sqlConnection.Open();
                    if(parameters != null)
                    {
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.AddRange(parameters);
                    }

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        readAction(reader);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        public static int ExcuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int RetNRows = -1;
            try
            {
                if (!string.IsNullOrEmpty(query))
                {
                    sqlCommand.CommandText = query;

                    if (sqlConnection.State == System.Data.ConnectionState.Closed)
                        sqlConnection.Open();
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.AddRange(parameters);
                    }

                    RetNRows = sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return RetNRows;
        }
    }
}
