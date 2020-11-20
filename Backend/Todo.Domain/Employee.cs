using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string TypeContract { get; set; }
    }
}
