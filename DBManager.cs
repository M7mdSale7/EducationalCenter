using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace EducationalCenter
{
    public class DBManager
    {

        string DB_Connection_String = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        SqlConnection myConnection = null;


        public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open(); //Open a connection with the DB
                //just for illustration when the database is opened, this should not be shown in GUI to the user
                MessageBox.Show("Successfully connected to the database!");
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while connecting to the database!");
            }
        }


        public int ExecuteNonQuery(string query, string s = "t", List<SqlParameter> parameters = null)
        {
            try
            {
                SqlCommand myCommand = null;
                if (s == "t")
                {
                    myCommand = new SqlCommand(query, myConnection);
                }
                else if(s == "sp")
                {
                    myCommand = new SqlCommand(query, myConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if(parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            myCommand.Parameters.Add(parameter);
                        }
                    }
                }

                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string query, string s = "t", List<SqlParameter> parameters = null)
        {
            try
            {

                SqlCommand myCommand = null;
                if (s == "t")
                {
                    myCommand = new SqlCommand(query, myConnection);
                }
                else if (s == "sp")
                {
                    myCommand = new SqlCommand(query, myConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if(parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            myCommand.Parameters.Add(parameter);
                        }
                    }

                }
                SqlDataReader reader = myCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string query, string s = "t", List<SqlParameter> parameters = null)
        {
            try
            {
                SqlCommand myCommand = null;
                if (s == "t")
                {
                    myCommand = new SqlCommand(query, myConnection);
                }
                else if (s == "sp")
                {
                    myCommand = new SqlCommand(query, myConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    foreach (SqlParameter parameter in parameters)
                    {
                        myCommand.Parameters.Add(parameter);
                    }
                }
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
;
