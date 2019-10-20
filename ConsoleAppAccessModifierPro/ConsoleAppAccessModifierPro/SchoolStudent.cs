using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccessModifierPro
{
    class SchoolStudent : Student
    {
        public int p;
        private int q;
        protected int r;
        internal int s;
        protected internal int t;

        public void M2()
        {
            //this.
            //Student e = new Student();
        }
    }
}
