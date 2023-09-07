using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.Web.Caching;

namespace HESCompany
{
    public partial class home : System.Web.UI.Page
    {

        static string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["EmployeeID"] == null && Session["ExecutiveID"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }


            if (Session["EmployeeID"] != null)
            {
                LabelIsim.Text = Session["EmployeeName"].ToString();
            }
            else
            {
                LabelIsim.Text = Session["ExecutiveName"].ToString();
            }

            Panel2.Visible = false;

            
            if (Session["EmployeeID"] != null)
            {
                id = Session["EmployeeID"].ToString();
            }
            else
            {
                id = Session["ExecutiveID"].ToString();
            }
            

            if (!IsPostBack)
            {
                DataBagla("");
                DataBaglaChecked("");

            }
          

        }



        public void DataBagla(string ValueToSearch)
        {
            
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            string query = "Select  NoteID, Note, DateofNote From EmployeeNote WHERE  EmployeeID ='" + id + "' and ( Note like '%" + ValueToSearch + "%'  OR DateofNote like '%" + ValueToSearch + "%' )";
            adp = new SqlDataAdapter(query, cnn);
            adp.Fill(dt);
            GridViewNote.DataSource = dt;
            GridViewNote.DataBind();
            cnn.Close();
        }



        protected void GridViewNote_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewNote.EditIndex = e.NewEditIndex;
        }

        protected void GridViewNote_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox TBNote = (TextBox)GridViewNote.Rows[e.RowIndex].FindControl("TextBoxNote");
            TextBox TBTarih = (TextBox)GridViewNote.Rows[e.RowIndex].FindControl("TextBoxTarih");
            Label LNoteID = (Label)GridViewNote.Rows[e.RowIndex].FindControl("LabelNoteID");


            bool sonuc = Guncelle(TBNote.Text, TBTarih.Text,  LNoteID.Text);
            if (sonuc)
            {
                GridViewNote.EditIndex = -1;
                DataBagla("");
            }
        }

        private bool Guncelle(string Note, string Tarih, string ID)
        {
            bool sonuc = false;
            Connection con = new Connection();
            string queryApproval = "Update EmployeeNote SET Note= '" + Note + "', DateofNote= '" +  Tarih + "' where NoteID = '" + ID + "'";
            sonuc = con.ConUpdate(queryApproval);
            return sonuc;
        }


        protected void GridViewNote_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewNote.EditIndex = -1;
            DataBagla("");
        }

        


        protected void CheckBoxNote_Checked(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridViewNote.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("CheckBoxNote");
                if ( cb.Checked)
                {
                    int NoteID = Convert.ToInt32(GridViewNote.DataKeys[row.RowIndex].Value);
                    Connection con = new Connection();
                    string querySelect = "Select * from EmployeeNote where NoteID = '" + NoteID + "' ";
                    ArrayList note  = con.getEmployeeNote(querySelect);
                    string queryInsert = "Insert into EmployeeCompletedTask values('" +note[0]+"',  '"+ note[1] +"', '"+note[2] + "', '" + note[3] + "'   )";
                    con.ConUpdate(queryInsert);
                    string queryApproval = "Delete From EmployeeNote Where NoteID = '" + NoteID + "' ";
                    if (con.ConUpdate(queryApproval))
                    {
                        DataBagla("");
                        DataBaglaChecked("");
                    }


                }
            }

           

        }


        public void DataBaglaChecked(string ValueToSearch)
        {
            
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            string query = "Select  NoteID, Note, DateofNote From EmployeeCompletedTask WHERE  EmployeeID ='" + id + "' and ( Note like '%" + ValueToSearch + "%'  OR DateofNote like '%" + ValueToSearch + "%' )";
            adp = new SqlDataAdapter(query, cnn);
            adp.Fill(dt);
            GridViewCheckedNote.DataSource = dt;
            GridViewCheckedNote.DataBind();
            cnn.Close();
        }


        protected void GridViewCheckedNote_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ButtonGridGeriEkle")
            {

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridViewCheckedNote.Rows[index];
                Label LNoteID = (Label)row.FindControl("LabelCheckedNoteID");
                Connection con = new Connection();
                string querySelect = "Select * from EmployeeCompletedTask where NoteID = '" + LNoteID.Text + "' ";
                ArrayList note = con.getEmployeeNote(querySelect);
                string queryInsert = "Insert into EmployeeNote values('" + note[1] + "', '" + note[2] + "', '" + note[3] + "'   )";
                con.ConUpdate(queryInsert);
                string queryApproval = "Delete From EmployeeCompletedTask Where NoteID = '" + LNoteID.Text + "' ";
                if (con.ConUpdate(queryApproval))
                {
                    DataBagla("");
                    DataBaglaChecked("");
                }
            }
        }


        protected void GridViewCheckedNote_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int NoteId = Convert.ToInt32(GridViewCheckedNote.DataKeys[e.RowIndex].Value);
            bool sonuc = DeleteNote(NoteId);
            if (sonuc)
            {
                DataBaglaChecked("");
            }
        }

        private bool DeleteNote(int NoteID)
        {
            bool sonuc = false;
            Connection con = new Connection();
            string queryApproval = "Delete From EmployeeCompletedTask Where NoteID = '" + NoteID + "' ";
            sonuc = con.ConUpdate(queryApproval);
            return sonuc;
        }


        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string ValueToSearch = TextBoxSearch.Text.Trim();
            DataBagla(ValueToSearch);
        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            string ValueToSearch = TextBox1.Text.Trim();
            DataBaglaChecked(ValueToSearch);
        }


        protected void LinkButtonCikis_Click(object sender, EventArgs e)
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

        protected void LinkButtonHomeKullanici_Click(object sender, EventArgs e)
        { 
            Response.Redirect("ChangePassword.aspx");
        }

        protected void ButtonPersonelKayit_Click(object sender, EventArgs e)
        {

            if (Session["EmployeeID"] != null)
            {
                Response.Redirect("StaffInfo.aspx");
            }
            else
            {
                Response.Redirect("StaffInfoExecutive.aspx");
            }
        }

        protected void ButtonKartOkutma_Click(object sender, EventArgs e)
        {

            if (Session["EmployeeID"] != null)
            {
                Response.Redirect("ForgetCardPage.aspx");
            }
            else
            {
                Response.Redirect("ForgetCardPageExecutive.aspx");
            }
        }

        protected void ButtonİzinBelgesi_Click(object sender, EventArgs e)
        {

            if (Session["EmployeeID"] != null)
            {
                Response.Redirect("LeaveRequestForm.aspx");
            }
            else
            {
                Response.Redirect("LeaveRequestFormExecutive.aspx");
            }
        }


        protected void ButtonEkle_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel3.Visible = false;
            Panel2.Visible = true;
        }

        protected void ButtonKaydet_Click(object sender, EventArgs e)
        {
            string note = TextBoxNote.Text.Trim();
            string dt = DateTime.UtcNow.ToString("yyyy-MM-dd");

            
            string query = "insert into EmployeeNote values ( '" + id +"', '" + note +"', '" + dt+"')";
            Connection con = new Connection();
            con.ConUpdate(query);
            Response.Redirect("HomePage.aspx");
            
        }

        protected void ButtonOfis_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
           
            string sql = "Update EmployeeInfoTable set Status= '" + "Online" +"' where EmployeeID = '"+ id+"'";
            con.ConUpdate(sql);
            Response.Redirect("Office.aspx");

        }

        protected void ButtonVazgeç_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}