using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;

namespace HESCompany
{
    public partial class LeaveRequestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Session["EmployeeID"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }


            if(!IsPostBack)
            {
                DataBagla("");
            }


            Panel2.Visible = false;
            LabelHata1.Visible = false;
            LabelEmptyID.Visible = false;


        }



        public void DataBagla(string ValueToSearch)
        {
            string id = Session["EmployeeID"].ToString();
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            string query = "Select RequestID, LeaveRequestTable.EmployeeID, EmployeeName, EmployeeDepartment, EmployeeMail, ExecutiveName, ExecutiveMail, RequestType, RequestReason, RequestBegin, RequestEnd, ApprovalStatus FROM EmployeeInfoTable, ExecutiveInfoTable, LeaveRequestTable WHERE  EmployeeInfoTable.EmployeeID ='" + id + "' and  EmployeeInfoTable.ExecutiveID = ExecutiveInfoTable.ExecutiveID and  EmployeeInfoTable.EmployeeID = LeaveRequestTable.EmployeeID and ( RequestID like '%" + ValueToSearch + "%'  OR LeaveRequestTable.EmployeeID like '%" + ValueToSearch + "%' OR  EmployeeName like '%" + ValueToSearch + "%' OR EmployeeDepartment like '%" + ValueToSearch + "%' OR EmployeeMail like '%" + ValueToSearch + "%'  OR ExecutiveName like '%" + ValueToSearch + "%'  OR ExecutiveMail like '%" + ValueToSearch + "%'  OR RequestType like '%" + ValueToSearch + "%' OR RequestReason like '%" + ValueToSearch + "%' OR RequestBegin like '%" + ValueToSearch + "%' OR RequestEnd like '%" + ValueToSearch + "%' OR ApprovalStatus like '%" + ValueToSearch + "%'  )";
            adp = new SqlDataAdapter(query, cnn);
            adp.Fill(dt);
            GridViewLRF.DataSource = dt;
            GridViewLRF.DataBind();
            cnn.Close();
        }


        protected void TextBoxLRFID_TextChanged(object sender, EventArgs e)
        {

            string id = Session["EmployeeID"].ToString();
            string normalizedID = Regex.Replace(id, @"\s", "");
            if (TextBoxLRFID.Text.Trim().Equals(normalizedID))
            {
                Connection con = new Connection();
                string query = "select * from EmployeeInfoTable where EmployeeID = '" + TextBoxLRFID.Text.Trim() + "'";
                con.ConLogin(query);
                con.ExecutiveInfo(TextBoxLRFID.Text.Trim());
                TextBoxLRFName.Text = con.getEmployeeName();
                TextBoxLRFDepatment.Text = con.getEmployeeDepartment();
                TextBoxLRFMail.Text = con.getEmployeeMail();
                TextBoxLRFExecutive.Text = con.getExecutiveName();
            }
            else
            {
                LabelEmptyID.Visible = true;
                LabelEmptyID.Text = "Sadece size ait sicil numaranızla izin formu doldurabilirsiniz!";
            }


        }


        protected void CheckBoxLRF1_CheckedChanged(object sender, EventArgs e)
        {



            if (CheckBoxLRF1.Checked)

            {

                if (TextBoxLRFID.Text == string.Empty)
                {
                    CheckBoxLRF1.Checked = false;
                    LabelEmptyID.Visible = true;
                    LabelEmptyID.Text = "Sicil Numaranızı Giriniz!";

                }
                else
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    LabelReasonAns.Text = CheckBoxLRF1.Text;
                }

            }
        }

        protected void CheckBoxLRF2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxLRF2.Checked)

            {
                if (TextBoxLRFID.Text == string.Empty)
                {
                    CheckBoxLRF2.Checked = false;
                    LabelEmptyID.Visible = true;
                    LabelEmptyID.Text = "Sicil Numaranızı Giriniz!";

                }
                else
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    LabelReasonAns.Text = CheckBoxLRF2.Text;
                }
            }

        }

        protected void CheckBoxLRF3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxLRF3.Checked)

            {
                if (TextBoxLRFID.Text == string.Empty)
                {
                    CheckBoxLRF3.Checked = false;
                    LabelEmptyID.Visible = true;
                    LabelEmptyID.Text = "Sicil Numaranızı Giriniz!";

                }
                else
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    LabelReasonAns.Text = CheckBoxLRF3.Text;
                }

            }
        }

        protected void CheckBoxLRF4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxLRF4.Checked)

            {
                if (TextBoxLRFID.Text == string.Empty)
                {
                    CheckBoxLRF4.Checked = false;
                    LabelEmptyID.Visible = true;
                    LabelEmptyID.Text = "Sicil Numaranızı Giriniz!";

                }
                else
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    LabelReasonAns.Text = CheckBoxLRF4.Text;
                }

            }
        }


        protected void CheckBoxLRF5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxLRF5.Checked)

            {
                if (TextBoxLRFID.Text == string.Empty)
                {
                    CheckBoxLRF5.Checked = false;
                    LabelEmptyID.Visible = true;
                    LabelEmptyID.Text = "Sicil Numaranızı Giriniz!";

                }
                else
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    LabelReasonAns.Text = CheckBoxLRF5.Text;
                }

            }
        }



        protected void CheckBoxLRF6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxLRF6.Checked)

            {
                if (TextBoxLRFID.Text == string.Empty)
                {
                    CheckBoxLRF6.Checked = false;
                    LabelEmptyID.Visible = true;
                    LabelEmptyID.Text = "Sicil Numaranızı Giriniz!";

                }
                else
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    LabelReasonAns.Text = CheckBoxLRF6.Text;
                }

            }
        }




        protected void ButtonLRFSave1_Click(object sender, EventArgs e)
        {
            if (TextBoxLRFSebep1.Text.Trim() != string.Empty && TextBoxLRFTarih1.Text.Trim() != string.Empty && TextBoxLRFTarih1Till.Text.Trim() != string.Empty)
            {


                Panel1.Visible = true;
                Panel2.Visible = false;
                Connection con = new Connection();
                string status = "Bekliyor";
                string query = "insert into LeaveRequestTable values('" + TextBoxLRFID.Text.Trim() + "', '" + CheckBoxLRF1.Text + "',  '" + TextBoxLRFSebep1.Text.Trim() + "', '" + TextBoxLRFTarih1.Text.Trim() + "', '" + TextBoxLRFTarih1Till.Text.Trim() + "', '" + status + "')";
                con.ConUpdate(query);
                Response.Redirect("LeaveRequestForm.aspx");
                
            }
            else
            {

                Panel1.Visible = false;
                Panel2.Visible = true;
                LabelHata1.Visible = true;
                LabelHata1.Text = "Bütün alanları doldurunuz!";
            }
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
            string updateEnter = "update PersonelDateInfo set ExitPersonel = '" + hourMinute + "' where EmployeeID = '" + Session["EmployeeID"] + "' and DatePersonel = '" + date + "' ";
            con.ConUpdate(updateEnter);
            
                string query = "update EmployeeInfoTable set Status = '" + 0 + "' where EmployeeID = '" + Session["EmployeeID"] + "'";
                con.ConUpdate(query);
                Session.Remove("EmployeeID");
                Response.Redirect("LoginPage.aspx");
            
            
        }

        protected void GridViewLRF_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewLRF.EditIndex = e.NewEditIndex;
        }

        protected void GridViewLRF_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox TBRType = (TextBox)GridViewLRF.Rows[e.RowIndex].FindControl("TextBoxRequestType");
            TextBox TBRReason = (TextBox)GridViewLRF.Rows[e.RowIndex].FindControl("TextBoxRequestReason");
            TextBox TBRBegin = (TextBox)GridViewLRF.Rows[e.RowIndex].FindControl("TextBoxRequestBegin");
            TextBox TBREnd = (TextBox)GridViewLRF.Rows[e.RowIndex].FindControl("TextBoxRequestEnd");
            Label LRequestID = (Label)GridViewLRF.Rows[e.RowIndex].FindControl("LabelRequestID");


            bool sonuc = Guncelle(TBRType.Text, TBRReason.Text , TBRBegin.Text , TBREnd.Text, LRequestID.Text);
            if (sonuc)
            {
                GridViewLRF.EditIndex = -1;
                DataBagla("");
            }
        }

        private bool Guncelle(string Type, string Reason, string Begin, string End, string RID)
        {
            bool sonuc = false;
            Connection con = new Connection();
            string queryApproval = "Update LeaveRequestTable SET RequestType= '" + Type + "', RequestReason= '" + Reason + "', RequestBegin= '" + Begin + "', RequestEnd= '" + End + "' where RequestID = '"+ RID + "'";
            sonuc = con.ConUpdate(queryApproval);
            return sonuc;
        }


        protected void GridViewLRF_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewLRF.EditIndex = -1;
            DataBagla("");
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
            string queryApproval = "Delete From LeaveRequestTable Where RequestID = '" + requestID + "' ";
            sonuc = con.ConUpdate(queryApproval);
            return sonuc;
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string ValueToSearch = TextBoxSearch.Text.Trim();
            DataBagla(ValueToSearch);
        }

        protected void ButtonLRFCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeaveRequestForm.aspx");
        }
    }
}