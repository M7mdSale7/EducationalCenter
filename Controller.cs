using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EducationalCenter
{
    public class Controller
    {

        DBManager dbMan;
        private static Controller _instance;
        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Controller();
                return _instance;
            }
        }
        private Controller()
        {
            dbMan = new DBManager();
        }

        private bool insertUser(string username, string password, string usertype) //uses sp query
        {
            if (checkUser(username))
                return false;

            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Value = username,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterPass = new SqlParameter
            {
                ParameterName = "@password",
                SqlDbType = SqlDbType.VarChar,
                Value = password,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterType = new SqlParameter
            {
                ParameterName = "@usertype",
                SqlDbType = SqlDbType.VarChar,
                Value = usertype,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);
            parameters.Add(parameterPass);
            parameters.Add(parameterType);

            return Convert.ToBoolean(dbMan.ExecuteScalar("insertUser", "sp", parameters));
        }
        public bool checkUser(string username)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Value = username,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);

            return Convert.ToBoolean(dbMan.ExecuteScalar("checkUser", "sp", parameters));
        }

        public string checkUserPassword(string username, string password)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Value = username,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterPass = new SqlParameter
            {
                ParameterName = "@password",
                SqlDbType = SqlDbType.VarChar,
                Value = password,
                Direction = ParameterDirection.Input
            };

            parameters.Add(parameterUser);
            parameters.Add(parameterPass);

            
            return Convert.ToString(dbMan.ExecuteScalar("checkUserPassword", "sp", parameters));
        }
        public bool changePassword(string username, string oldPass, string newPass)
        {
            if (checkUserPassword(username, oldPass) == "")
                return false;

            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Value = username,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterPass = new SqlParameter
            {
                ParameterName = "@password",
                SqlDbType = SqlDbType.VarChar,
                Value = newPass,
                Direction = ParameterDirection.Input
            };

            parameters.Add(parameterUser);
            parameters.Add(parameterPass);


            dbMan.ExecuteNonQuery("changePassword", "sp", parameters);
            return true;
        }

        public DataTable getAllAccounts(string username, string password, string usertype)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if(username != "")
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@username",
                    SqlDbType = SqlDbType.VarChar,
                    Value = username,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }

            if (password != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@password",
                    SqlDbType = SqlDbType.VarChar,
                    Value = password,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }

            if (usertype != "")
            {
                SqlParameter parameterType = new SqlParameter
                {
                    ParameterName = "@usertype",
                    SqlDbType = SqlDbType.VarChar,
                    Value = usertype,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterType);
            }

            return dbMan.ExecuteReader("GetAllUsers", "sp", parameters);
        }
        public string[] getNonUserEmployees()
        {
            DataTable data = dbMan.ExecuteReader("getNonUserEmployees", "sp");
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public string[] getNonUserTeachers()
        {
            DataTable data = dbMan.ExecuteReader("getNonUserTeachers", "sp");
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public string[] getNonUserStudents()
        {
            DataTable data = dbMan.ExecuteReader("getNonUserStudents", "sp");
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public string[] getNonUserTAs()
        {
            DataTable data = dbMan.ExecuteReader("getNonUserTAs", "sp");
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }

        public void insertEmployeUser(string nationalId, string username, string password)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Value = username,
                Direction = ParameterDirection.Input
            };
            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@national_id",
                SqlDbType = SqlDbType.VarChar,
                Value = nationalId,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);
            parameters.Add(parameterID);
            dbMan.ExecuteNonQuery("udpateEmployeeUser", "sp", parameters);
            insertUser(username, password, "employee");
        }

        public void insertTeacherUser(string nationalId, string username, string password)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Value = username,
                Direction = ParameterDirection.Input
            };
            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@national_id",
                SqlDbType = SqlDbType.VarChar,
                Value = nationalId,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);
            parameters.Add(parameterID);
            dbMan.ExecuteNonQuery("updateTeacherUser", "sp", parameters);
            insertUser(username, password, "teacher");
        }

        public void insertTAUser(string nationalId, string username, string password)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Value = username,
                Direction = ParameterDirection.Input
            };
            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@national_id",
                SqlDbType = SqlDbType.VarChar,
                Value = nationalId,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);
            parameters.Add(parameterID);
            dbMan.ExecuteNonQuery("updateTAUser", "sp", parameters);
            insertUser(username, password, "TA");
        }

        public void insertStudentUser(int ID, string username, string password)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Value = username,
                Direction = ParameterDirection.Input
            };
            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@national_id",
                SqlDbType = SqlDbType.Int,
                Value = ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);
            parameters.Add(parameterID);
            dbMan.ExecuteNonQuery("updateStudentUser", "sp", parameters);
            insertUser(username, password, "student");
        }

        public int InsertBookLesson(string StudentID, string Teacher, string Subject,string Slot)
        {
            int sID;
            bool resultStudent = int.TryParse(StudentID, out sID);
            if (resultStudent)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);

        }



        public int DeleteBookLesson(string StudentID, string Teacher, string Subject, string Room, string Slot)
        {
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
            return 1;
        }

        public int UpdateBookLesson(string StudentID, string Teacher, string Subject, string Slot,string OldSlot)
        {
            int sID;
            bool resultStudent = int.TryParse(StudentID, out sID);
            if (resultStudent)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int InsertBookRoom(string Teacher, string Subject, string Room, string DateAndTime , string Type)
        {
            int roomID;
            bool resultRoom = int.TryParse(Room, out roomID);
            if (resultRoom)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteBookRoom(string Teacher, string Subject, string Room, string DateAndTime, string Type)
        {
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
            return 1;
        }

        public int UpdateBookRoom(string Teacher, string Subject, string Room, string DateAndTime, string Type , string oldRoom , string OldDateTime)
        {
            int roomID;
            int roomOld;
            bool resultRoom = int.TryParse(Room, out roomID);
            bool resultOldRoom = int.TryParse(oldRoom, out roomOld);
            if (resultRoom && resultOldRoom)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int InsertAttendance(string StudentID)
        {
            int sID;
            bool resultStudent = int.TryParse(StudentID, out sID);
            if (resultStudent)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteAttendance(string StudentID)
        {
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
            return 1;
        }

        public int UpdateAttendance(string StudentID,string StudentOldID)
        {
            int sID;
            int sOldID;
            bool resultStudent = int.TryParse(StudentID, out sID);
            bool resultOldStudent = int.TryParse(StudentOldID, out sOldID);
            if (resultStudent && resultOldStudent)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int InsertGrade(string StudentID , string ExamID , string Grade)
        {
            int sID;
            int EID;
            bool resultStudent = int.TryParse(StudentID, out sID);
            bool resultExam = int.TryParse(StudentID, out EID);
            if (resultStudent && resultExam)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteGrade(string StudentID , string ExamID)
        {
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
            return 1;
        }

        public int UpdateGrade(string StudentID, string ExamID, string Grade)
        {
            int sID;
            int EID;
            bool resultStudent = int.TryParse(StudentID, out sID);
            bool resultExam = int.TryParse(StudentID, out EID);
            if (resultStudent && resultExam)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int InsertEmployee(string Name, string PhoneNumber, string Salary , string Address , string NationalID)
        {
            int PNo;
            int Sal;
            int NID;
            bool resultPno = int.TryParse(PhoneNumber, out PNo);
            bool resultSal = int.TryParse(Salary, out Sal);
            bool resultNID = int.TryParse(NationalID, out NID);
            if (resultPno && resultSal && resultNID)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteEmployee(string NationalID)
        {
            //string query = "DELETE FROM Employee WHERE SSN='" + SSN + "';";
            //return dbMan.ExecuteNonQuery(query);
            return 1;
        }

        public int UpdateEmployee(string Name, string PhoneNumber, string Salary, string Address, string NationalID)
        {
            int PNo;
            int Sal;
            int NID;
            bool resultPno = int.TryParse(PhoneNumber, out PNo);
            bool resultSal = int.TryParse(Salary, out Sal);
            bool resultNID = int.TryParse(NationalID, out NID);
            if (resultPno && resultSal && resultNID)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int InsertTA(string Name, string PhoneNumber, string ID)
        {
            int PNo;
            int IDTest;
            bool resultPno = int.TryParse(PhoneNumber, out PNo);
            bool resultNID = int.TryParse(ID, out IDTest);
            if (resultPno && resultNID)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteTA(string ID)
        {
            //string query = "DELETE FROM Employee WHERE SSN='" + SSN + "';";
            //return dbMan.ExecuteNonQuery(query);
            return 1;
        }

        public int UpdateTA(string Name, string PhoneNumber, string ID)
        {
            int PNo;
            int IDTest;
            bool resultPno = int.TryParse(PhoneNumber, out PNo);
            bool resultNID = int.TryParse(ID, out IDTest);
            if (resultPno && resultNID)
            {
                return 1;
            }
            else return 0;
            // string query = "";
            //return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            //dbMan.CloseConnection();
        }
    }
}
