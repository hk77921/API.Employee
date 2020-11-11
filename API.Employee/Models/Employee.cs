using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Employee.Models
{
    public abstract class Employee
    {
        [Required]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Desgination { get; set; }
        [Required]
        public double BasicPay { get; set; }
        
        public abstract double Salary { get; }
    }
}
