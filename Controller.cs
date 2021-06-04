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
            dbMan.ExecuteNonQuery("deleteRoom", "sp", parameters);
        }

        public void deleteRoom(int roomId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@room_id",
                SqlDbType = SqlDbType.Int,
                Value = roomId,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameter);
            dbMan.ExecuteNonQuery("deleteRoom", "sp", parameters);
        }

        public DataTable getAllExams(string subject, string teacher, int year, int roomNum, decimal price)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (subject != "")
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@subject_name",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subject,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (teacher != "")
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@teacher_id",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = teacher,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (year != 0)
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@study_grade",
                    SqlDbType = SqlDbType.Int,
                    Value = year,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (roomNum != 0)
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@room_number",
                    SqlDbType = SqlDbType.Int,
                    Value = roomNum,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (price != 0)
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@price",
                    SqlDbType = SqlDbType.Decimal,
                    Value = price,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }
            
            return dbMan.ExecuteReader("getAllExams", "sp", parameters);
        }

        public DataTable getAllLessons(string subject, string teacher, int year, int roomNum, decimal price)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (subject != "")
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@subject_name",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = subject,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (teacher != "")
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@teacher_id",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = teacher,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (year != 0)
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@study_grade",
                    SqlDbType = SqlDbType.Int,
                    Value = year,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (roomNum != 0)
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@room_number",
                    SqlDbType = SqlDbType.Int,
                    Value = roomNum,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            if (price != 0)
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@price",
                    SqlDbType = SqlDbType.Decimal,
                    Value = price,
                    Direction = ParameterDirection.Input
                };
                parameters.Add(parameter);
            }

            return dbMan.ExecuteReader("getAllLessons", "sp", parameters);
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

        public DataTable getRooms()
        {
            return dbMan.ExecuteReader("getAllRooms", "sp");
        }

        public string[] getRoomsNumbers()
        {
            DataTable data = getRooms();
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }

        public bool RoomExists(int roomId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@room_ID",
                SqlDbType = SqlDbType.Int,
                Value = roomId,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameter);
            return Convert.ToBoolean(dbMan.ExecuteScalar("roomExists", "sp", parameters));
        }

        public bool insertRoom(int roomId, int capacity)
        {
            if (RoomExists(roomId))
                return false;
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterID = new SqlParameter
            {
                ParameterName = "@room_ID",
                SqlDbType = SqlDbType.Int,
                Value = roomId,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterID);

            SqlParameter parameterCap = new SqlParameter
            {
                ParameterName = "@max_capacity",
                SqlDbType = SqlDbType.Int,
                Value = capacity,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterCap);
            dbMan.ExecuteScalar("insertRoom", "sp", parameters);
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

        public string[] getAllSubjectsname(string Teacher = "")
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
            DataTable data = dbMan.ExecuteReader("getAllSubjectsname", "sp", parameters);
            string[] items = { };
            if (data != null)
                items = data.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            return items;
        }

        public string getTeacherName(string teacherID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@national_id",
                SqlDbType = SqlDbType.NVarChar,
                Value = teacherID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameter);
            string temp  = Convert.ToString(dbMan.ExecuteScalar("getTeacherName", "sp", parameters));
            if (temp == null)
                return "";

            return temp;
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
        public string[] getAllTeahcersname(string subject = "")
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
            return Convert.ToBoolean(dbMan.ExecuteScalar("insertStudent", "sp", parameters));
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
            return Convert.ToBoolean(dbMan.ExecuteScalar("insertParent", "sp", parameters));
        }

        public DataTable getTeacherSchedule(int TeacherID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@TeacherID",
                SqlDbType = SqlDbType.Int,
                Value = TeacherID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);

            return dbMan.ExecuteReader("getTeacherSchedule", "sp", parameters);
        }

        public DataTable getTeacherStudents(int TeacherID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@TeacherID",
                SqlDbType = SqlDbType.Int,
                Value = TeacherID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);

            return dbMan.ExecuteReader("getTeacherStudents", "sp", parameters);
        }

        public DataTable getTeacherGradesReport(int TeacherID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@TeacherID",
                SqlDbType = SqlDbType.Int,
                Value = TeacherID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);

            return dbMan.ExecuteReader("getTeacherGradesReport", "sp", parameters);
        }

        public bool checkStudentID(int TeacherID, int StudentID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterTeacherID = new SqlParameter
            {
                ParameterName = "@TeacherID",
                SqlDbType = SqlDbType.Int,
                Value = TeacherID,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterStudentID = new SqlParameter
            {
                ParameterName = "@StudentID",
                SqlDbType = SqlDbType.Int,
                Value = StudentID,
                Direction = ParameterDirection.Input
            };

            parameters.Add(parameterTeacherID);
            parameters.Add(parameterStudentID);

            return Convert.ToBoolean(dbMan.ExecuteScalar("checkStudentID", "sp", parameters));

        }

        public bool checkExamID(int TeacherID, int ExamID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterTeacherID = new SqlParameter
            {
                ParameterName = "@TeacherID",
                SqlDbType = SqlDbType.Int,
                Value = TeacherID,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterExamID = new SqlParameter
            {
                ParameterName = "@ExamID",
                SqlDbType = SqlDbType.Int,
                Value = ExamID,
                Direction = ParameterDirection.Input
            };

            parameters.Add(parameterTeacherID);
            parameters.Add(parameterExamID);

            return Convert.ToBoolean(dbMan.ExecuteScalar("checkExamID", "sp", parameters));

        }

        public void insertTeacherGradeReport(int TeacherID, int StudentID, int ExamID, string Grade)
        {
            if (!checkStudentID(TeacherID, StudentID))
            {
                MessageBox.Show("Invalid Student ID.");
                return;
            }
            if (!checkExamID(TeacherID, ExamID))
            {
                MessageBox.Show("Invalid Exam ID.");
                return;
            }

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterStudentID = new SqlParameter
            {
                ParameterName = "@StudentID",
                SqlDbType = SqlDbType.Int,
                Value = StudentID,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterExamID = new SqlParameter
            {
                ParameterName = "@ExamID",
                SqlDbType = SqlDbType.Int,
                Value = ExamID,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterGrade = new SqlParameter
            {
                ParameterName = "@Grade",
                SqlDbType = SqlDbType.VarChar,
                Value = Grade,
                Direction = ParameterDirection.Input
            };

            parameters.Add(parameterStudentID);
            parameters.Add(parameterExamID);
            parameters.Add(parameterGrade);


            dbMan.ExecuteNonQuery("insertTeacherGradeReport", "sp", parameters);
        }

        public DataTable getTeacherExams(int TeacherID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterUser = new SqlParameter
            {
                ParameterName = "@TeacherID",
                SqlDbType = SqlDbType.Int,
                Value = TeacherID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterUser);

            return dbMan.ExecuteReader("TeacherExams", "sp", parameters);
        }

        public DataTable getTeacherAssistants(int TeacherID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterTeacher = new SqlParameter
            {
                ParameterName = "@TeacherID",
                SqlDbType = SqlDbType.Int,
                Value = TeacherID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterTeacher);

            return dbMan.ExecuteReader("getTeacherAssistants", "sp", parameters);
        }

        public bool insertTeacherAssistant(string AssistantName, int AssistantID, int PhoneNumber, int TeacherID,
                                            string username = "")
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterAssistantName = new SqlParameter
            {
                ParameterName = "@AssistantName",
                SqlDbType = SqlDbType.NVarChar,
                Value = AssistantName,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterAssistantID = new SqlParameter
            {
                ParameterName = "@AssistantID",
                SqlDbType = SqlDbType.Int,
                Value = AssistantID,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterPhoneNumber = new SqlParameter
            {
                ParameterName = "@PhoneNumber",
                SqlDbType = SqlDbType.Int,
                Value = PhoneNumber,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterTeacherID = new SqlParameter
            {
                ParameterName = "@TeacherID",
                SqlDbType = SqlDbType.Int,
                Value = TeacherID,
                Direction = ParameterDirection.Input
            };

            parameters.Add(parameterAssistantName);
            parameters.Add(parameterAssistantID);
            parameters.Add(parameterPhoneNumber);
            parameters.Add(parameterTeacherID);

            if (username != "")
            {
                SqlParameter parameterusername = new SqlParameter
                {
                    ParameterName = "@username",
                    SqlDbType = SqlDbType.VarChar,
                    Value = username,
                    Direction = ParameterDirection.Input
                };

                parameters.Add(parameterusername);
            }

            return Convert.ToBoolean(dbMan.ExecuteNonQuery("insertTeacherAssistant", "sp", parameters));
        }

        public void deleteGradeReport(int StudentID, int ExamID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterStudentID = new SqlParameter
            {
                ParameterName = "@StudentID",
                SqlDbType = SqlDbType.Int,
                Value = StudentID,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterExamID = new SqlParameter
            {
                ParameterName = "@ExamID",
                SqlDbType = SqlDbType.Int,
                Value = ExamID,
                Direction = ParameterDirection.Input
            };

            parameters.Add(parameterStudentID);
            parameters.Add(parameterExamID);
            dbMan.ExecuteNonQuery("deleteGradeReport", "sp", parameters);
        }

        public void deleteTeachingAssistant(int TeachingAssistantID, int TeacherID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterTeachingAssistantID = new SqlParameter
            {
                ParameterName = "@TeachingAssistantID",
                SqlDbType = SqlDbType.Int,
                Value = TeachingAssistantID,
                Direction = ParameterDirection.Input
            };

            SqlParameter parameterTeacherID = new SqlParameter
            {
                ParameterName = "@TeacherID",
                SqlDbType = SqlDbType.Int,
                Value = TeacherID,
                Direction = ParameterDirection.Input
            };

            parameters.Add(parameterTeachingAssistantID);
            parameters.Add(parameterTeacherID);
            dbMan.ExecuteNonQuery("deleteTeachingAssistant", "sp", parameters);
        }

        public int getTeacherID(string TeacherUserName)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameterTeacherUserName = new SqlParameter
            {
                ParameterName = "@TeacherUserName",
                SqlDbType = SqlDbType.VarChar,
                Value = TeacherUserName,
                Direction = ParameterDirection.Input
            };


            return Convert.ToInt32(dbMan.ExecuteScalar("getTeacherID", "sp", parameters));
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
            SqlParameter parameterGrade = new SqlParameter
            {
                ParameterName = "@national_ID",
                SqlDbType = SqlDbType.Char,
                Value = ID,
                Direction = ParameterDirection.Input
            };
            parameters.Add(parameterGrade);
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
            return Convert.ToBoolean(dbMan.ExecuteScalar("insertTeacher", "sp", parameters));
        }

        public void TerminateConnection()
        {
            //dbMan.CloseConnection();
        }

    }
}
