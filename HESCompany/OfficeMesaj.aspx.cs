using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace HESCompany
{
    public partial class OfficeMesaj : System.Web.UI.Page
    {

        static ArrayList employeeName;
        static ArrayList employeeStatus;
        static ArrayList employeeID;
        int count;
        static string id;


        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["EmployeeID"] != null || Session["ExecutiveID"] != null)
            {

            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }


            LabelChoose.Visible = false;
            
            if (Session["EmployeeID"] != null)
            {
                id = Session["EmployeeID"].ToString();
            }
            else
            {
                id = Session["ExecutiveID"].ToString();
            }
            
            Connection con = new Connection();
            string queryExe = "select * from EmployeeInfoTable where EmployeeID = '" + id + "'";
            con.ConLogin(queryExe);
            string exeID = con.getExecutiveID();
            string query = "select EmployeeID, EmployeeName, Status from EmployeeInfoTable where ExecutiveID = '" + exeID + "' and EmployeeID != '"+id +"'";
            con.getCount(query);
            employeeName = con.getArrayListofEmployeeName();
            employeeStatus = con.getArrayListofEmployeeStatus();
            employeeID = con.getArrayListofEmployeeID();
            count = employeeName.Count;
           
            for (int i = 0; i < count; i++)
            {

                string status = employeeStatus[i].ToString();
                if (status.Equals("1")){
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferans" + i;
                    cb.Text = employeeName[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOffice";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.YellowGreen;
                    Form.Controls.Add(cb);
                }
                else
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferans" + i;
                    cb.Text = employeeName[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOfficeOffline";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.DarkGray;
                    Form.Controls.Add(cb);
                }
                


            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

                string id;

                if (Session["EmployeeID"] != null)
                {
                    id = Session["EmployeeID"].ToString();
                }
                else
                {
                    id = Session["ExecutiveID"].ToString();
                }


                Connection con = new Connection();

                string queryExecutive = "select * from EmployeeInfoTable where EmployeeID = '" + id + "'";
                con.ConLogin(queryExecutive);
                string EmployeeName = con.getEmployeeName();
                string ExecutiveID = con.getExecutiveID();


                string queryMessageRoom = "insert into MessageRoom values('" + id + "', '" + EmployeeName + "','" + TextBoxMesajHead.Text + "', '" + "" + "')";
                con.ConUpdate(queryMessageRoom);

                string getMessageRoom = "select Top 1 * from MessageRoom where EmployeeID = '" + id + "' order by RoomID DESC";
                int RoomID = con.returnRoomID(getMessageRoom);

                string addParticipant = "insert into MessageParticipant values ('" + RoomID + "', '" + id + "', '" + 0 + "')";
                con.ConUpdate(addParticipant);


                string katılımcı = EmployeeName + " ";
                int numberofchecked =  0;

                for (int i = 0; i < count; i++)
                {
                    var cb = Form.FindControl("cbKonferans" + i) as CheckBox;
                    if (cb.Checked == true)
                    {
                        numberofchecked++;
                        katılımcı += employeeName[i].ToString() + " ";
                        int katılımcıID = Convert.ToInt32(employeeID[i].ToString());
                        string MessageParticipant = "insert into MessageParticipant values('" + RoomID + "', '" + katılımcıID + "', '" + 0 + "')";
                        con.ConUpdate(MessageParticipant);

                    }
                }

                string updateRoom = "update MessageRoom set Participants = '" + katılımcı + "' where RoomID = '" + RoomID + "'";
                con.ConUpdate(updateRoom);
                Session["MessageRoomID"] = RoomID;
                if(numberofchecked > 0 && LabelChoose.Text != String.Empty)
                {
                     Response.Redirect("Message.aspx");
                }
                else if(LabelChoose.Text == String.Empty)
                {
                    LabelChoose.Visible = true;
                    LabelChoose.Text = "Sohbet başlığı belirleyin!";
                }
                else if (numberofchecked  == 0)
                {
                    LabelChoose.Visible = true;
                    LabelChoose.Text = "En az bir kişi seçin!";
                }
                

            
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Office.aspx");
        }



        protected void cbAllKonferans_CheckedChanged(object sender, EventArgs e)
        {
           

            if (cbAllKonferans.Checked)
            {
                for (int i = 0; i < count; i++)
                {
                    var cb = Form.FindControl("cbKonferans" + i) as CheckBox;
                    cb.Checked = true;
                }

            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    var cb = Form.FindControl("cbKonferans" + i) as CheckBox;
                    cb.Checked = false;
                }
            }
        }
    }
}