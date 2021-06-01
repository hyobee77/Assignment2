using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NewModel
{
    public class EmployeeInformation
    {
        //Define the properties
        //customerNumber
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Sex")]
        public string Sex { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        //Employee Information Properties
        [DisplayName("Employee ID")]
        public int Emp_no { get; set; }

        [DisplayName("Hire Date")]
        public string Hire_date { get; set; }

    }
}
