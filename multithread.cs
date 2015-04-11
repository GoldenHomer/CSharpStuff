using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading {
	class Program {
		public void display() {
			for(int i = 1; i <= 10; i++) {
				Console.WriteLine("Good afternoon {0}", i);
				Thread.Sleep(1000); // Pausing the thread.
			}
		}

		public void display2() {
			for (int i=1; i<=20; i++) {
				Console.WriteLine("Good Morning {0}", i);
			}
		}

		static void Main(string[] args) {

			Program p = new Program();

			ThreadStart ts1 = new ThreadStart(p.display1);
			Thread th1 = new Thread(ts1);

			ThreadStart ts2 = new ThreadStart(p.display2);
			Thread th2 = new Thread(ts2);

			th1.Start(); // Executing a thread.
			th2.Start();
		}
	}
}

// The threads should run parallel. The output doesn't necessarily need to be the same for every runtime.
// The life cycle of a thread isn't too complicated.