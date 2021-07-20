using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace kursa4_Samsonova
{
    class SQLConnector
    {
        // строка подключения к БД
        //static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True;Connect Timeout=30";
       
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\LORD\SOURCE\REPOS\KURSA4_SAMSONOVA\KURSA4_SAMSONOVA\DB.MDF;Integrated Security=True;Connect Timeout=30";
        private SqlConnection con;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public SQLConnector()
        {

            con = new SqlConnection(connectionString);

            Console.WriteLine("Try");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            Console.WriteLine("Connect");

            con.Close();
            printALL("table_card");
        }
    
        public void printALL(string table)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //Console.WriteLine("Connect");
            //cmd.CommandText = "Select * from table_card";
            //cmd.Parameters.AddWithValue("table", table);
            //cmd.Connection = con;
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.Write(reader[0].ToString() + " ");
            //    Console.Write(reader[1].ToString() + " ");
            //    Console.Write(reader[2].ToString() + " ");
            //    Console.WriteLine(reader[3].ToString());
            //}
            //con.Close();
        }

        public async Task<SqlDataReader> ExecuteQuery(string query)
        {
            Console.WriteLine("Execute query: " + query);
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand(query, sqlConnection);
            try
            {
                if (query.IndexOf("SELECT") == 0)
                {
                    //sqlReader = await command.ExecuteReaderAsync();
                    //while (await sqlReader.ReadAsync())
                    //{
                    //    Console.WriteLine(Convert.ToString(sqlReader["Id"]) + "   " + Convert.ToString(sqlReader["name"]) + "  " + Convert.ToString(sqlReader["family"]) + "   " + Convert.ToString(sqlReader["patronic"]));
                    //}
                    sqlReader = await command.ExecuteReaderAsync();
                    //Console.WriteLine(Convert.ToString(sqlReader["name"]));
                    return sqlReader;

                }
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            //finally
            //{
            //    if (sqlReader != null)
            //        sqlReader.Close();
            //}
            return null;
        }
    }
}
