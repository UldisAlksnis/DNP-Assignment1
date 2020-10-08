using Assignment1.Models.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Data.Authorization.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;
        public InMemoryUserService()
        {

            users = new[]{
                new User
                {
                    City = "Horsens",
                    Domain = "assignment1.family",
                    Password = "111111",
                    Role = "Admin",
                    BirthYear = 1997,
                    SecurityLevel = 4,
                    UserName = "Admin"
                },
                new User
                {
                    City = "Horsens",
                    Domain = "assignment1.family",
                    Password = "111111",
                    Role = "User",
                    BirthYear = 1997,
                    SecurityLevel = 2,
                    UserName = "User"
                }
            }.ToList();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }
            if (!first.Password.Equals(password))
            {
                throw new Exception("Īncorrect password");
            }
            return first;
        }
    }
}
