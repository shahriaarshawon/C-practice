using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationManagement
{
    struct OurDateType
    {
        private byte day;
        private string month;
        private int year;

        public OurDateType(byte day, string month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void ShowDate()
        {
            Console.WriteLine("Date Of Birth: {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }
    class Student
    {

        private int id;
        private string name;
        private double cgpa;
        private OurDateType dateOfBirth;

        public int Id 
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Cgpa
        {
            get { return this.cgpa; }
            set 
            {
                if (value >= 0 && value <= 4)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }
        }

        public OurDateType DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }


        /*public int GetId()
        {
            return this.id;
        }

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
            this.cgpa = cgpa;
        }

        public OurDateType GetDateOfBirth()
        {
            return this.dateOfBirth;
        }

        public void SetDateOfBirth(OurDateType dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }*/

        public Student(int id, string name, double cgpa, OurDateType dateOfBirth)
        {
            this.Id = id; //this.SetId(id);
            this.Name = name; //this.SetName(name);
            this.Cgpa = cgpa; //this.SetCgpa(cgpa);
            this.DateOfBirth = dateOfBirth; //this.SetDateOfBirth(dateOfBirth);
        }

        public void ShowInformation()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Cgpa: {0}", this.Cgpa);
            this.DateOfBirth.ShowDate(); //this.GetDateOfBirth().ShowDate();
            Console.WriteLine();
        }

    }
}
