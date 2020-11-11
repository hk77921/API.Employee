using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Employee.Models
{
    public class PermanentEmployee : Employee
    {
        public string EmpType
        {
            get
            {
                return "P";
            }
        }
        public override double Salary
        {
            get
            {
                return (2.0 * BasicPay);
            }
        }


    }
}
