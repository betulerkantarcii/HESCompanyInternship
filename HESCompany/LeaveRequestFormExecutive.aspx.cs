using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace HESCompany
{
    public partial class LeaveRequestFormExecutive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ExecutiveID"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }


            if (!IsPostBack)
            {
                DataBagla("");
            }

        }


        public void DataBagla(string ValueToSearch)
        {

            string ExeID =  Session["ExecutiveID"].ToString();
            Connection con = new Connection();
            DataTable dt = con.dataFillExecutive(2, ExeID, ValueToSearch);
            GridViewLRF.DataSource = dt;
            GridViewLRF.DataBind();
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
            string updateEnter = "update PersonelDateInfo set ExitPersonel = '" + hourMinute + "' where EmployeeID = '" + Session["ExecutiveID"] + "' and DatePersonel = '" + date + "' ";
            con.ConUpdate(updateEnter);
                string query = "update EmployeeInfoTable set Status = '" + 0 + "' where EmployeeID = '" + Session["ExecutiveID"] + "'";
                con.ConUpdate(query);
                Session.Remove("ExecutiveID");
                Response.Redirect("LoginPage.aspx");
            
        }

        protected void GridViewLRF_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int requestId = Convert.ToInt32(GridViewLRF.DataKeys[e.RowIndex].Value);
            bool sonuc = DeleteRequest(requestId);
            if (sonuc)
            {
                DataBagla("");
            }
        }

        private bool DeleteRequest(int requestID)
        {
            bool sonuc = false;
            Connection con = new Connection();
            string queryApproval = "Delete From LeaveRequestTable Where RequestID = '"+ requestID +"' ";
            sonuc = con.ConUpdate(queryApproval);
            return sonuc;
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string ValueToSearch = TextBoxSearch.Text.Trim();
            DataBagla(ValueToSearch);
        }

        protected void GridViewLRF_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ButtonGridOnayla")
            {
             
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridViewLRF.Rows[index];
                Label LRequestID = (Label) row.FindControl("LabelRequestID");
                Connection con = new Connection();
                string onay = "Onaylandı";
                string query = "Update LeaveRequestTable SET ApprovalStatus= '" + onay + "' where RequestID='" + LRequestID.Text + "' ";
                if (con.ConUpdate(query))
                {
                    DataBagla("");
                }
            }
            else if(e.CommandName == "ButtonGridReddet")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridViewLRF.Rows[index];
                Label LRequestID = (Label)row.FindControl("LabelRequestID");
                Connection con = new Connection();
                string onay = "Reddedildi";
                string query = "Update LeaveRequestTable SET ApprovalStatus= '" + onay + "' where RequestID='" + LRequestID.Text + "' ";
                if (con.ConUpdate(query))
                {
                    DataBagla("");
                }
            }

        }
    }
}