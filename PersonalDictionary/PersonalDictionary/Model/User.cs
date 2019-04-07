using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalDictionary
{
    [Table("users")]
    public class User
    {
        [PrimaryKey]
        public string Email { get; set; }

        public string Password { get; set; }

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public User()
        {

        }


    }
}
