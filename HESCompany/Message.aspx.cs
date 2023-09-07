using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Text;

namespace HESCompany
{
    public partial class Message : System.Web.UI.Page
    {



        DataTable tb = new DataTable();
        DataRow dr;
        static string id = "";

        protected void Page_Load(object sender, EventArgs e)
        {


            if ((Session["EmployeeID"] != null || Session["ExecutiveID"] != null) && Session["MessageRoomID"] != null)
            {

            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }

            if (Session["EmployeeID"] != null)
            {
                id = Session["EmployeeID"].ToString();
            }
            else
            {
                id = Session["ExecutiveID"].ToString();
            }


            Connection con = new Connection();
            string idm = Session["MessageRoomID"].ToString();
            string query = "select * from MessageRoom where RoomID='" + Session["MessageRoomID"] +"'";
            con.returnRoomID(query);
            string roomEmployee = con.getRoomEmployeeID();
            string Name = con.getRoomEmployeeName();
            string Head = con.getRoomMessageHead();
            string Participants = con.getRoomParticipants();

            LabelMesajHead.Text = Head;
            LabelMesajStarter.Text = Name;
            LabelMesajParticipants.Text = Participants;

            if (roomEmployee.Equals(id))
            {
                Button1.Visible = true;
            }
            else
            {
                Button1.Visible = false;
            }

            if (!IsPostBack)
            {

                createtable();

            }

        }

        public void createtable()

        {
            DataColumn columnAnotherName;
            columnAnotherName = new DataColumn();
            columnAnotherName.DataType = System.Type.GetType("System.String");
            columnAnotherName.ColumnName = "AnotherName";
            tb.Columns.Add(columnAnotherName);
            



            DataColumn columnAnother;
            columnAnother = new DataColumn();
            columnAnother.DataType = System.Type.GetType("System.String");
            columnAnother.ColumnName = "Another";
            tb.Columns.Add(columnAnother);


            DataColumn columnMe;
            columnMe = new DataColumn();
            columnMe.DataType = System.Type.GetType("System.String");
            columnMe.ColumnName = "Me";
            tb.Columns.Add(columnMe);




            string query = "select * from MessageTable where RoomID= '" + Session["MessageRoomID"] +"' ";
            Connection con = new Connection();
            con.getMessage(query);
            ArrayList message = con.getArrayListMessage();
            ArrayList messageEID = con.getEmployeeIDMessage();
            ArrayList messageEName = con.getEmployeeNameMessage();
            int count = message.Count;
            for(int i=0; i<count; i++)
            {
                dr = tb.NewRow();

                if (messageEID[i].Equals(id))
                {
                    dr["Me"] = message[i];
                }
                else
                {
                    dr["AnotherName"] = messageEName[i];
                    dr["Another"] = message[i];
                }

                tb.Rows.Add(dr);
            }

            Gridview1.DataSource = tb;
            Gridview1.DataBind();
            ViewState["table1"] = tb;

        }

        protected void AddMessage_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text.Equals(String.Empty))
            {

            }
            else
            {
                Connection con = new Connection();
                string queryName = "select * from EmployeeInfoTable where EmployeeID='" + id + "'";
                con.ConLogin(queryName);
                string name = con.getEmployeeName();
                string query = "insert into MessageTable values ('" + Session["MessageRoomID"] + "', '" + id + "', '" + TextBox1.Text.Trim() + "', '" + name + "')";
                con.ConUpdate(query);
                Response.Redirect("Message.aspx");
            }
        }

        protected void ButtonOffice_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            string query = "select TOP 1 MessageID from MessageTable where RoomID = '" + Session["MessageRoomID"] + "'  and EmployeeID != '" + id + "' ORDER BY(MessageID) DESC";
            int lastMessage = con.getLastMessageID(query);
            string getMessageID = "update MessageParticipant set MessageID='"+lastMessage+"' where ParticipantID = '" + id + "' and RoomID= '" + Session["MessageRoomID"] + "'";
            con.ConUpdate(getMessageID);
            Response.Redirect("Office.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            string query1 = "delete from MessageParticipant where RoomID ='" + Session["MessageRoomID"]+"'";
            string query2 = "delete from MessageTable where RoomID ='" + Session["MessageRoomID"] + "'";
            string query3 = "delete from MessageRoom where RooomID = '" + Session["MessageRoomID"]+"'";
            con.ConUpdate(query1);
            con.ConUpdate(query2);
            con.ConUpdate(query3);
            Response.Redirect("Office.aspx");
        }
    }
}

    