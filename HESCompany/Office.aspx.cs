using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HESCompany
{

    public partial class Office : System.Web.UI.Page
    {

        static string id = "";

        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["EmployeeID"] != null || Session["ExecutiveID"] != null)
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

            PanelKonferansEkle.Visible = false;
            PanelMesajEkle.Visible = false;

            Connection con = new Connection();

            string queryExe = "select * from EmployeeInfoTable where EmployeeID = '" + id +"'";
            con.ConLogin(queryExe);
            string exeID = con.getExecutiveID();
            string query = "select EmployeeID, EmployeeName, Status from EmployeeInfoTable where ExecutiveID = '" + exeID + "' ";
            con.getCount(query);
            ArrayList employeeName = con.getArrayListofEmployeeName();
            ArrayList employeeStatus = con.getArrayListofEmployeeStatus();
            int count = employeeName.Count;

            for (int i = 0; i < count; i++)
            {

                string status = employeeStatus[i].ToString();
                if (status.Equals("1"))
                {
                    Label label = new Label();
                    label.ID = "cbKonferans" + i;
                    label.Text = employeeName[i].ToString();
                    label.CssClass = "checkboxOffice";
                    label.Width = 180;
                    label.Height = 190;
                    label.ForeColor = System.Drawing.Color.YellowGreen;
                    Form.Controls.Add(label);
                }
                else
                {
                    Label label = new Label();
                    label.ID = "cbKonferans" + i;
                    label.Text = employeeName[i].ToString();
                    label.CssClass = "checkboxOfficeOffline";
                    label.Width = 180;
                    label.Height = 190;
                    label.ForeColor = System.Drawing.Color.DarkGray;
                    Form.Controls.Add(label);
                }
            }

                if (!IsPostBack)
                {
                DataBagla();
                DataBaglaMesaj();
                }


        }

        public void DataBagla()
        {
           
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            string query = "Select  ConferenceID, ConferenceRequest, ConferenceSend From Conference,ConferenceSend WHERE  ConferenceSendRequest ='" + id + "' and Conference.ConferenceID = ConferenceSend.ConferenceRoomID";
            adp = new SqlDataAdapter(query, cnn);
            adp.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cnn.Close();
        }



        protected void ButtonCancelKonferans_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Office.aspx");
        }

        protected void ButtonKonferans_Click(object sender, EventArgs e)
        {
            PanelKonferansEkle.Visible = true;
            PanelMesaj.Visible = false;
            ButtonKonferans.Visible = false;
            GridView1.Visible = false;
        }

        protected void ButtonCurrentDepartment_Click(object sender, EventArgs e)
        {
            Response.Redirect("OfficeKonferans.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];
            Label LConferenceID = (Label)row.FindControl("LabelConferenceID");
            Session["RoomID"] = LConferenceID.Text;

            string queryName = "select * from EmployeeInfoTable where EmployeeID= '" + id + "'";
            Connection con = new Connection();
            con.ConLogin(queryName);
            string name = con.getEmployeeName();
            Session["Name"] = name;
            GenerateToken generatetoken = new GenerateToken();
            string tokenID = GenerateToken.getToken(id);
            Session["Token"] = tokenID;
            Response.Redirect("Konferans.aspx");

        }

        protected void ButtonMesaj_Click(object sender, EventArgs e)
        {
            PanelMesajEkle.Visible = true;
            PanelKonferans.Visible = false;
            ButtonMesaj.Visible = false;
            GridView2.Visible = false;
        }

        protected void ButtonCurrentDMesaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("OfficeMesaj.aspx");
        }

        protected void ButtonCancelMesaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("Office.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            Connection con = new Connection();

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                Label lb = (Label)GridView1.Rows[i].FindControl("LabelConferenceID");
                string query = "select * from ConferenceSend where ConferenceRoomID = '" + lb.Text + "' and ConferenceSendRequest='"+ id +"'";
                int seen = con.returnConferenceSeen(query);

                if (seen == 0)
                {
                    GridView1.Rows[i].Cells[3].BackColor = System.Drawing.Color.YellowGreen;
                }

            }
        }



        public void DataBaglaMesaj()
        {

            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            string query = "Select  MessageRoom.RoomID, MessageHead, EmployeeName, Participants From MessageRoom, MessageParticipant where MessageParticipant.ParticipantID = '"+id +"' and MessageRoom.RoomID = MessageParticipant.RoomID";
            adp = new SqlDataAdapter(query, cnn);
            adp.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            cnn.Close();
        }


        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            Connection con = new Connection();

            for(int i=0; i<GridView2.Rows.Count; i++)
            {
                Label lb = (Label)GridView2.Rows[i].FindControl("LabelRoomID");
                string query = "select TOP 1 MessageID from MessageTable where RoomID = '"+lb.Text+"'  and EmployeeID != '"+id +"' ORDER BY(MessageID) DESC";
                int lastMessage = con.getLastMessageID(query);

                string getMessageID = "select MessageID from MessageParticipant where ParticipantID = '" + id + "' and RoomID= '" + lb.Text+"'";
                int last = con.getLastMessageID(getMessageID);

                if (lastMessage > last)
                {
                    GridView2.Rows[i].Cells[4].BackColor = System.Drawing.Color.YellowGreen;
                }
                
            }
            
        }


        protected void GridView2_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView2.Rows[index];
            Label LRoomID = (Label)row.FindControl("LabelRoomID");
            Session["MessageRoomID"] = LRoomID.Text;
            Response.Redirect("Message.aspx");
        }

        protected void ButtonHomePage1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void ButtonExitLRF_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DateTime dateAndTime = DateTime.Now;
            string date = dateAndTime.ToString("yyyy/MM/dd");
            string hourMinute = DateTime.Now.ToString("HH:mm");
            string updateEnter = "update PersonelDateInfo set ExitPersonel = '" + hourMinute + "' where EmployeeID = '" + id + "' and DatePersonel = '" + date + "' ";
            con.ConUpdate(updateEnter);

            if (Session["EmployeeID"] != null)
            {
                string query = "update EmployeeInfoTable set Status = '" + 0 + "' where EmployeeID = '" + Session["EmployeeID"] + "'";
                con.ConUpdate(query);
                Session.Remove("EmployeeID");
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                string query = "update EmployeeInfoTable set Status = '" + 0 + "' where EmployeeID = '" + Session["ExecutiveID"] + "'";
                con.ConUpdate(query);
                Session.Remove("ExecutiveID");
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void ButtonAnotherDepartment_Click(object sender, EventArgs e)
        {
            Response.Redirect("OfficeKonferansAnother.aspx");
        }

        protected void ButtonAnotherDMesaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("OfficeMesajAnother.aspx");
        }

        
    }
}
 