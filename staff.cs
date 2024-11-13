using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;


namespace WinFormsApp1
{
    internal class staff : CRUD<staff>
    {
       // public int id { get; set; } 
        public string name { get; set; }
        [Key]
        public string username { get; set; }
        [DefaultValue("12345678")]
        public string password { get; set; }

        public static string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        // Method to log in a user
        public bool login(string user, string password, Context context)
        {
            var logged = context.staff.Find(user);

            // Verify if the user exists and the password matches the stored hash
            if (logged != null && BCrypt.Net.BCrypt.Verify(password, logged.password))
            {
                return true; // Login successful
            }

            return false; // Login failed
        }

        public int Add(staff staff, Context context)
        {
            staff.password = BCrypt.Net.BCrypt.HashPassword(staff.password); 
            context.staff.Add(staff);
            return context.SaveChanges();
        }

    }
}
