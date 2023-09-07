using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HESCompany
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelUyari.Visible = false;
            
        }


       


        protected void Buttonlogin_Click(object sender, EventArgs e)
        {

           
            string query = "OPEN SYMMETRIC KEY SymmetricKey3 DECRYPTION BY CERTIFICATE Certificate3 select * from EmployeeInfoTable WHERE EmployeeID ='" + TextBoxusername.Text.Trim() + "' and CONVERT(nvarchar, DECRYPTBYKEY(EmployeePassword_encriypt)) ='" + TextBoxpassword.Text.Trim() + "'";
            Connection con = new Connection();
            bool check = con.ConLogin(query);
            if (check == true)
            {

                if (con.getExecutiveID().Equals(con.get()))
                {
                    string statusEx = "update EmployeeInfoTable set Status = '" + 1 +"' where EmployeeID = '"+con.get() +"'";
                    con.ConUpdate(statusEx);
                    Session["ExecutiveID"] = con.get();     
                    Session["ExecutiveName"] = con.getEmployeeName();
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    string status = "update EmployeeInfoTable set Status = '" + 1 + "' where EmployeeID = '" + con.get() + "'";
                    con.ConUpdate(status);
                    string id = con.get();
                    Session["EmployeeID"] = con.get();
                    Session["EmployeeName"] = con.getEmployeeName();
                    string hourMinute = DateTime.Now.ToString("HH:mm");
                    DateTime dateAndTime = DateTime.Now;
                    string date = dateAndTime.ToString("yyyy/MM/dd");
                    string queryEnter = "select EnterPersonel from PersonelDateInfo where EmployeeID = '" + id +"' and DatePersonel = '"+ date +"'";
                    Date dateTime = new Date();
                    string EnterPersonel = dateTime.returnDate(queryEnter);
                    if (EnterPersonel.Equals(""))
                    {
                        string updateEnter = "update PersonelDateInfo set EnterPersonel = '" + hourMinute + "' where EmployeeID = '" + id + "' and DatePersonel = '" + date + "' ";
                        con.ConUpdate(updateEnter);
                    }
                    

                    Response.Redirect("HomePage.aspx");
                }

            }
            else
            {
                LabelUyari.Visible = true;
            }
        }

        protected void LinkSifreUnuttum_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgetPassword.aspx");
        }
    }
}