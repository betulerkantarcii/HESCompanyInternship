using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HESCompany
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmployeeID"] == null && Session["ExecutiveID"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            LabelUyariChangePasswordUyusmuyor.Visible = false;
            LabelUyariChangePassword.Visible = false;
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            string query = "OPEN SYMMETRIC KEY SymmetricKey3 DECRYPTION BY CERTIFICATE Certificate3  select * from EmployeeInfoTable WHERE CONVERT(nvarchar, DECRYPTBYKEY(EmployeePassword_encriypt)) ='" + TextBoxEnterPasswordCP.Text.Trim() + "'";
            bool check = con.ConLogin(query);
            if (check == true)
            {

                
                    if (TextBoxEnterNewPasswordCP.Text.Trim().Equals(TextBoxConfirmNewPasswordCP.Text.Trim()))
                    {

                    PasswordValidation val = new PasswordValidation();
                    if (val.ValidatePassword(TextBoxEnterNewPasswordCP.Text.Trim()))
                    {

                        string returnString = val.CheckPassword(con.get(), TextBoxEnterNewPasswordCP.Text.Trim());
                        if (!returnString.Equals("false"))
                        {
                            int returnInt = Convert.ToInt32(returnString);
                            string pass = "Password";
                            string addition = "_encriypt";
                            string column = pass + returnInt.ToString() + addition;
                            string queryPassword = "OPEN SYMMETRIC KEY SymmetricKey3 DECRYPTION BY CERTIFICATE Certificate3 Update EmployeeInfoTable set  " + column + " =  EncryptByKey(Key_Guid('SymmetricKey3'), Convert(nvarchar, '" + TextBoxEnterNewPasswordCP.Text.Trim() + "'))";
                            string queryPasswordIndex = "Update EmployeeInfoTable set PasswordIndex = '" + returnString + "'";
                            con.ConUpdate(queryPassword);
                            con.ConUpdate(queryPasswordIndex);
                            string queryUpdate = "OPEN SYMMETRIC KEY SymmetricKey3 DECRYPTION BY CERTIFICATE Certificate3 Update EmployeeInfoTable set EmployeePassword_encriypt= EncryptByKey(Key_Guid('SymmetricKey3'), Convert(nvarchar, '" + TextBoxEnterNewPasswordCP.Text.Trim() + "')) where EmployeeID = '" + con.get() + "'";
                            bool checkUpdate = con.ConUpdate(queryUpdate);
                            if (checkUpdate == true)
                            {
                                Response.Redirect("HomePage.aspx");
                            }

                        }
                        else
                        {

                            LabelUyariChangePasswordUyusmuyor.Visible = true;
                            LabelUyariChangePasswordUyusmuyor.Text = "yeni şifreniz önceki 5 şifre ile aynı olamaz!";
                        }

                    }
                    else
                    {
                        LabelUyariChangePasswordUyusmuyor.Visible = true;
                        LabelUyariChangePasswordUyusmuyor.Text = " Şifre en az 4 en fazla 8 karakterden oluşmalı, en az bir adet büyük ve küçük harf ve sayı içermek zorundadır!";
                    }

                    }
                    else
                    {
                        LabelUyariChangePasswordUyusmuyor.Visible = true;
                    LabelUyariChangePasswordUyusmuyor.Text = "Yeni şifre birbiriyle uyuşmuyor!";
                    }
            
            }
            else
            {
                LabelUyariChangePassword.Visible = true;

            }

            }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}