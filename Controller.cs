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


        public DataTable Student_getAvaliableLessons(string username, string subjectname, string Teacher)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (username != "")
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@userName",
                    SqlDbType = SqlDbType.VarChar,
                    Value = username,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }

            if (subjectname != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@subjectname",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subjectname,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }

            if (Teacher != "")
            {
                SqlParameter parameterType = new SqlParameter
                {
                    ParameterName = "@Teacher",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = Teacher,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterType);
            }

            return dbMan.ExecuteReader("Student_getAvaliableLessons", "sp", parameters);
        }
        public DataTable getAllAccounts(string username, string password, string usertype)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (username != "")
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

        public DataTable getAllEmployees(string ID, string name, string address, decimal salary, string phoneNumber)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (ID != "")
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@ID",
                    SqlDbType = SqlDbType.Char,
                    Value = ID,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (name != "")
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@name",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = name,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (address != "")
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@address",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = address,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (salary != 0)
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@salary",
                    SqlDbType = SqlDbType.Decimal,
                    Value = salary,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (phoneNumber != "")
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@phone_number",
                    SqlDbType = SqlDbType.Char,
                    Value = phoneNumber,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            return dbMan.ExecuteReader("getAllEmployees", "sp", parameters);
        }

        public bool insertEmployee(string NID, string name, decimal salary, string address, string phoneNum)
        {
            List<SqlParameter> parameters1 = new List<SqlParameter>();
            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@national_ID",
                SqlDbType = SqlDbType.Char,
                Value = NID,
                Direction = ParameterDirection.Input
            };
            parameters1.Add(parameterID);

            if (Convert.ToBoolean(dbMan.ExecuteScalar("searchEmployee", "sp", parameters1)))
                return false; //if the insertion cannot be done

            List<SqlParameter> parameters2 = new List<SqlParameter>();

            SqlParameter parameterID2 = new SqlParameter
            {
                ParameterName = "@national_ID",
                SqlDbType = SqlDbType.Char,
                Value = NID,
                Direction = ParameterDirection.Input
            };
            parameters2.Add(parameterID2);

            SqlParameter parameterName = new SqlParameter
            {
                ParameterName = "@employee_name",
                SqlDbType = SqlDbType.NVarChar,
                Value = name,
                Direction = ParameterDirection.Input
            };
            parameters2.Add(parameterName);

            SqlParameter parameterSalary = new SqlParameter
            {
                ParameterName = "@salary",
                SqlDbType = SqlDbType.Decimal,
                Value = salary,
                Direction = ParameterDirection.Input
            };
            parameters2.Add(parameterSalary);

            if (address != "")
            {
                SqlParameter parameterAddress = new SqlParameter
                {
                    ParameterName = "@phone_number",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = address,
                    Direction = ParameterDirection.Input
                };
                parameters2.Add(parameterAddress);
            }

            if (phoneNum != "")
            {
                SqlParameter parameterPhone = new SqlParameter
                {
                    ParameterName = "@phone_number",
                    SqlDbType = SqlDbType.Char,
                    Value = phoneNum,
                    Direction = ParameterDirection.Input
                };
                parameters2.Add(parameterPhone);
            }
            dbMan.ExecuteNonQuery("insertEmployee", "sp", parameters2);
            return true;
        }

        public void deleteEmployee(string NID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@NID",
                SqlDbType = SqlDbType.Char,
                Value = NID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameter);
            dbMan.ExecuteNonQuery("deleteEmployee", "sp", parameters);
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
        public DataTable Student_getAllLessonsOrExams(string username, string type, string subjectname, string Teacher, string roomnum, string start_datetime, string end_datetime)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (username != "")
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
            if (type != "")
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@type",
                    SqlDbType = SqlDbType.VarChar,
                    Value = type,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }
            if (subjectname != "")
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@subjectname",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subjectname,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }
            if (Teacher != "")
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@Teacher",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = Teacher,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }

            if (roomnum != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@roomnum",
                    SqlDbType = SqlDbType.Int,
                    Value = roomnum,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }

            if (start_datetime != "")
            {
                SqlParameter parameterType = new SqlParameter
                {
                    ParameterName = "@start_datetime",
                    SqlDbType = SqlDbType.DateTime,
                    Value = start_datetime,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterType);
            }

            if (end_datetime != "")
            {
                SqlParameter parameterType = new SqlParameter
                {
                    ParameterName = "@end_datetime",
                    SqlDbType = SqlDbType.DateTime,
                    Value = end_datetime,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterType);
            }
            return dbMan.ExecuteReader("Student_getAllLessonsOrExams", "sp", parameters);
        }
        public DataTable Student_getGradesReport(string username, string subjectname, string Teacher, string Grade)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (username != "")
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@userName",
                    SqlDbType = SqlDbType.VarChar,
                    Value = username,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }
            if (subjectname != "")
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@subjectname",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subjectname,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }

            if (Teacher != "")
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@Teacher",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = Teacher,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }

            if (Grade != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@Grade",
                    SqlDbType = SqlDbType.VarChar,
                    Value = Grade,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            return dbMan.ExecuteReader("Student_getGradesReport", "sp", parameters);
        }
        public DataTable getAllTeachers(string subject)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (subject != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@subject",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subject,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            return dbMan.ExecuteReader("getAllTeachers", "sp", parameters);
        }
        public bool deleteUser(string username, string usertype)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Value = username,
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
            parameters.Add(parameterType);
            dbMan.ExecuteNonQuery("deleteUser", "sp", parameters);
            return true;

        }
        public DataTable getAllParents(string parentname, string stringstudentID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (parentname != "")
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@parentname",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = parentname,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }
            int studentID;
            if (int.TryParse(stringstudentID, out studentID))
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@studentID",
                    SqlDbType = SqlDbType.Int,
                    Value = studentID,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            return dbMan.ExecuteReader("getAllParents", "sp", parameters);
        }
        public DataTable getAllStudents(int grade, string subjectname, string teachername)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (grade != 0)
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@grade",
                    SqlDbType = SqlDbType.Int,
                    Value = grade,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }
            if (subjectname != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@subjectname",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subjectname,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            if (teachername != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@teachername",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = teachername,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            return dbMan.ExecuteReader("getAllStudents", "sp", parameters);
        }
        public void TerminateConnection()
        {
            //dbMan.CloseConnection();
        }

        public string[] getAvaliableSubjects(string username)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (username != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@username",
                    SqlDbType = SqlDbType.VarChar,
                    Value = username,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            DataTable data = dbMan.ExecuteReader("getAvaliableSubjects", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public string[] getAvaliableSubjects_Teachers(string username, string subjectname)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (username != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@username",
                    SqlDbType = SqlDbType.VarChar,
                    Value = username,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            if (subjectname != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@subjectname",
                    SqlDbType = SqlDbType.VarChar,
                    Value = subjectname,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            DataTable data = dbMan.ExecuteReader("getAvaliableSubjects_Teachers", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }

        public string[] getAllSubjectsname(int grade=0,string Teacher = "")
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (Teacher != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@Teacher",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = Teacher,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            if (grade != 0)
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@grade",
                    SqlDbType = SqlDbType.Int,
                    Value = grade,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            DataTable data = dbMan.ExecuteReader("getAllSubjectsname", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }

        public string[] getAllStudentID()
        {
            DataTable data = dbMan.ExecuteReader("getAllstudentID", "sp");
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }

        public string[] getAllParentsname()
        {
            DataTable data = dbMan.ExecuteReader("getAllParentsname", "sp");
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public string[] getAllTeachersname(string subject = "")
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (subject != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@subject",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subject,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            DataTable data = dbMan.ExecuteReader("getAllTeachersname", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public string[] getAllTeahcersID(string subject = "")
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (subject != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@subject",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subject,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            DataTable data = dbMan.ExecuteReader("getAllTeachersID", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public string[] getExams_Subjects(string username, string Teacher = "")
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (username != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@username",
                    SqlDbType = SqlDbType.VarChar,
                    Value = username,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            if (Teacher != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@Teacher",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = Teacher,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            DataTable data = dbMan.ExecuteReader("getExams_Subjects", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }

        public string[] getExams_Teachers(string username, string subjectname = "")
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (username != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@username",
                    SqlDbType = SqlDbType.VarChar,
                    Value = username,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            if (subjectname != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@subjectname",
                    SqlDbType = SqlDbType.VarChar,
                    Value = subjectname,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            DataTable data = dbMan.ExecuteReader("getExams_Teachers", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public bool insertStudent(string name, int grade, string phonenumber) //uses sp query
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterName = new SqlParameter
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.NVarChar,
                Value = name,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterName);
            SqlParameter parameterGrade = new SqlParameter
            {
                ParameterName = "@grade",
                SqlDbType = SqlDbType.Int,
                Value = grade,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterGrade);
            if (phonenumber != "")
            {
                SqlParameter parameterPhone = new SqlParameter
                {
                    ParameterName = "@phonenumber",
                    SqlDbType = SqlDbType.Char,
                    Value = phonenumber,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPhone);
            }
            return Convert.ToBoolean(dbMan.ExecuteNonQuery("insertStudent", "sp", parameters));
        }
        public bool insertParent(string name, int studentID, string phonenumber) //uses sp query
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterName = new SqlParameter
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.NVarChar,
                Value = name,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterName);
            SqlParameter parameterGrade = new SqlParameter
            {
                ParameterName = "@studentID",
                SqlDbType = SqlDbType.Int,
                Value = studentID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterGrade);
            if (phonenumber != "")
            {
                SqlParameter parameterPhone = new SqlParameter
                {
                    ParameterName = "@phonenumber",
                    SqlDbType = SqlDbType.Char,
                    Value = phonenumber,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPhone);
            }
            return Convert.ToBoolean(dbMan.ExecuteNonQuery("insertParent", "sp", parameters));
        }
        public bool insertTeacher(string name, string ID, string phonenumber) //uses sp query
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterName = new SqlParameter
            {
                ParameterName = "@teacher_name",
                SqlDbType = SqlDbType.NVarChar,
                Value = name,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterName);
            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@national_ID",
                SqlDbType = SqlDbType.Char,
                Value = ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterID);
            if (phonenumber != "")
            {
                SqlParameter parameterPhone = new SqlParameter
                {
                    ParameterName = "@phone_number",
                    SqlDbType = SqlDbType.Char,
                    Value = phonenumber,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPhone);
            }
            return Convert.ToBoolean(dbMan.ExecuteNonQuery("insertTeacher", "sp", parameters));
        }
        public bool insertSubject(string name, int grade, string TID) //uses sp query
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterName = new SqlParameter
            {
                ParameterName = "@subject_name",
                SqlDbType = SqlDbType.NVarChar,
                Value = name,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterName);
            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@TID",
                SqlDbType = SqlDbType.Char,
                Value = TID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterID);
            SqlParameter parameterGrade = new SqlParameter
            {
                ParameterName = "@study_grade",
                SqlDbType = SqlDbType.Int,
                Value = grade,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterGrade);

            return Convert.ToBoolean(dbMan.ExecuteNonQuery("insertSubject", "sp", parameters));
        }

        public DataTable getAllSubjects(string teacher, int year, string subject)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (year != 0)
            {
                SqlParameter parameterUser = new SqlParameter
                {
                    ParameterName = "@grade",
                    SqlDbType = SqlDbType.Int,
                    Value = year,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterUser);
            }
            if (subject != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@subjectname",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subject,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            if (teacher != "")
            {
                SqlParameter parameterPass = new SqlParameter
                {
                    ParameterName = "@teachername",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = teacher,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterPass);
            }
            return dbMan.ExecuteReader("getAllSubjects", "sp", parameters);
        }
        public void deleteStudent(string stringID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            int ID = Convert.ToInt32(stringID);
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@ID",
                SqlDbType = SqlDbType.Int,
                Value = ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameter);
            dbMan.ExecuteNonQuery("deleteStudent", "sp", parameters);
        }

        public void deleteTeacher(string ID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@ID",
                SqlDbType = SqlDbType.Char,
                Value = ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameter);
            dbMan.ExecuteNonQuery("deleteTeacher", "sp", parameters);
        }
        public void deleteParent(string name,string stringSID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            int SID = Convert.ToInt32(stringSID);
            SqlParameter parameterName = new SqlParameter
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.NVarChar,
                Value = name,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterName);
            SqlParameter parameterSID = new SqlParameter
            {
                ParameterName = "@SID",
                SqlDbType = SqlDbType.Int,
                Value = SID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterSID);
            dbMan.ExecuteNonQuery("deleteParent", "sp", parameters);
        }
        public void deleteSubject(string stringID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            int ID = Convert.ToInt32(stringID);
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@ID",
                SqlDbType = SqlDbType.Int,
                Value = ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameter);
            dbMan.ExecuteNonQuery("deleteSubject", "sp", parameters);
        }

        public int getStudentYear(int ID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@ID",
                SqlDbType = SqlDbType.Int,
                Value = ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameter);
            return Convert.ToInt32(dbMan.ExecuteScalar("getStudentYear", "sp", parameters));
        }

        public int getSubjectID(string name, string teacher)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parametername = new SqlParameter
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.NVarChar,
                Value = name,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parametername);
            SqlParameter parameterteacher = new SqlParameter
            {
                ParameterName = "@teacher",
                SqlDbType = SqlDbType.NVarChar,
                Value = teacher,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterteacher);
            return Convert.ToInt32(dbMan.ExecuteScalar("getSubjectID", "sp", parameters));
        }
        public bool insertStudies(int student_ID, int subject_ID) //uses sp query
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterStudent_ID = new SqlParameter
            {
                ParameterName = "@student_ID",
                SqlDbType = SqlDbType.Int,
                Value = student_ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterStudent_ID);
            SqlParameter parameterSubject_ID = new SqlParameter
            {
                ParameterName = "@subject_ID",
                SqlDbType = SqlDbType.Int,
                Value = subject_ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterSubject_ID);
            return Convert.ToBoolean(dbMan.ExecuteNonQuery("insertStudies", "sp", parameters));
        }

        public DataTable getAllStudies(string stringID, string subject, string teacher)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (stringID != "")
            {
                int ID = Convert.ToInt32(stringID);
                SqlParameter parameterID= new SqlParameter
                {
                    ParameterName = "@ID",
                    SqlDbType = SqlDbType.Int,
                    Value = ID,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterID);
            }
            if (subject != "")
            {
                SqlParameter parametersubject = new SqlParameter
                {
                    ParameterName = "@subject",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subject,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parametersubject);
            }
            if (teacher != "")
            {
                SqlParameter parameterteacher = new SqlParameter
                {
                    ParameterName = "@teachername",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = teacher,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameterteacher);
            }
            return dbMan.ExecuteReader("getAllStudies", "sp", parameters);
        }

        public void deleteStudies(int student_ID, int subject_ID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterstudent = new SqlParameter
            {
                ParameterName = "@student_ID",
                SqlDbType = SqlDbType.Int,
                Value = student_ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterstudent);
            SqlParameter parametersubject = new SqlParameter
            {
                ParameterName = "@subject_ID",
                SqlDbType = SqlDbType.Int,
                Value = subject_ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parametersubject);
            dbMan.ExecuteNonQuery("deleteStudies", "sp", parameters);
        }

        public DataTable getAllAttends()
        {
            return dbMan.ExecuteReader("getAllAttends", "sp");
        }

        public string[] getTeacher_by_SID(int ID, string subject)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterID = new SqlParameter
            {
                    ParameterName = "@ID",
                    SqlDbType = SqlDbType.Int,
                    Value = ID,
                    Direction = ParameterDirection.Input
            };
            parameters.Add(parameterID);
            SqlParameter parametersubject = new SqlParameter
            {
                ParameterName = "@subject",
                SqlDbType = SqlDbType.NVarChar,
                Value = subject,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parametersubject);
            DataTable data = dbMan.ExecuteReader("getTeacher_by_SID", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }

        public string[] getSubject_by_SID(int ID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@ID",
                SqlDbType = SqlDbType.Int,
                Value = ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterID);
            DataTable data = dbMan.ExecuteReader("getSubject_by_SID", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public string[] getSlots(int ID, string subject,string teacher,string type)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@ID",
                SqlDbType = SqlDbType.Int,
                Value = ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterID);
            SqlParameter parametersubject = new SqlParameter
            {
                ParameterName = "@subject",
                SqlDbType = SqlDbType.NVarChar,
                Value = subject,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parametersubject);
            SqlParameter parameterteacher = new SqlParameter
            {
                ParameterName = "@teacher",
                SqlDbType = SqlDbType.NVarChar,
                Value = teacher,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterteacher);
            SqlParameter parametertype = new SqlParameter
            {
                ParameterName = "@type",
                SqlDbType = SqlDbType.VarChar,
                Value = type,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parametertype);
            DataTable data = dbMan.ExecuteReader("getSlots", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }
        public int getReservation_number(int subjectID, string type, string start_datetime)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parametersubjectID = new SqlParameter
            {
                ParameterName = "@subject_ID",
                SqlDbType = SqlDbType.Int,
                Value = subjectID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parametersubjectID);
            SqlParameter parametertype = new SqlParameter
            {
                ParameterName = "@type",
                SqlDbType = SqlDbType.VarChar,
                Value = type,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parametertype);
            SqlParameter parameterstart_datetime = new SqlParameter
            {
                ParameterName = "@start_datetime",
                SqlDbType = SqlDbType.DateTime,
                Value = start_datetime,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterstart_datetime);
            return Convert.ToInt32(dbMan.ExecuteScalar("getReservation_number", "sp", parameters));
        }
        public bool insertAttend(int student_ID, int reservation_number) //uses sp query
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterStudent_ID = new SqlParameter
            {
                ParameterName = "@student_ID",
                SqlDbType = SqlDbType.Int,
                Value = student_ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterStudent_ID);
            SqlParameter parameterreservation_number = new SqlParameter
            {
                ParameterName = "@reservation_number",
                SqlDbType = SqlDbType.Int,
                Value = reservation_number,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterreservation_number);
            return Convert.ToBoolean(dbMan.ExecuteNonQuery("insertAttend", "sp", parameters));
        }
        public string getPrice(int subjectID, string type, string start_datetime)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parametersubjectID = new SqlParameter
            {
                ParameterName = "@subject_ID",
                SqlDbType = SqlDbType.Int,
                Value = subjectID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parametersubjectID);
            SqlParameter parametertype = new SqlParameter
            {
                ParameterName = "@type",
                SqlDbType = SqlDbType.VarChar,
                Value = type,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parametertype);
            SqlParameter parameterstart_datetime = new SqlParameter
            {
                ParameterName = "@start_datetime",
                SqlDbType = SqlDbType.DateTime,
                Value = start_datetime,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterstart_datetime);
            return dbMan.ExecuteScalar("getPrice", "sp", parameters).ToString();
        }
        public void deleteAttend(int student_ID, int reservation_number)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameterstudent = new SqlParameter
            {
                ParameterName = "@student_ID",
                SqlDbType = SqlDbType.Int,
                Value = student_ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterstudent);
            SqlParameter parameterreservation = new SqlParameter
            {
                ParameterName = "@reservation_number",
                SqlDbType = SqlDbType.Int,
                Value = reservation_number,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterreservation);
            dbMan.ExecuteNonQuery("deleteAttend", "sp", parameters);
        }
    }
}
