using API.Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Employee.Context
{
    public class TemporaryEmployeeRepository : ITemporaryEmployee
    {
        private readonly APIContext _context;

        public TemporaryEmployeeRepository(APIContext context)
        {
            _context = context;
        }
        public void DeleteEmployee(string ID)
        {
            _context.RemoveTemporaryEmployee(ID);
        }

        public TemporaryEmployee GetEmployeeByID(string ID)
        {
            return _context.GetTemporaryEmpbyID(ID);
        }

        public IEnumerable<TemporaryEmployee> GetEmployees()
        {
            return _context.GetTemporaryEmp();
        }

        public void InsertEmployee(TemporaryEmployee employee)
        {
            _context.AddTemporaryEmployee(employee);
        }

        public void UpdateEmployee(TemporaryEmployee employee)
        {
            _context.UpdateTemporaryEmployee(employee);
        }
    }
}
