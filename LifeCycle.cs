using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifecycleObject // the life cycle of an object
{
	class Program
	{
        public Program()
        {
            Console.WriteLine("Constructor called");
        }

        ~Program()
        {
            Console.WriteLine("Destructor called");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main started");
            Program p1 = new Program();
            {
                Console.WriteLine("Block started");
                Program p2 = new Program();
                Console.WriteLine("block ended");
            }

            Console.WriteLine("Main ended")
        }
	}
}
