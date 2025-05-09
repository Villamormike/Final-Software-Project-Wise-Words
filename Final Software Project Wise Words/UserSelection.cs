using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Final_Software_Project_Wise_Words
{
    public static class UserSelection
    {
        public static void SaveUserSelection(int userId, string gradeLevel, string subject, string difficulty)
        {
            var db = new Database.DatabaseConnection();
            using (var connection = db.GetConnection())
            {
                // Check if there's already a row for this user
                string checkQuery = "SELECT COUNT(*) FROM user_difficulty WHERE user_id = @userId";
                using (var checkCmd = new SqliteCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@userId", userId);
                    long exists = (long)(checkCmd.ExecuteScalar() ?? 0);

                    string query;
                    if (exists > 0)
                    {
                        // Update the existing selection
                        query = "UPDATE user_difficulty SET grade_level = @grade, subject = @subject, difficulty = @difficulty WHERE user_id = @userId";
                    }
                    else
                    {
                        // Insert new selection
                        query = "INSERT INTO user_difficulty (user_id, grade_level, subject, difficulty) VALUES (@userId, @grade, @subject, @difficulty)";
                    }

                    using (var cmd = new SqliteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@grade", gradeLevel);
                        cmd.Parameters.AddWithValue("@subject", subject);
                        cmd.Parameters.AddWithValue("@difficulty", difficulty);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static (string grade, string subject, string difficulty)? LoadUserSelection(int userId)
        {
            var db = new Database.DatabaseConnection();
            using (var connection = db.GetConnection())
            {
                string query = "SELECT grade_level, subject, difficulty FROM user_difficulty WHERE user_id = @userId";
                using (var cmd = new SqliteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string grade = reader.GetString(0);
                            string subject = reader.GetString(1);
                            string difficulty = reader.GetString(2);
                            return (grade, subject, difficulty);
                        }
                    }
                }
            }
            return null;
        }
    }
}

