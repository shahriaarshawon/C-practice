using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSampleClass
{
    class Student
    {
        private int id;
        private string name;
        private double cgpa;

        public int GetId()
        {
            return this.id;
        }
        //s.id = 100//s.SetId(100)
        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetCgpa()
        {
            return this.cgpa;
        }

        public void SetCgpa(double cgpa)
        {
            if (cgpa >= 0 && cgpa <= 4.00)
                this.cgpa = cgpa;
            else
                this.cgpa = 0.0;

        }

        public Student()
        {

        }

        public Student(int id, string name, double cgpa)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetCgpa(cgpa);
        }

        public void ShowInformation()
        {
            Console.WriteLine("{0}", this.GetId());
            Console.WriteLine("{0}", this.GetName());
            Console.WriteLine("{0}\n", this.GetCgpa());
        }



        //set method means write,get means read 
    }
}
