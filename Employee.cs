using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            Name = "Brown";
            FirstName = "Roxy";






            //dtyutyutru
            Salary = 5000;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("I'm working");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }

    }
}
