using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpEmployeePayRoll
{
   public class Employee
    {


        public int id { get; set; }
        public string name { get; set; }

        public string salary { get; set; }

        public Employee(string name,string salary)
        {
          
            this.salary = salary;
            this.name = name;
        }

    }
}
