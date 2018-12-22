using EnvironmentsManager.classes.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentsManager.classes.env
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsSelected { get; set; }
        public UserType UserType { get; set; }

        public User(string name, string password, UserType userType)
        {
            Name = name;
            Password = password;
            UserType = userType;
        }
    }
}
