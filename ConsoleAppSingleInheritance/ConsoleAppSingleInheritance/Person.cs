using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleInheritance
{
    class Person
    {
        private int id;
        private string name;
        private string bloodGroup;

        internal int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal string BloodGroup
        {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }

        internal Person(int z)
        {
            Console.WriteLine();
        }
    }
}
