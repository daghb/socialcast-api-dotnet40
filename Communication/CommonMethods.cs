using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using SocialCastApiHelper;

namespace SocialcastApi
{
    public class CommonMethods
    {
        private static string socialcastUrl = "https://socialcast.com/";

        private static string authenticationApi = "api/authentication.json";

        private static SocialcastCredentials loggedOnUserCredentials { get; set; }

        public CommonMethods(SocialcastCredentials credentials)
        {
            loggedOnUserCredentials = credentials;
        }

        public string GetAllCommunitiesForUser()
        {
            return Communicate.PostServiceCall(socialcastUrl + authenticationApi, loggedOnUserCredentials, "");
        }

    }
}
