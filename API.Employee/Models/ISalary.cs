using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Employee.Models
{
    interface ISalary
    {
       double ComputeSalary(double basePay);
    }
}
