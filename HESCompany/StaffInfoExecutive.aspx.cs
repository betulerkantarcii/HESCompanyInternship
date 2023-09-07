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
    public partial class StaffInfoExecutive : System.Web.UI.Page
    {
        static string id = "";
        static string year = "";
        static string month = "";
        static string employeeID = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ExecutiveID"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                id = Session["ExecutiveID"].ToString();
            }


            PanelTakvim.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;

            if (!IsPostBack)
            {
                DataBagla();

            }

        }





        private void DataBagla()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            DateTime dateAndTime = DateTime.Now;
            string date = dateAndTime.ToString("yyyy/MM/dd");
            string query = "Select EmployeeDepartment, EmployeeInfoTable.EmployeeID, EmployeeName, EmployeeMail, ExecutiveName, ExecutiveMail, EnterPersonel, ExitPersonel FROM EmployeeInfoTable, ExecutiveInfoTable, PersonelDateInfo WHERE EmployeeInfoTable.ExecutiveID = '"+ id +"' and EmployeeInfoTable.ExecutiveID = ExecutiveInfoTable.ExecutiveID and EmployeeInfoTable.EmployeeID = PersonelDateInfo.EmployeeID and DatePersonel = '" + date + "'; ";
            adp = new SqlDataAdapter(query, cnn);
            adp.Fill(dt);
            GridViewStaffInfo.DataSource = dt;
            GridViewStaffInfo.DataBind();
            cnn.Close();
        }



        protected void ButtonHomePage1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void ButtonExitPersonelInfo_Click(object sender, EventArgs e)
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

    protected void Button2020_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        PanelTakvim.Visible = false;
        Panel2.Visible = true;
        LabelYear.Text = "2020";
        year = "2020";
    }

    protected void Button2021_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        PanelTakvim.Visible = false;
        Panel2.Visible = true;
        LabelYear.Text = "2021";
        year = "2021";
    }

    protected void Button2022_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        PanelTakvim.Visible = false;
        Panel2.Visible = true;
        LabelYear.Text = "2022";
        year = "2022";
    }

    protected void Button1Ocak_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "1";
        LabelYearMonth.Text = year + "   OCAK";
        DataBaglaDate();
    }

    protected void Button1Subat_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "2";
        LabelYearMonth.Text = year + "    ŞUBAT";
        DataBaglaDate();
    }

    protected void Button1Mart_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "3";
        LabelYearMonth.Text = year + "    MART";
        DataBaglaDate();
    }

    protected void Button1Nisan_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "4";
        LabelYearMonth.Text = year + "    NİSAN";
        DataBaglaDate();
    }

    protected void Button1Mayıs_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "5";
        LabelYearMonth.Text = year + "    MAYIS";
        DataBaglaDate();
    }

    protected void Button1Haziran_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "6";
        LabelYearMonth.Text = year + "    HAZİRAN";
        DataBaglaDate();
    }

    protected void Button1Temmuz_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "7";
        LabelYearMonth.Text = year + "    TEMMUZ";
        DataBaglaDate();
    }

    protected void Button1Agustos_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "8";
        LabelYearMonth.Text = year + "    AĞUSTOS";
        DataBaglaDate();
    }

    protected void Button1Eylül_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "9";
        LabelYearMonth.Text = year + "    EYLÜL";
        DataBaglaDate();
    }

    protected void Button1Ekim_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "10";
        LabelYearMonth.Text = year + "    EKİM";
        DataBaglaDate();
    }

    protected void Button1Kasım_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "11";
        LabelYearMonth.Text = year + "    KASIM";
        DataBaglaDate();
    }

    protected void Button1Aralık_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
            PanelTakvim.Visible = false;
            Panel2.Visible = false;
        Panel3.Visible = true;
        month = "12";
        LabelYearMonth.Text = year + "    ARALIK";
        DataBaglaDate();
    }

    private void DataBaglaDate()
    {
        Connection con = new Connection();
        DataTable dt = new DataTable();
        dt = con.dataFillDate(year, month, employeeID);
        GridViewDate.DataSource = dt;
        GridViewDate.DataBind();
    }

    protected void ButtonGeriMonth_Click(object sender, EventArgs e)
    {
        Panel3.Visible = false;
        Panel1.Visible = false;
        Panel2.Visible = true;
    }

    protected void ButtonGeriYear_Click(object sender, EventArgs e)
    {
        PanelTakvim.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
    }

        protected void GridViewStaffInfo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridViewStaffInfo.Rows[index];
            Label LID= (Label)row.FindControl("Label2");
            Label LName = (Label)row.FindControl("LabelEmployeeName");
            employeeID = LID.Text;
            Panel1.Visible = false;
            PanelTakvim.Visible = true;
            Label3.Text = LName.Text;
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffInfoExecutive.aspx");
        }
    }
}