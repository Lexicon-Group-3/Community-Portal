using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UserManagement
    {
        public string UserEmail {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserManagement(string userEmail, string userName, string password)
        {
            UserEmail = userEmail;
            Username = userName;
            Password = password;
        }
        private List<UserManagement> users = new List<UserManagement>();
        
        public bool RegisterUser(string userEmail, string userName, string password)
        {
            

            if (UserExists(userName))
            {
                Console.WriteLine("Username is already taken. Please choose another.");
                return false;
            }

            UserManagement newUser = new UserManagement(userEmail, userName, password);
            users.Add(newUser);

            Console.WriteLine("User registered successfully.");
            return true;
        }

        private bool UserExists(string username)
        {
            return users.Any(user => user.Username == username);
        }
    }

}

