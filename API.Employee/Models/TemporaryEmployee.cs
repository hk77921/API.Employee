using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Employee.Models
{
    public class TemporaryEmployee : Employee
    {
        public string EmpType
        {
            get
            {
                return "T";
            }
        }
        public override double Salary
        {
            get
            {
                return (1.5 * BasicPay);
            }
        }
    }
}
