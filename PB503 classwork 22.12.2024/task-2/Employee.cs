using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_classwork_22._12._2024.task_2
{
    public class Employee
    {
        private static byte _id;
        public byte Id { get;set; }
        public string Name {  get; set; }
        public string Departament { get; set; } 
        public double Salary { get; set; }
        public double Experience { get; set; }

        public Employee()
        {
            Id = ++_id;
        }

    }
}
