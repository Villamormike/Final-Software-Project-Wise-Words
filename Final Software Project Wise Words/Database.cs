using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
namespace Final_Software_Project_Wise_Words
{
    public static class Database
    {

        public class DatabaseConnection
        {
            //tells sqlite where to find the database file
            private readonly string _connectionString = "Data Source=./database.db";

            public SqliteConnection GetConnection()
            {
                try
                {
                    var connection = new SqliteConnection(_connectionString);
                    connection.Open();

                    return connection;
                }
                // If something goes wrong
                catch (SqliteException e)
                {
                    Console.WriteLine(e.Message);

                    throw;
                }
            }
        }
    }
}

