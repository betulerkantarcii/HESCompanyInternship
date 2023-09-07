using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HESCompany
{
    public class GenerateToken
    {

        private static string key = "44d93275f37146a5936d26e21fda329d";
        private static string appID = "d8d97b.vidyo.io";
        private static string userName = "";
        private static long expiresInSecs = 10000;
        private static string expiresAt = null;
        private static string generateToken = "";

        private const long EPOCH_SECONDS = 62167219200;

        public static string getToken(string userNameexact)
        {
            userName = userNameexact;
            if ((appID != null) && (key != null) && (userName != null))
            {
                string expires = "";

                // Check if using expiresInSecs or expiresAt
                if (expiresInSecs > 0)
                {
                    TimeSpan timeSinceEpoch = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0));
                    expires = (Math.Floor(timeSinceEpoch.TotalSeconds) + EPOCH_SECONDS + expiresInSecs).ToString();
                }

                string jid = userName + "@" + appID;
                string body = "provision" + "\0" + jid + "\0" + expires + "\0" + "";

                var encoder = new UTF8Encoding();
                var hmacsha = new HMACSHA384(encoder.GetBytes(key));
                byte[] mac = hmacsha.ComputeHash(encoder.GetBytes(body));

                string macHex = BytesToHex(mac);

                string serialized = body + '\0' + macHex;

                generateToken = Convert.ToBase64String(encoder.GetBytes(serialized));
            }

            return generateToken;
        }

        private static string BytesToHex(byte[] bytes)
        {
            var hex = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }



    }
}