using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Employee.Models;

namespace API.Employee.Factory
{
    public class EmployeeFactory
    {
        public PermanentEmployee GetPermamentEmploye()
        {
            return (new PermanentEmployee());
        }

        public TemporaryEmployee GetTempEmploye()
        {
            return (new TemporaryEmployee());
        }


    }
}
