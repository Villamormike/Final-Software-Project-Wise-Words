using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Final_Software_Project_Wise_Words
{
    public static class UserHistory
    {
        public static void SaveUserHistory(int userId, string activity, string details)
        {
            var db = new Database.DatabaseConnection();
            using (var connection = db.GetConnection())
            {
                string query = "INSERT INTO user_history (user_id, activity, details, activity_date) VALUES (@userId, @activity, @details, @date)";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@activity", activity);
                    command.Parameters.AddWithValue("@details", details);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable LoadUserHistory(int userId)
        {
            var db = new Database.DatabaseConnection();
            using (var connection = db.GetConnection())
            {
                string query = "SELECT activity, details, activity_date FROM user_history WHERE user_id = @userId ORDER BY activity_date DESC";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Activity");
                        dt.Columns.Add("Details");
                        dt.Columns.Add("ActivityDate");

                        while (reader.Read())
                        {
                            dt.Rows.Add(
                                reader["activity"].ToString(),
                                reader["details"].ToString(),
                                reader["activity_date"].ToString()
                            );
                        }

                        return dt;
                    }
                }
            }
        }
    }
}
