using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialcastApi
{
    public class SocialcastCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }

        public SocialcastCredentials(string Username, string Password, string Domain)
        {
            this.Username = Username;
            this.Password = Password;
            this.Domain = Domain;
        }
    }
}
