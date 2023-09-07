using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace HESCompany
{
    public partial class OfficeKonferansAnother : System.Web.UI.Page
    {

        static string id="";
        static int countIK = 0;
        static int countM = 0;
        static int countP = 0;
        static int countYI = 0;
        static int countYD = 0;
        static int countBI = 0;
        static int countGM = 0;

        static ArrayList employeeNameIK;
        static ArrayList employeeStatusIK;
        static ArrayList employeeIDIK;

        static ArrayList employeeNameM;
        static ArrayList employeeStatusM;
        static ArrayList employeeIDM;

        static ArrayList employeeNameP;
        static ArrayList employeeStatusP;
        static ArrayList employeeIDP;

        static ArrayList employeeNameYI;
        static ArrayList employeeStatusYI;
        static ArrayList employeeIDYI;

        static ArrayList employeeNameYD;
        static ArrayList employeeStatusYD;
        static ArrayList employeeIDYD;

        static ArrayList employeeNameBI;
        static ArrayList employeeStatusBI;
        static ArrayList employeeIDBI;

        static ArrayList employeeNameGM;
        static ArrayList employeeStatusGM;
        static ArrayList employeeIDGM;


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

   
            Another another = new Another();
            string queryIK = "select EmployeeID, EmployeeName, Status from EmployeeInfoTable where ExecutiveID = '" + "110110285" + "' and EmployeeID != '" + id + "'";
            another.getCountAnother(queryIK,1);
            employeeNameIK = another.ListofEmployeeNameIK();
            employeeStatusIK = another.ListofEmployeeStatusIK();
            employeeIDIK = another.ListofEmployeeIDIK();
            countIK = employeeNameIK.Count;

            for (int i = 0; i < countIK; i++)
            {

                string status = employeeStatusIK[i].ToString();
                if (status.Equals("1"))
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansIK" + i;
                    cb.Text = employeeNameIK[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOffice";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.YellowGreen;
                    Panel1.Controls.Add(cb);
                }
                else
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansIK" + i;
                    cb.Text = employeeNameIK[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOfficeOffline";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.DarkGray;
                    Panel1.Controls.Add(cb);
                }
            }



            string queryM = "select EmployeeID, EmployeeName, Status from EmployeeInfoTable where ExecutiveID = '" + "110210285" + "' and EmployeeID != '" + id + "'";
            another.getCountAnother(queryM,2);
            employeeNameM = another.ListofEmployeeNameM();
            employeeStatusM = another.ListofEmployeeStatusM();
            employeeIDM = another.ListofEmployeeIDM();
            countM = employeeNameM.Count;

            for (int i = 0; i < countM; i++)
            {

                string status = employeeStatusM[i].ToString();
                if (status.Equals("1"))
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansM" + i;
                    cb.Text = employeeNameM[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOffice";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.YellowGreen;
                    Panel2.Controls.Add(cb);
                }
                else
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansM" + i;
                    cb.Text = employeeNameM[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOfficeOffline";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.DarkGray;
                    Panel2.Controls.Add(cb);
                }
            }


            string queryP = "select EmployeeID, EmployeeName, Status from EmployeeInfoTable where ExecutiveID = '" + "110310285" + "' and EmployeeID != '" + id + "'";
            another.getCountAnother(queryP,3);
            employeeNameP = another.ListofEmployeeNameP();
            employeeStatusP = another.ListofEmployeeStatusP();
            employeeIDP = another.ListofEmployeeIDP();
            countP = employeeNameP.Count;

            for (int i = 0; i < countP; i++)
            {

                string status = employeeStatusP[i].ToString();
                if (status.Equals("1"))
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansP" + i;
                    cb.Text = employeeNameP[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOffice";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.YellowGreen;
                    Panel3.Controls.Add(cb);
                }
                else
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansP" + i;
                    cb.Text = employeeNameP[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOfficeOffline";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.DarkGray;
                    Panel3.Controls.Add(cb);
                }
            }


            string queryYI = "select EmployeeID, EmployeeName, Status from EmployeeInfoTable where ExecutiveID = '" + "110410285" + "' and EmployeeID != '" + id + "'";
            another.getCountAnother(queryYI,4);
            employeeNameYI = another.ListofEmployeeNameYI();
            employeeStatusYI = another.ListofEmployeeStatusYI();
            employeeIDYI = another.ListofEmployeeIDYI();
            countYI = employeeNameYI.Count;

            for (int i = 0; i < countYI; i++)
            {

                string status = employeeStatusYI[i].ToString();
                if (status.Equals("1"))
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansYI" + i;
                    cb.Text = employeeNameYI[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOffice";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.YellowGreen;
                    Panel4.Controls.Add(cb);
                }
                else
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansYI" + i;
                    cb.Text = employeeNameYI[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOfficeOffline";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.DarkGray;
                    Panel4.Controls.Add(cb);
                }
            }



            string queryYD = "select EmployeeID, EmployeeName, Status from EmployeeInfoTable where ExecutiveID = '" + "110610285" + "' and EmployeeID != '" + id + "'";
            another.getCountAnother(queryYD,5);
            employeeNameYD = another.ListofEmployeeNameYD();
            employeeStatusYD = another.ListofEmployeeStatusYD();
            employeeIDYD = another.ListofEmployeeIDYD();
            countYD = employeeNameYD.Count;

            for (int i = 0; i < countYD; i++)
            {

                string status = employeeStatusYD[i].ToString();
                if (status.Equals("1"))
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansYD" + i;
                    cb.Text = employeeNameYD[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOffice";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.YellowGreen;
                    Panel5.Controls.Add(cb);
                }
                else
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansYD" + i;
                    cb.Text = employeeNameYD[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOfficeOffline";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.DarkGray;
                    Panel5.Controls.Add(cb);
                }
            }



            string queryBI = "select EmployeeID, EmployeeName, Status from EmployeeInfoTable where ExecutiveID = '" + "110510285" + "' and EmployeeID != '" + id + "'";
            another.getCountAnother(queryBI,6);
            employeeNameBI = another.ListofEmployeeNameBI();
            employeeStatusBI = another.ListofEmployeeStatusBI();
            employeeIDBI = another.ListofEmployeeIDBI();
            countBI = employeeNameBI.Count;

            for (int i = 0; i < countBI; i++)
            {

                string status = employeeStatusBI[i].ToString();
                if (status.Equals("1"))
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansBI" + i;
                    cb.Text = employeeNameBI[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOffice";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.YellowGreen;
                    Panel6.Controls.Add(cb);
                }
                else
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansBI" + i;
                    cb.Text = employeeNameBI[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOfficeOffline";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.DarkGray;
                    Panel6.Controls.Add(cb);
                }
            }


            string queryGM = "select EmployeeID, EmployeeName, Status from EmployeeInfoTable where ExecutiveID = '" + "110710285" + "' and EmployeeID != '" + id + "'";
            another.getCountAnother(queryGM, 7);
            employeeNameGM = another.ListofEmployeeNameGM();
            employeeStatusGM = another.ListofEmployeeStatusGM();
            employeeIDGM = another.ListofEmployeeIDGM();
            countGM = employeeNameGM.Count;

            for (int i = 0; i < countGM; i++)
            {

                string status = employeeStatusGM[i].ToString();
                if (status.Equals("1"))
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansGM" + i;
                    cb.Text = employeeNameGM[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOffice";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.YellowGreen;
                    Panel7.Controls.Add(cb);
                }
                else
                {
                    CheckBox cb = new CheckBox();
                    cb.ID = "cbKonferansGM" + i;
                    cb.Text = employeeNameGM[i].ToString();
                    cb.AutoPostBack = true;
                    cb.CssClass = "checkboxOfficeOffline";
                    cb.Width = 200;
                    cb.Height = 210;
                    cb.ForeColor = System.Drawing.Color.DarkGray;
                    Panel7.Controls.Add(cb);
                }
            }
        }

        protected void CheckBoxIK_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBoxIK.Checked)
            {
                for (int i = 0; i < countIK; i++)
                {
                    var cb = Panel1.FindControl("cbKonferansIK" + i) as CheckBox;
                    cb.Checked = true;
                }

            }
            else
            {
                for (int i = 0; i < countIK; i++)
                {
                    var cb = Panel1.FindControl("cbKonferansIK" + i) as CheckBox;
                    cb.Checked = false;
                }
            }
        }


        protected void CheckBoxM_CheckedChanged(object sender, EventArgs e)
        {


            if (CheckBoxM.Checked)
            {
                for (int i = 0; i < countM; i++)
                {
                    var cb = Panel2.FindControl("cbKonferansM" + i) as CheckBox;
                    cb.Checked = true;
                }

            }
            else
            {
                for (int i = 0; i < countM; i++)
                {
                    var cb = Panel2.FindControl("cbKonferansM" + i) as CheckBox;
                    cb.Checked = false;
                }
            }
        }


        protected void CheckBoxP_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxP.Checked)
            {
                for (int i = 0; i < countP; i++)
                {
                    var cb = Panel3.FindControl("cbKonferansP" + i) as CheckBox;
                    cb.Checked = true;
                }

            }
            else
            {
                for (int i = 0; i < countP; i++)
                {
                    var cb = Panel3.FindControl("cbKonferansP" + i) as CheckBox;
                    cb.Checked = false;
                }
            }
        }

        protected void CheckBoxYI_CheckedChanged(object sender, EventArgs e)
        {


            if (CheckBoxYI.Checked)
            {
                for (int i = 0; i < countYI; i++)
                {
                    var cb = Panel4.FindControl("cbKonferansYI" + i) as CheckBox;
                    cb.Checked = true;
                }

            }
            else
            {
                for (int i = 0; i < countYI; i++)
                {
                    var cb = Panel4.FindControl("cbKonferansYI" + i) as CheckBox;
                    cb.Checked = false;
                }
            }
        }

        protected void CheckBoxYD_CheckedChanged(object sender, EventArgs e)
        {


            if (CheckBoxYD.Checked)
            {
                for (int i = 0; i < countYD; i++)
                {
                    var cb = Panel5.FindControl("cbKonferansYD" + i) as CheckBox;
                    cb.Checked = true;
                }

            }
            else
            {
                for (int i = 0; i < countYD; i++)
                {
                    var cb = Panel5.FindControl("cbKonferansYD" + i) as CheckBox;
                    cb.Checked = false;
                }
            }
        }

        protected void CheckBoxBI_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBoxBI.Checked)
            {
                for (int i = 0; i < countBI; i++)
                {
                    var cb = Panel6.FindControl("cbKonferansBI" + i) as CheckBox;
                    cb.Checked = true;
                }

            }
            else
            {
                for (int i = 0; i < countBI; i++)
                {
                    var cb = Panel6.FindControl("cbKonferansBI" + i) as CheckBox;
                    cb.Checked = false;
                }
            }
        }


        protected void CheckBoxGM_CheckedChanged(object sender, EventArgs e)
        {


            if (CheckBoxGM.Checked)
            {
                for (int i = 0; i < countGM; i++)
                {
                    var cb = Panel7.FindControl("cbKonferansGM" + i) as CheckBox;
                    cb.Checked = true;
                }

            }
            else
            {
                for (int i = 0; i < countGM; i++)
                {
                    var cb = Panel7.FindControl("cbKonferansGM" + i) as CheckBox;
                    cb.Checked = false;
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            

            Connection con = new Connection();
            string queryExecutive = "select * from EmployeeInfoTable where EmployeeID = '" + id + "'";
            con.ConLogin(queryExecutive);
            string ExecutiveID = con.getExecutiveID();
            string queryAdd = "insert into Conference values('" + id + "', '" + "a" + "', '" + "a" + "')";
            con.ConUpdate(queryAdd);
            string selectID = "select Top 1 * from Conference order by ConferenceID DESC";
            int conferenceID = con.returnConferenceID(selectID);
            string katılımcı = "";
            int numberofchecked = 0;

            for (int i = 0; i < countIK; i++)
            {
                var cb = Panel1.FindControl("cbKonferansIK" + i) as CheckBox;
                if (cb.Checked == true)
                {
                    katılımcı += employeeNameIK[i].ToString() + " ";
                    int katılımcıID = Convert.ToInt32(employeeIDIK[i].ToString());
                    string ConferenceSend = "insert into ConferenceSend values('" + conferenceID + "', '" + katılımcıID + "', '"+0+"')";
                    con.ConUpdate(ConferenceSend);
                    numberofchecked++;
                }
            }

            for (int i = 0; i < countM; i++)
            {
                var cb = Panel2.FindControl("cbKonferansM" + i) as CheckBox;
                if (cb.Checked == true)
                {
                    katılımcı += employeeNameM[i].ToString() + " ";
                    int katılımcıID = Convert.ToInt32(employeeIDM[i].ToString());
                    string ConferenceSend = "insert into ConferenceSend values('" + conferenceID + "', '" + katılımcıID + "', '" + 0 + "')";
                    con.ConUpdate(ConferenceSend);
                    numberofchecked++;
                }
            }

            for (int i = 0; i < countP; i++)
            {
                var cb = Panel3.FindControl("cbKonferansP" + i) as CheckBox;
                if (cb.Checked == true)
                {
                    katılımcı += employeeNameP[i].ToString() + " ";
                    int katılımcıID = Convert.ToInt32(employeeIDP[i].ToString());
                    string ConferenceSend = "insert into ConferenceSend values('" + conferenceID + "', '" + katılımcıID + "', '" + 0 + "')";
                    con.ConUpdate(ConferenceSend);
                    numberofchecked++;
                }
            }


            for (int i = 0; i < countYI; i++)
            {
                var cb = Panel4.FindControl("cbKonferansYI" + i) as CheckBox;
                if (cb.Checked == true)
                {
                    katılımcı += employeeNameYI[i].ToString() + " ";
                    int katılımcıID = Convert.ToInt32(employeeIDYI[i].ToString());
                    string ConferenceSend = "insert into ConferenceSend values('" + conferenceID + "', '" + katılımcıID + "', '" + 0 + "')";
                    con.ConUpdate(ConferenceSend);
                    numberofchecked++;
                }
            }


            for (int i = 0; i < countYD; i++)
            {
                var cb = Panel5.FindControl("cbKonferansYD" + i) as CheckBox;
                if (cb.Checked == true)
                {
                    katılımcı += employeeNameYD[i].ToString() + " ";
                    int katılımcıID = Convert.ToInt32(employeeIDYD[i].ToString());
                    string ConferenceSend = "insert into ConferenceSend values('" + conferenceID + "', '" + katılımcıID + "', '" + 0 + "')";
                    con.ConUpdate(ConferenceSend);
                    numberofchecked++;
                }
            }


            for (int i = 0; i < countBI; i++)
            {
                var cb = Panel6.FindControl("cbKonferansBI" + i) as CheckBox;
                if (cb.Checked == true)
                {
                    katılımcı += employeeNameBI[i].ToString() + " ";
                    int katılımcıID = Convert.ToInt32(employeeIDBI[i].ToString());
                    string ConferenceSend = "insert into ConferenceSend values('" + conferenceID + "', '" + katılımcıID + "', '" + 0 + "')";
                    con.ConUpdate(ConferenceSend);
                    numberofchecked++;
                }
            }


            for (int i = 0; i < countGM; i++)
            {
                var cb = Panel7.FindControl("cbKonferansGM" + i) as CheckBox;
                if (cb.Checked == true)
                {
                    katılımcı += employeeNameGM[i].ToString() + ", ";
                    int katılımcıID = Convert.ToInt32(employeeIDGM[i].ToString());
                    string ConferenceSend = "insert into ConferenceSend values('" + conferenceID + "', '" + katılımcıID + "', '" + 0 + "')";
                    con.ConUpdate(ConferenceSend);
                    numberofchecked++;
                }
            }
            string ConferenceSendto = "insert into ConferenceSend values('" + conferenceID + "', '" + id + "', '" + 0 + "')";
            con.ConUpdate(ConferenceSendto);
            string selectSession = "select * from EmployeeInfoTable where EmployeeID ='" + id + "' ";
            con.ConLogin(selectSession);
            string requestName = con.getEmployeeName();
            katılımcı += requestName;
            string updateConference = "update Conference set ConferenceRequest='" + requestName + "' , ConferenceSend='" + katılımcı + "' where ConferenceID = '" + conferenceID + "' ";
            con.ConUpdate(updateConference);
            if (numberofchecked > 0)
            {
                Session["RoomID"] = conferenceID;
                Session["Name"] = requestName;
                GenerateToken generatetoken = new GenerateToken();
                string tokenID = GenerateToken.getToken(id);
                Session["Token"] = tokenID;
                Response.Redirect("Konferans.aspx");
            }
            else
            {
                LabelChoose.Visible = true;
                LabelChoose.Text = "En az bir kişi seçin!";
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Office.aspx");
        }
    }
}