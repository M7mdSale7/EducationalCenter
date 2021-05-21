using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace EducationalCenter
{
    public class Controller
    {
        //DBManager dbMan;
        public Controller()
        {
            //dbMan = new DBManager();
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
