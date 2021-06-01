using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace NewDataAccess
{
    public class DataAccessEmployee
    {
        public static DataSet EmployeeInformation
        {
            get
            {

                string cs = "server=localhost;user=root;database=employees;port=3306;password=password";
                MySqlConnection conn = new MySqlConnection(cs);

                try
                {
                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();

                    string sql = "SELECT * FROM employees";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + " ," + rdr[1] + " ," + rdr[2] + " ," + rdr[3] + " ," + rdr[4] + " ," + rdr[5]);
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();
                Console.WriteLine("Done.");
                return new DataSet();
            }
        }

        public static DataSet GetEmployeesUsingDBWithOutConfig()
        {
            string connetionString = null;

            MySqlConnection cnn;
            MySqlCommand command;
            MySqlDataReader dataReader;
            DataTable dt = new DataTable();
            DataSet dsGetEmployees = new DataSet();

            connetionString = "server=localhost;user=root;database=employees;port=3306;password=root;";
            cnn = new MySqlConnection(connetionString);

            string sql = null;
            sql = "Select * from Employees";

            //Open the connection
            cnn.Open();
            command = new MySqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetEmployees.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetEmployees;
        }
        public static DataSet GetEmployeesUsingDBWithConfig()
        {
            MySqlConnection cnn;
            string sql = null;
            MySqlCommand command;
            MySqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet dsGetEmployees = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["EMPLOYEE_CONNECTION_DEV"].ConnectionString;
            cnn = new MySqlConnection(cs);
            sql = "Select * from Employees";

            //Open the connection
            cnn.Open();
            command = new MySqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetEmployees.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetEmployees;
        }
    }
}
