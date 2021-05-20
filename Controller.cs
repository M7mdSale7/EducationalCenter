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
            
            // string query = "INSERT INTO Employee " + "Values ('"  + name + "'," +SSN + ",null,'"+ Sex + "'," +Salary+ "," + Supper_SSN +"," +Dno+ ");";
            //return dbMan.ExecuteNonQuery(query);
            return 1;

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


        public void TerminateConnection()
        {
            //dbMan.CloseConnection();
        }
    }
}
