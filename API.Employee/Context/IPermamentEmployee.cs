using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Employee.Models;


namespace API.Employee.Context
{
   public interface IPermamentEmployee
    {
        public IEnumerable<PermanentEmployee> GetEmployees();
        public PermanentEmployee GetEmployeeByID(string ID);
        public void InsertEmployee(PermanentEmployee employee);
        public void DeleteEmployee(string ID);
        public void UpdateEmployee(PermanentEmployee employee);
    }
}
