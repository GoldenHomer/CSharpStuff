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

        Program(int n)
        {
            num = n;
        }

        ~Program() // Destructor
        {
            Console.WriteLine("Destructor called");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("{0}, p.num");

            Program p2 = new Program();
            Console.WriteLine("{0}", p2.num);

            Program p3 = new Program(2);
            Console.WriteLine("{0}", p3.num); // Should return 2
        }
    }
}