using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestApp.Data.Models;
using TestApp.Data;

namespace TestApp.BusinessLogic
{
    public static class UserManagement
    {
        public static bool UserExist(string username)
        {
            var dbContext = new TestApp.Data.AppContext();
            if (dbContext.Users.Find(username) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static User FindUser(string username)
        {
            var dbContext = new TestApp.Data.AppContext();
            return dbContext.Users.Find(username);
        }

        public static string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool IsUserPasswordCorrect(string username, string password)
        {
            User user = FindUser(username);
            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddUser(string username, string password)
        {
            var dbContext = new TestApp.Data.AppContext();
            User user = new User() { UserName=username, Password=EncryptPassword(password) };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
    }
}
