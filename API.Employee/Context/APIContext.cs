using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Employee.Models;
using API.Employee.Factory;

namespace API.Employee.Context
{
    public class APIContext : DbContext
    {
        public DbSet<PermanentEmployee> permanentEmployees { get; set; }
        public DbSet<TemporaryEmployee> temporaryEmployees { get; set; }


        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
            if (_PermamentempList.Count == 0)
                LoadPermamentEmployeefromDatabase();
            if (_TempempList.Count == 0)
                LoadTemporaryEmployeefromDatabase();
        }


        EmployeeFactory employeeFactory = new EmployeeFactory();

        static List<PermanentEmployee> _PermamentempList = new List<PermanentEmployee>();
        static List<TemporaryEmployee> _TempempList = new List<TemporaryEmployee>();


    

        // Loading the initial data
        private List<PermanentEmployee> LoadPermamentEmployeefromDatabase()
        {
            for (int i = 0; i < 5; i++)
            {
                PermanentEmployee permanent = employeeFactory.GetPermamentEmploye();

                permanent.ID = "EMP00" + i.ToString();
                permanent.Name = "EMPNAME -" + i.ToString();
                permanent.Age = 30;
                permanent.Desgination = "Designation -" + i.ToString();
                permanent.BasicPay = 1000.60 * (i + 1);

                _PermamentempList.Add(permanent);
            }

            return _PermamentempList;
        }

        private List<TemporaryEmployee> LoadTemporaryEmployeefromDatabase()
        {
            for (int i = 0; i < 5; i++)
            {
                TemporaryEmployee temporary = employeeFactory.GetTempEmploye();

                temporary.ID = "TEMP00" + i.ToString();
                temporary.Name = "TEMPNAME" + i.ToString();
                temporary.Age = 30;
                temporary.Desgination = "Designation" + i.ToString();
                temporary.BasicPay = 1000.60 * (i + 1);

                _TempempList.Add(temporary);
            }

            return _TempempList;
        }

        // Permament Employee Operations.

        public List<PermanentEmployee> GetPermanentEmp()
        {
            return _PermamentempList;
        }

        public PermanentEmployee GetEmployeebyID(string empID)
        {
            var emp = _PermamentempList.Where(x => x.ID == empID).FirstOrDefault();
            return emp;
        }
        public bool AddEmployee(PermanentEmployee permanentEmployee)
        {
            _PermamentempList.Add(permanentEmployee);

            return true;
        }

        public bool RemoveEmployee(string empID)
        {
            _PermamentempList.RemoveAll(x => x.ID == empID);

            return true;
        }

        public List<PermanentEmployee> UpdateEmployee(PermanentEmployee permanentEmployee)
        {
            _PermamentempList.RemoveAll(x => x.ID == permanentEmployee.ID);
            _PermamentempList.Add(permanentEmployee);
            return _PermamentempList;
        }



        // Temporary Employee Operations
        public List<TemporaryEmployee> GetTemporaryEmp()
        {
            return _TempempList;
        }

        public TemporaryEmployee GetTemporaryEmpbyID(string empID)
        {
            var emp = _TempempList.Where(x => x.ID == empID).FirstOrDefault();
            return emp;
        }
        public bool AddTemporaryEmployee(TemporaryEmployee temporaryEmployee)
        {
            _TempempList.Add(temporaryEmployee);

            return true;
        }

        public bool RemoveTemporaryEmployee(string empID)
        {
            _TempempList.RemoveAll(x => x.ID == empID);

            return true;
        }

        public List<TemporaryEmployee> UpdateTemporaryEmployee(TemporaryEmployee temoraryEmployee)
        {
            _TempempList.RemoveAll(x => x.ID == temoraryEmployee.ID);
            _TempempList.Add(temoraryEmployee);
            return _TempempList;
        }
    }
}
