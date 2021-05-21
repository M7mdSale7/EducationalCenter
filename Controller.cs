using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        //DBManager dbMan;
        public Controller()
        {
            //dbMan = new DBManager();
        }

        public int InsertBookLesson(string StudentID, string Teacher, string Subject, string Room,string Slot)
        {
            int sID;
            int roomID;
            bool resultStudent = int.TryParse(StudentID, out sID);
            bool resultRoom = int.TryParse(StudentID, out roomID);
            if (resultStudent && resultRoom)
            {
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;

        }


        public int DeleteBookLesson(string SSN)
        {
            //string query = "DELETE FROM Employee WHERE SSN='" + SSN + "';";
            //return dbMan.ExecuteNonQuery(query);
            return 1;
        }

        public int UpdateBookLesson(string StudentID, string Teacher, string Subject, string Room, string Slot)
        {
            //string query = "UPDATE Employee SET Super_SSN=" + Super_SSN + " ,Salary="+Salary+" , Dno=" + Dno+"WHERE SSN=" +SSN+";";
            //return dbMan.ExecuteNonQuery(query);
            return 1;
        }

        public int InsertBookRoom(string Teacher, string Subject, string Room, string DateAndTime , string Type)
        {
            int roomID;
            bool resultRoom = int.TryParse(Room, out roomID);
            if (resultRoom)
            {
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;

        }

        public int DeleteBookRoom(string SSN)
        {
            //string query = "DELETE FROM Employee WHERE SSN='" + SSN + "';";
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
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;
        }

        public int InsertAttendance(string StudentID)
        {
            int sID;
            bool resultStudent = int.TryParse(StudentID, out sID);
            if (resultStudent)
            {
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;

        }

        public int DeleteAttendance(string ID)
        {
            //string query = "DELETE FROM Employee WHERE SSN='" + SSN + "';";
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
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;
        }

        public int InsertGrade(string StudentID , string ExamID , string Grade)
        {
            int sID;
            int EID;
            bool resultStudent = int.TryParse(StudentID, out sID);
            bool resultExam = int.TryParse(StudentID, out EID);
            if (resultStudent && resultExam)
            {
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;

        }

        public int DeleteGrade(string StudentID , string ExamID)
        {
            //string query = "DELETE FROM Employee WHERE SSN='" + SSN + "';";
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
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;
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
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;

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
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;
        }

        public int InsertTA(string Name, string PhoneNumber, string ID)
        {
            int PNo;
            int IDTest;
            bool resultPno = int.TryParse(PhoneNumber, out PNo);
            bool resultNID = int.TryParse(ID, out IDTest);
            if (resultPno && resultNID)
            {
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;

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
                // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
                //return dbMan.ExecuteNonQuery(query);
                return 1;
            }
            else return 0;
        }

        public void TerminateConnection()
        {
            //dbMan.CloseConnection();
        }
    }
}
