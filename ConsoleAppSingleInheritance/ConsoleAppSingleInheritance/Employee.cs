using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleInheritance
{
    internal class Employee
    {
        private double salary;

        internal double Salary
        {
            get { return this.salary; }
            set
            {
                if (value >= 0 && value <= 400)
                    this.salary = value;
                else
                    this.salary = -1;
            }
        }

        public Employee(double salary)
        {
            this.Salary = salary;
        }

    }
}
