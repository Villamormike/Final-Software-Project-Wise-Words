using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Final_Software_Project_Wise_Words
{
    public class Difficulty_Selection
    {
        public static string SelectedDifficulty { get; set; } = "";
        public static string SelectedSubject { get; set; } = "";
        public static string SelectedGrade { get; set; } = "";

        public static bool IsSelectionComplete() =>
            !string.IsNullOrEmpty(SelectedDifficulty) &&
            !string.IsNullOrEmpty(SelectedSubject) &&
            !string.IsNullOrEmpty(SelectedGrade);

        public static void Randomize()
        {
            var random = new Random();
            string[][] options =
            {
            new[] { "Easy", "Moderate", "Hard" },
            new[] { "Kindergarten", "Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5" ,"Grade 6"},
            new[] { "Math", "Science", "English" }
        };

            SelectedDifficulty = options[0][random.Next(options[0].Length)];
            SelectedGrade = options[1][random.Next(options[1].Length)];
            SelectedSubject = options[2][random.Next(options[2].Length)];
        }
        public static void SaveSelection(int userId)
        {
            var db = new Database.DatabaseConnection();
            using (var connection = db.GetConnection())
            {
                string query = "INSERT OR REPLACE INTO user_difficulty (user_id, grade_level, subject, difficulty) " +
                               "VALUES (@userId, @grade, @subject, @difficulty)";

                using (var cmd = new SqliteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@grade", SelectedGrade);
                    cmd.Parameters.AddWithValue("@subject", SelectedSubject);
                    cmd.Parameters.AddWithValue("@difficulty", SelectedDifficulty);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Load the difficulty selection from the database
        public static bool LoadSelection(int userId)
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
                            SelectedGrade = reader.GetString(0);
                            SelectedSubject = reader.GetString(1);
                            SelectedDifficulty = reader.GetString(2);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
