using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessSpecifier {
	class Program {
		// protected int num; // private is default accesser.

		int num;
		static int cnt;

		public static void add() {
			cnt++;
		}
		public void increment() {
			num++;
			cnt++;// num would have to be static as well to compile without error.
		}

		public void display() {
			Console.WriteLine("num = {0} cnt = {1}", num, cnt);
		}

	}

	class Test:Program {
		static void Main (string[] args) {
			Program p = new Program();
			Test t = new Test();
			p.num; // Cannot do this since num is protected. Limited to class Program.
			t.num; // Valid since Test inherits from Program class.

			Program.add();
		}
	}
}

/* 
Two types of variables in a class: instance and static.
static variables define constants, can be initialized outside member function or class definition
and have only one copy of the variable for all the objects of a class.
*/

------