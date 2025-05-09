using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Software_Project_Wise_Words
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string AccountLevel { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastLogin { get; set; }

        public static User LoggedInUser { get; set; }

        public static void Logout()
        {
            LoggedInUser = null;
        }
    }
}

