using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanInfoApp
{
    struct OurDate
    {
        public byte date;
        public byte month;
        public int year;

        public void PrintDateOfBirth()
        {
            Console.Write("Date of Birth: {0}", this.date);
            Console.Write("/ {0}", this.month);
            Console.WriteLine("/ {0}", this.year);

        }
    }

    class Human
    {
        private int id;
        private string name;
        private OurDate dateOfBirth;
        private byte bph;
        private byte bpl;
        private string gender;
        private byte heartRate;

        
        public int GetId()
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

        public OurDate GetDateOfBirth()
        {
            return this.dateOfBirth;
        }

        public void SetDateOfBirth(OurDate dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public byte GetBph()
        {
            return this.bph;
        }
        
        public void SetBph(byte bph)
        {
            this.bph = bph;
        }

        public byte GetBpl()
        {
            return this.bpl;
        }
        
        public void SetBpl(byte bpl)
        {
            this.bpl = bpl;
        }

        public string GetGender()
        {
            return this.gender;
        }

        public void SetGender(string gender)
        {
            this.gender = gender;
        }

        public byte GetHeartRate()
        {
            return this.heartRate;
        }
        
        public void SetHeartRate(byte heartRate)
        {
            this.heartRate = heartRate;
        }



        

        public Human()
        {

        }

        public Human(int id, string name, OurDate dateOfBirth, byte bph, byte bpl, string gender, byte heartRate)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetDateOfBirth(dateOfBirth);
            this.SetBph(bph);
            this.SetBpl(bpl);
            this.SetGender(gender);
            this.SetHeartRate(heartRate);
        }

        public void HeartRate(byte heartRate)
        {
            if (heartRate >= 70 && heartRate <= 90)
            {
                Console.WriteLine("{0}", " healthy ");
            }
            else 
            {
                Console.WriteLine("{0}", " Unhealthy ");
            }
        }


        public void ShowInformation()
        {
            Console.WriteLine("{0}", this.GetId());
            Console.WriteLine("{0}", this.GetName());
            Console.WriteLine("{0}", this.GetDateOfBirth());
            Console.WriteLine("{0}", this.GetBph());
            Console.WriteLine("{0}", this.GetBpl());
            Console.WriteLine("{0}", this.GetGender());
            Console.WriteLine("{0}\n", this.GetHeartRate());
        }
    }
}
