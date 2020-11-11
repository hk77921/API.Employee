using API.Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Employee.Context
{
    public class PermamentEmployeeRepository : IPermamentEmployee
    {
        private readonly APIContext _context;

        public PermamentEmployeeRepository(APIContext context)
        {
            this._context = context;
        }

        public IEnumerable<PermanentEmployee> GetEmployees()
        {
            return _context.GetPermanentEmp();
        }

        public void DeleteEmployee(string ID)
        {
            _context.RemoveEmployee(ID);
        }

        public PermanentEmployee GetEmployeeByID(string ID)
        {
            return _context.GetEmployeebyID(ID);
        }

        
        public void InsertEmployee(PermanentEmployee employee)
        {
            _context.AddEmployee(employee);
        }

        public void UpdateEmployee(PermanentEmployee employee)
        {
            _context.UpdateEmployee(employee);
        }
    }
}
