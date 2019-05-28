using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21UserRegistration.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Country{ get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User()
        {

        }

        public User(string userName, string country, string city, string password, string email)
        {
            UserName = userName;
            Country = country;
            City = city;
            Password = password;
            Email = email;
        }
    }
}