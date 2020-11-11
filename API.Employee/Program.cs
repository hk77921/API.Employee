using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using API.Employee.Models;
using API.Employee.Factory;
namespace API.Employee
{
    public class Program
    {
        public static void Main(string[] args)
        {
             CreateHostBuilder(args).Build().Run();

            //EmployeeFactory employeeFactory = new EmployeeFactory();

            //PermanentEmployee permanent = employeeFactory.GetEmploye();

            //permanent.ID = "EMP001";
            //permanent.Name = "Harendra";
            //permanent.Age = 30;
            //permanent.Desgination = "BOSS";
            //permanent.BasicPay = 16555.60;
            //permanent.Salary = permanent.ComputeSalary(permanent.BasicPay);

          
            
            //TemporaryEmployee temporary = employeeFactory.GetTempEmploye();

            //temporary.ID = "EMP002";
            //temporary.Name = "Kumar";
            //temporary.Age = 30;
            //temporary.Desgination = "BOSS";
            //temporary.BasicPay = 1600.60;
            //temporary.Salary = temporary.ComputeSalary(temporary.BasicPay);



            //Console.WriteLine("-------EMP Details----");

            //Console.WriteLine("ID:->" + permanent.ID);
            //Console.WriteLine("Name:->" + permanent.Name);
            //Console.WriteLine("Age:->" + permanent.Age);
            //Console.WriteLine("Designation:->" + permanent.Desgination);
            //Console.WriteLine("Salary:->" + permanent.Salary);


            //Console.WriteLine("------ TEMP-EMP Details----");

            //Console.WriteLine("ID:->" + temporary.ID);
            //Console.WriteLine("Name:->" + temporary.Name);
            //Console.WriteLine("Age:->" + temporary.Age);
            //Console.WriteLine("Designation:->" + temporary.Desgination);
            //Console.WriteLine("Salary:->" + temporary.Salary);

            //Console.ReadKey();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
