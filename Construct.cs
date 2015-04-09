using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Construct // Two types of contructors, static and instance
{
    class Program
    {
        int num; // instance variable
        static int cnt;

        Program()
        {
            num = 100;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("{0}, p.num");

            Program p2 = new Program();
            Console.WriteLine("{0}", p2.num);
        }
    }
}