﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.IO;

namespace SocialcastApiHelper
{
    public class Communicate
    {
        public static string PostServiceCall(string requestURL, SocialcastCredentials credentials, string data)
        {
            ServicePointManager.ServerCertificateValidationCallback += delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                // Accept remote certificate regardless of irregularities
                return true;
            };

            // Create the web request
            HttpWebRequest request = WebRequest.Create(requestURL) as HttpWebRequest;

            request.Credentials = new System.Net.NetworkCredential(credentials.Username, credentials.Password);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";

            byte[] bytes = Encoding.UTF8.GetBytes(data);

            request.ContentLength = bytes.Length;
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);

                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }


    }
}
