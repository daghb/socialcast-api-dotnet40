using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SocialcastApiHelper
{
    public class SocialcastCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string SocialcastUrl { get; set; }

        public SocialcastCredentials(string Username, string Password, string SocialcastUrl)
        {
            this.Username = Username;
            this.Password = Password;
            this.SocialcastUrl = Regex.Replace(SocialcastUrl, "^(http|ftp|news)s?:\\/\\/", "");
        }
    }
}
