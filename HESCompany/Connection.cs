using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace HESCompany
{
    public class Connection
    {


        string ID;
        string ExecutiveID;
        string EmployeeDepartment;
        string ExecutiveName;
        string EmployeeName;
        string DateOf;
        string EmployeeMail;
        string RoomEmployeeID;
        string RoomEmployeeName;
        string RoomMessageHead;
        string RoomParticipants;
        string ConferenceEmployeeID;
        ArrayList EmployeeIDList = new ArrayList();
        ArrayList EmployeeNameList = new ArrayList();
        ArrayList EmployeeStatusList = new ArrayList();
        ArrayList EmployeeIDMessage = new ArrayList();
        ArrayList Message = new ArrayList();
        ArrayList EmployeeNameMessage = new ArrayList();




        public ArrayList getEmployeeNameMessage()
        {
            return this.EmployeeNameMessage;

        }

        public ArrayList getEmployeeIDMessage()
        {
            return this.EmployeeIDMessage;

        }

        public ArrayList getArrayListMessage()
        {
            return this.Message;

        }


        public ArrayList getArrayListofEmployeeID()
        {
            return this.EmployeeIDList;

        }

        public ArrayList getArrayListofEmployeeName()
        {
            return this.EmployeeNameList;

        }

        public ArrayList getArrayListofEmployeeStatus()
        {
            return this.EmployeeStatusList;
        }

        public string get()
        {
            return this.ID;
        }

        public string getExecutiveID()
        {
            return this.ExecutiveID;
        }

        public string getExecutiveName()
        {
            return this.ExecutiveName;
        }

        public string getEmployeeDepartment()
        {
            return this.EmployeeDepartment;
        }
        public string getEmployeeName()
        {
            return this.EmployeeName;
        }
        public string getEmployeeMail()
        {
            return this.EmployeeMail;
        }

        public string getDateOf()
        {
            return this.DateOf;
        }

        public string getRoomEmployeeID()
        {
            return this.RoomEmployeeID;
        }

        public string getRoomEmployeeName()
        {
            return this.RoomEmployeeName;
        }

        public string getRoomMessageHead()
        {
            return this.RoomMessageHead;
        }

        public string getRoomParticipants()
        {
            return this.RoomParticipants;
        }

        public string getConferenceEmployeeID()
        {
            return this.ConferenceEmployeeID;
        }


        public bool ConLogin(string query)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    this.ID = row["EmployeeID"].ToString();
                    this.EmployeeName = row["EmployeeName"].ToString();
                    this.EmployeeDepartment = row["EmployeeDepartment"].ToString();
                    this.EmployeeMail = row["EmployeeMail"].ToString();
                    this.ExecutiveID= row["ExecutiveID"].ToString();
                }
                sqlCon.Close();
                return true;


            }
            else
            {
                sqlCon.Close();
                return false;
            }


        }


        public bool ConDate(string query)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    this.DateOf = row["DatePersonel"].ToString();

                }
                sqlCon.Close();
                return true;


            }
            else
            {
                sqlCon.Close();
                return false;
            }


        }



        public bool ConUpdate(string query)
        {

            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            try
            {
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }


        public void getMessage(string query)
        {

            this.Message.Clear();
            this.EmployeeIDMessage.Clear();
            this.EmployeeNameMessage.Clear();

            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    this.Message.Add(row["Message"].ToString());
                    this.EmployeeIDMessage.Add(row["EmployeeID"].ToString());
                    this.EmployeeNameMessage.Add(row["EmployeeName"].ToString());

                }

            }
        }
        


        public void getCount(string query)
        {
            this.EmployeeIDList.Clear();
            this.EmployeeNameList.Clear();
            this.EmployeeStatusList.Clear();
            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                { 
                    this.EmployeeIDList.Add(row["EmployeeID"].ToString());
                    this.EmployeeNameList.Add(row["EmployeeName"].ToString());
                    this.EmployeeStatusList.Add(row["Status"].ToString());


                }
                sqlCon.Close();
               


            }

        }


        


        public ArrayList getEmployeeNote(string query)
        {
            ArrayList note = new ArrayList();
            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo; Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {

                    note.Add(row["NoteID"].ToString());
                    note.Add(row["EmployeeID"].ToString());
                    note.Add(row["Note"].ToString());
                    note.Add(row["DateofNote"].ToString());

                }
                sqlCon.Close();
                return note;

            }
            else
            {
                sqlCon.Close();
                return note;

            }
        }
        public ArrayList getPassword(string query)
        {
            ArrayList Passwords = new ArrayList();
            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo; Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {

                    Passwords.Add(row["PasswordIndex"].ToString());
                    Passwords.Add(row["Password1_decrypted"].ToString());
                    Passwords.Add(row["Password2_decrypted"].ToString());
                    Passwords.Add(row["Password3_decrypted"].ToString());
                    Passwords.Add(row["Password4_decrypted"].ToString());
                    Passwords.Add(row["Password5_decrypted"].ToString());

                }
                sqlCon.Close();
                return Passwords;


            }
            else
            {
                sqlCon.Close();
                return Passwords;
            }

        }



        public DataTable dataFillExecutive(int number, string ExeID, string ValueToSearch)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            if (number == 1)
            {
                string query = "Select EmployeeDepartment, EmployeeID, EmployeeName, EmployeeMail, ExecutiveName, ExecutiveMail FROM EmployeeInfoTable, ExecutiveInfoTable WHERE EmployeeInfoTable.EmployeeID != EmployeeInfoTable.ExecutiveID and EmployeeInfoTable.ExecutiveID = '" + ExeID + "'  and EmployeeInfoTable.ExecutiveID = ExecutiveInfoTable.ExecutiveID and (EmployeeDepartment like '%" + ValueToSearch + "%' OR EmployeeID like '%" + ValueToSearch + "%' OR EmployeeName like '%" + ValueToSearch + "%' OR  EmployeeMail like '%" + ValueToSearch + "%'  OR ExecutiveName like '%" + ValueToSearch + "%'  OR ExecutiveMail like '%" + ValueToSearch + "%')";
                adp = new SqlDataAdapter(query, cnn);
            }
            else if (number == 2)
            {
                string query = "Select RequestID, EmployeeInfoTable.EmployeeID, EmployeeName, EmployeeDepartment, EmployeeMail, ExecutiveName, ExecutiveMail, RequestType, RequestReason, RequestBegin, RequestEnd, ApprovalStatus FROM EmployeeInfoTable, ExecutiveInfoTable, LeaveRequestTable WHERE  EmployeeInfoTable.EmployeeID != EmployeeInfoTable.ExecutiveID and EmployeeInfoTable.ExecutiveID = '" + ExeID + "' and EmployeeInfoTable.EmployeeID = LeaveRequestTable.EmployeeID and  EmployeeInfoTable.ExecutiveID = ExecutiveInfoTable.ExecutiveID and ( RequestID like '%" + ValueToSearch + "%'  OR LeaveRequestTable.EmployeeID like '%" + ValueToSearch + "%' OR  EmployeeName like '%" + ValueToSearch + "%' OR EmployeeDepartment like '%" + ValueToSearch + "%' OR EmployeeMail like '%" + ValueToSearch + "%'  OR ExecutiveName like '%" + ValueToSearch + "%'  OR ExecutiveMail like '%" + ValueToSearch + "%'  OR RequestType like '%" + ValueToSearch + "%' OR RequestReason like '%" + ValueToSearch + "%' OR RequestBegin like '%" + ValueToSearch + "%' OR RequestEnd like '%" + ValueToSearch + "%' OR ApprovalStatus like '%" + ValueToSearch + "%'  )";
                adp = new SqlDataAdapter(query, cnn);
            }
            adp.Fill(dt);
            cnn.Close();
            return dt;
        }


        public DataTable dataFillDate(string year, string month, string id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            string query = "select DayPersonel, EnterPersonel, ExitPersonel from PersonelDateInfo where YearPersonel='"+ year+"' and MonthPersonel = '"+ month +"' and EmployeeID = '"+ id +"'";
            adp = new SqlDataAdapter(query, cnn);
            adp.Fill(dt);
            cnn.Close();
            return dt;

        }



        public int returnConferenceID(string query)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            int ConferenceID=0;
            if (row.HasRows)
            {
                while (row.Read())
                {

                    this.ConferenceEmployeeID = row["EmployeeID"].ToString();
                    string ConferenceIDstring = row["ConferenceID"].ToString();
                    ConferenceID = Convert.ToInt32(ConferenceIDstring);
                }
                sqlCon.Close();
                return ConferenceID;


            }
            else
            {
                sqlCon.Close();
                return ConferenceID;
            }

        }

        public int returnConferenceSeen(string query)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            int ConferenceSeen = 0;
            if (row.HasRows)
            {
                while (row.Read())
                {

                    string ConferenceIDstring = row["ConferenceSeen"].ToString();
                    ConferenceSeen = Convert.ToInt32(ConferenceIDstring);
                }
                sqlCon.Close();
                return ConferenceSeen;


            }
            else
            {
                sqlCon.Close();
                return ConferenceSeen;
            }

        }


        public int returnRoomID(string query)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader row = cmd.ExecuteReader();
            int RoomID = 0;
            if (row.HasRows)
            {
                while (row.Read())
                {
                    string RoomIDstring = row["RoomID"].ToString();
                    this.RoomEmployeeID = row["EmployeeID"].ToString();
                    this.RoomEmployeeName = row["EmployeeName"].ToString();
                    this.RoomMessageHead = row["MessageHead"].ToString();
                    this.RoomParticipants = row["Participants"].ToString();
                    RoomID = Convert.ToInt32(RoomIDstring);
                }
                sqlCon.Close();
                return RoomID;


            }
            else
            {
                sqlCon.Close();
                return RoomID;
            }

        }

        public bool ExecutiveInfo(string id)
        {
            bool sonuc=false;
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            string queryExecutiveID = "Select * from ExecutiveInfoTable, EmployeeInfoTable where EmployeeID= '" + id + "' and EmployeeInfoTable.ExecutiveID = ExecutiveInfoTable.ExecutiveID";
            SqlCommand cmd = new SqlCommand(queryExecutiveID, cnn);
            SqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    this.ExecutiveID = row["ExecutiveID"].ToString();
                    this.EmployeeDepartment = row["EmployeeDepartment"].ToString();
                    this.ExecutiveName = row["ExecutiveName"].ToString();

                }
                cnn.Close();
                sonuc = true;
            }
            return sonuc;
        }

        public int getLastMessageID(string query)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-AJB4S93\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True;");
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader row = cmd.ExecuteReader();
            int MessageID=0;
            if (row.HasRows)
            {
                while (row.Read())
                {
                    string Message = row["MessageID"].ToString();
                    MessageID = Convert.ToInt32(Message);
                }
                cnn.Close();
            }
            return MessageID;
        }


    }
}