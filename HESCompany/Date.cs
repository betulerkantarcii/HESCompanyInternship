using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace HESCompany
{
    public class Date
    {


        string EnterPersonel = "";



        public string returnDate(string query)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    this.EnterPersonel = row["EnterPersonel"].ToString();
                }
                sqlCon.Close();
                

            }

            return this.EnterPersonel;

        }



    }
}