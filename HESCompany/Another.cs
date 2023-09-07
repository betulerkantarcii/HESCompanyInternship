using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace HESCompany
{
   
    public class Another
    {
        ArrayList employeeNameIK = new ArrayList();
        ArrayList employeeStatusIK = new ArrayList();
        ArrayList employeeIDIK = new ArrayList();

        ArrayList employeeNameM = new ArrayList();
        ArrayList employeeStatusM = new ArrayList();
        ArrayList employeeIDM = new ArrayList();

        ArrayList employeeNameP = new ArrayList();
        ArrayList employeeStatusP = new ArrayList();
        ArrayList employeeIDP = new ArrayList();

        ArrayList employeeNameYI = new ArrayList();
        ArrayList employeeStatusYI = new ArrayList();
        ArrayList employeeIDYI = new ArrayList();

        ArrayList employeeNameYD = new ArrayList();
        ArrayList employeeStatusYD = new ArrayList();
        ArrayList employeeIDYD = new ArrayList();

        ArrayList employeeNameBI = new ArrayList();
        ArrayList employeeStatusBI = new ArrayList();
        ArrayList employeeIDBI = new ArrayList();

        ArrayList employeeNameGM = new ArrayList();
        ArrayList employeeStatusGM = new ArrayList();
        ArrayList employeeIDGM = new ArrayList();



        public ArrayList ListofEmployeeIDIK()
        {
            return this.employeeIDIK;

        }

        public ArrayList ListofEmployeeNameIK()
        {
            return this.employeeNameIK;

        }

        public ArrayList ListofEmployeeStatusIK()
        {
            return this.employeeStatusIK;
        }





        public ArrayList ListofEmployeeIDM()
        {
            return this.employeeIDM;

        }

        public ArrayList ListofEmployeeNameM()
        {
            return this.employeeNameM;

        }

        public ArrayList ListofEmployeeStatusM()
        {
            return this.employeeStatusM;
        }




        public ArrayList ListofEmployeeIDP()
        {
            return this.employeeIDP;

        }

        public ArrayList ListofEmployeeNameP()
        {
            return this.employeeNameP;

        }

        public ArrayList ListofEmployeeStatusP()
        {
            return this.employeeStatusP;
        }





        public ArrayList ListofEmployeeIDYI()
        {
            return this.employeeIDYI;

        }

        public ArrayList ListofEmployeeNameYI()
        {
            return this.employeeNameYI;

        }

        public ArrayList ListofEmployeeStatusYI()
        {
            return this.employeeStatusYI;
        }



        public ArrayList ListofEmployeeIDYD()
        {
            return this.employeeIDYD;

        }

        public ArrayList ListofEmployeeNameYD()
        {
            return this.employeeNameYD;

        }

        public ArrayList ListofEmployeeStatusYD()
        {
            return this.employeeStatusYD;
        }





        public ArrayList ListofEmployeeIDBI()
        {
            return this.employeeIDBI;

        }

        public ArrayList ListofEmployeeNameBI()
        {
            return this.employeeNameBI;

        }

        public ArrayList ListofEmployeeStatusBI()
        {
            return this.employeeStatusBI;
        }






        public ArrayList ListofEmployeeIDGM()
        {
            return this.employeeIDGM;

        }

        public ArrayList ListofEmployeeNameGM()
        {
            return this.employeeNameGM;

        }

        public ArrayList ListofEmployeeStatusGM()
        {
            return this.employeeStatusGM;
        }




        public void getCountAnother(string query, int id)
        {

            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();

            if (id == 1)
            {
                this.employeeNameIK.Clear();
                this.employeeStatusIK.Clear();
                this.employeeIDIK.Clear();

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        this.employeeIDIK.Add(row["EmployeeID"].ToString());
                        this.employeeNameIK.Add(row["EmployeeName"].ToString());
                        this.employeeStatusIK.Add(row["Status"].ToString());


                    }
                    sqlCon.Close();
                }
            }

            else if (id == 2)
            {
                this.employeeNameM.Clear();
                this.employeeStatusM.Clear();
                this.employeeIDM.Clear();

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        this.employeeIDM.Add(row["EmployeeID"].ToString());
                        this.employeeNameM.Add(row["EmployeeName"].ToString());
                        this.employeeStatusM.Add(row["Status"].ToString());


                    }
                    sqlCon.Close();
                }
            }

            else if (id == 3)
            {
                this.employeeNameP.Clear();
                this.employeeStatusP.Clear();
                this.employeeIDP.Clear();

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        this.employeeIDP.Add(row["EmployeeID"].ToString());
                        this.employeeNameP.Add(row["EmployeeName"].ToString());
                        this.employeeStatusP.Add(row["Status"].ToString());


                    }
                    sqlCon.Close();
                }
            }

            else if (id == 4)
            {
                this.employeeNameYI.Clear();
                this.employeeStatusYI.Clear();
                this.employeeIDYI.Clear();

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        this.employeeIDYI.Add(row["EmployeeID"].ToString());
                        this.employeeNameYI.Add(row["EmployeeName"].ToString());
                        this.employeeStatusYI.Add(row["Status"].ToString());


                    }
                    sqlCon.Close();
                }
            }

            else if (id == 5)
            {
                this.employeeNameYD.Clear();
                this.employeeStatusYD.Clear();
                this.employeeIDYD.Clear();

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        this.employeeIDYD.Add(row["EmployeeID"].ToString());
                        this.employeeNameYD.Add(row["EmployeeName"].ToString());
                        this.employeeStatusYD.Add(row["Status"].ToString());


                    }
                    sqlCon.Close();
                }
            }

            else if (id == 6)
            {
                this.employeeNameBI.Clear();
                this.employeeStatusBI.Clear();
                this.employeeIDBI.Clear();

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        this.employeeIDBI.Add(row["EmployeeID"].ToString());
                        this.employeeNameBI.Add(row["EmployeeName"].ToString());
                        this.employeeStatusBI.Add(row["Status"].ToString());


                    }
                    sqlCon.Close();
                }
            }

            else if (id == 7)
            {
                this.employeeNameGM.Clear();
                this.employeeStatusGM.Clear();
                this.employeeIDGM.Clear();

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        this.employeeIDGM.Add(row["EmployeeID"].ToString());
                        this.employeeNameGM.Add(row["EmployeeName"].ToString());
                        this.employeeStatusGM.Add(row["Status"].ToString());


                    }
                    sqlCon.Close();
                }
            }

        }





        }


    

    



}