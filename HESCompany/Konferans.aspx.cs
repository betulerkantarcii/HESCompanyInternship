using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HESCompany
{
    public partial class Konferans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

            if((Session["EmployeeID"] != null || Session["ExecutiveID"] != null) && Session["RoomID"] != null)
            {

            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }

            string id = "";
            if(Session["EmployeeID"] != null)
            {
                id = Session["EmployeeID"].ToString();
            }
            else
            {
                id = Session["ExecutiveID"].ToString();
            }

            string query = "select * from Conference where ConferenceID = '"+Session["RoomID"]+"'";
            Connection con = new Connection();
            con.returnConferenceID(query);
            string EmployeeID =con.getConferenceEmployeeID();

            if (EmployeeID.Equals(id))
            {
                Button2.Visible = true;
            }
            else
            {
                Button2.Visible = false;
            }

            string querySeen = "update ConferenceSend set ConferenceSeen='" + 1 +"' where ConferenceSendRequest = '"+ id +"'";
            con.ConUpdate(querySeen);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Office.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string query1 = "delete from Conference where ConferenceID = '" + Session["RoomID"]+"'";
            string query2 = "delete from ConferenceSend where ConferenceRoomID = '" + Session["RoomID"]+"'";
            Connection con = new Connection();
            con.ConUpdate(query2);
            con.ConUpdate(query1);
            Response.Redirect("Office.aspx");
        }
    }
}