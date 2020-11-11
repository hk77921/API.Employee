using API.Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Employee.Context
{
    public interface ITemporaryEmployee
    {
        public IEnumerable<TemporaryEmployee> GetEmployees();
        public TemporaryEmployee GetEmployeeByID(string ID);
        public void InsertEmployee(TemporaryEmployee employee);
        public void DeleteEmployee(string ID);
        public void UpdateEmployee(TemporaryEmployee employee);
    }
}
