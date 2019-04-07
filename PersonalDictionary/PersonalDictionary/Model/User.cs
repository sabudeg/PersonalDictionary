using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalDictionary
{
    [Table("users")]
    class User
    {
        public string email { get; set; }
        public string password { get; set; }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }


    }
}
