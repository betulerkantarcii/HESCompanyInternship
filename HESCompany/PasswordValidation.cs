using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Collections;
using System.Configuration;
using System.Drawing;

namespace HESCompany
{
    public class PasswordValidation
    {
        public bool ValidatePassword(string password)
        {
            string patternPassword = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$";
            if (!string.IsNullOrEmpty(password))
            {
                if (!Regex.IsMatch(password, patternPassword))
                {
                    return false;
                }

            }
            return true;
        }

        
        public string CheckPassword(string TBox1, string TBox2)
        {

            bool checkPassword = true;
            Connection con = new Connection();
            string queryPassword = "OPEN SYMMETRIC KEY SymmetricKey3 DECRYPTION BY CERTIFICATE Certificate3 SELECT PasswordIndex,  CONVERT(nvarchar, DECRYPTBYKEY(Password1_encriypt)) AS 'Password1_decrypted', CONVERT(nvarchar, DECRYPTBYKEY(Password2_encriypt)) AS 'Password2_decrypted', CONVERT(nvarchar, DECRYPTBYKEY(Password3_encriypt)) AS 'Password3_decrypted', CONVERT(nvarchar, DECRYPTBYKEY(Password4_encriypt)) AS 'Password4_decrypted', CONVERT(nvarchar, DECRYPTBYKEY(Password5_encriypt)) AS 'Password5_decrypted' FROM EmployeeInfoTable where EmployeeID = '" + TBox1 + "'";
            ArrayList Passwords = con.getPassword(queryPassword);
            String returnString = "false";
            for(int i = 1; i <= 5; i++) {

                string normalizedPasswords = Regex.Replace(Passwords[i].ToString(), @"\s", "");
                if (TBox2.ToString().Equals(normalizedPasswords.ToString()))
                {
                    checkPassword = false;
                    break;

                }
                else
                {
                    checkPassword = true;
                }
            }
            if(checkPassword == true)
            {

                for(int i=1; i<=5; i++)
                {
                    if (i.ToString().Equals(Passwords[0].ToString()))
                    {
                        int a = i%5+1; // define nth location to put  new password
                        returnString = a.ToString();

                    }

                }
            }
            else
            {
                returnString ="false";
            }
            
            return returnString;
        }





    }


    
}