using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Employee
    {
        protected int eid;
        protected string name;
    }

    class Parttime:Employee
    {
        public int noh;
        static void Main(string[] args)
        {
            Parttime p = new Parttime();
            p.noh=5;
            p.eid = 002;
            p.name="Uncle Buck"
        }
    }

    class fulltime:Employee
    {
        public int shift;
    }
}
