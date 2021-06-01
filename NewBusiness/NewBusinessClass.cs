using NewDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NewModel;

namespace NewBusiness
{
    public class NewBusinessClass
    {
        public static List<EmployeeInformation> EmployeeInformation()
        {
            
            var IndivDemoList = new List<EmployeeInformation>();
            DataSet dsGetReport = new DataSet();

            //2rd Assignment
            //Get the Employee List from database but get the connection string details from web.Config file
            dsGetReport = DataAccessEmployee.GetEmployeesUsingDBWithOutConfig();

            //3rd Assignment
            //Calling web service - Get the Employee List from database but get the connection string details from web.Config file
            //var testService = new MyInfoService.MyInfoServiceClient();
            //dsGetReport = testService.GetUsingDBWithConfig();

            //------------------------------------------------------------------------------------------
            //Get the Employee List from database but define the connection string in this method
            //dsGetReport = DAInformation.GetUsingDBWithOutConfig();
            //dsGetReport = testService.GetUsingDBWithOutConfig();

            //var testServ = new DemoInformationService.DemoInformationServiceClient();
            //Get the Employee List data by NOT USING the database
            //dsGetReport = DAInformation.GetWithOutDB();
            //dsGetReport = testService.GetWithOutDB();
            //------------------------------------------------------------------------------------------

            //Transfer Dataset details to List Object
            if (dsGetReport.Tables.Count > 0)
            {
                IndivDemoList = dsGetReport.Tables[0].AsEnumerable().Select(m => new EmployeeInformation
                {
                    //Left side is Model Object - Right Side is Database columns
                    FirstName = Convert.ToString(m["FirstName"]),
                    LastName = Convert.ToString(m["LastName"]),
                    Sex = Convert.ToString(m["Gender"]),
                    Address = Convert.ToString(m["Address"]),
                    Emp_no = Convert.ToInt32(m["EmployeeID"]),
                    Hire_date = Convert.ToString(m["HireDate"])
                }).ToList();

            }

            //Build the Business Logic here based on the requirements from the client

            return IndivDemoList;

        }
    }
}
