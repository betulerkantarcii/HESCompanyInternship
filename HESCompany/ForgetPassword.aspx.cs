using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Drawing;

namespace HESCompany
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Panel2forgetpassword.Visible = false;
            LabelUyariForgetPassword.Visible = false;
        }

        protected void ConfirmForgetPasswordButton_Click(object sender, EventArgs e)
        {

            Connection con = new Connection();
            string query = "select * from EmployeeInfoTable  WHERE EmployeeID = '" + TextBoxGetID.Text.Trim() + "' and ( lower(EmployeeSecurityAnswer) ='" + TextBoxForgetPassword.Text.Trim() + "' or upper(EmployeeSecurityAnswer) ='" + TextBoxForgetPassword.Text.Trim() + "' )";
            bool check = con.ConLogin(query);
            if (check == true)
            {
                Panel1forgetpassword.Visible = false;
                Panel2forgetpassword.Visible = true;
            }
            else
            {
                Panel1forgetpassword.Visible = true;
                Label2ForgetPassword.Text = "Sicil numarası veya güvenlik cevabınız hatalı!";
                Label2ForgetPassword.ForeColor = Color.DarkRed;
            }


        }

        protected void CancelForgetPasswordButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void CancelNewPasswordForgetP_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void ConfirmNewPasswordForgetP_Click1(object sender, EventArgs e)
        {
           
            if (TextBoxEnterNewPassword.Text.Equals(TextBoxConfirmNewPassword.Text))
            {
                PasswordValidation val = new PasswordValidation();
                if (val.ValidatePassword(TextBoxEnterNewPassword.Text.Trim()))
                {
                    string returnString = val.CheckPassword(TextBoxGetID.Text.Trim(), TextBoxEnterNewPassword.Text.Trim());
                    if (! returnString.Equals("false"))
                    {

                        Connection con = new Connection();
                        int returnInt = Convert.ToInt32(returnString);
                        string pass = "Password";
                        string addition = "_encriypt";
                        string column = pass + returnInt.ToString() + addition;
                        string queryPassword = "OPEN SYMMETRIC KEY SymmetricKey3 DECRYPTION BY CERTIFICATE Certificate3  Update EmployeeInfoTable set " + column+ " = EncryptByKey(Key_Guid('SymmetricKey3'), Convert(nvarchar, '" + TextBoxEnterNewPassword.Text.Trim() + "')) where EmployeeID = '" + TextBoxGetID.Text.Trim() + "'";
                        string queryPasswordIndex = "Update EmployeeInfoTable set PasswordIndex = '" + returnString + "' where EmployeeID = '"+TextBoxGetID.Text.Trim() +"'";
                        con.ConUpdate(queryPassword);
                        con.ConUpdate(queryPasswordIndex);
                        string query = "OPEN SYMMETRIC KEY SymmetricKey3 DECRYPTION BY CERTIFICATE Certificate3 Update EmployeeInfoTable set EmployeePassword_encriypt= EncryptByKey(Key_Guid('SymmetricKey3'), Convert(nvarchar, '" + TextBoxEnterNewPassword.Text.Trim() + "')) where EmployeeID = '" + TextBoxGetID.Text.Trim() + "'";
                        bool check = con.ConUpdate(query);
                        if (check == true)
                        {
                            Response.Redirect("LoginPage.aspx");
                        }
                       

                    }
                    else
                    {
                        Panel2forgetpassword.Visible = true;
                        LabelUyariForgetPassword.Visible = true;
                        LabelUyariForgetPassword.Text = "yeni şifre önceki 5 şifre ile aynı olamaz!";
                    }

                }
                else
                {
                    Panel2forgetpassword.Visible = true;
                    LabelUyariForgetPassword.Visible = true;
                    LabelUyariForgetPassword.Text = " Şifre en az 4 en fazla 8 karakterden oluşmalı, en az bir adet büyük ve küçük harf ve sayı içermek zorundadır!";
                }
            }
            else
            {
                Panel2forgetpassword.Visible = true;
                LabelUyariForgetPassword.Visible = true;
                LabelUyariForgetPassword.Text = "Şifreler birbiriyle uyuşmuyor!";
            }
        }
           
        }
    }
