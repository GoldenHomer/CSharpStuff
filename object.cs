using System;
using System.Collections.Generic;
using System.Linq;
using System.text;

namespace Object1 {

	class Employee {
		string name, email;
		int phone;

		public void Assign() { // access level, methods with void will not return anything, name
			Console.WriteLine("Enter a name");
			name = Console.ReadLine();

			Console.WriteLine("Enter email address");
			email = Console.ReadLine();

			Console.WriteLine("Enter phone number");
			phone = Console.ToInt32(Console.ReadLine());
		}

		public void print() {
			Console.WriteLine("{0}", name);
			Console.WriteLine("{0}", email);
			Console.WriteLine("{0}", phone);
		}

		static void Main(string[] args) {
			Employee Sam = new Employee();
			Sam.Assign();
			Sam.print();

			Employee Pontius = new Employee();
			Pontius.Assign();
			Pontius.print();
			
		// 	Pontius.name = "Pontius P.";
		// 	Pontius.email = "notjenny@netscape.com";
		// 	Pontius.phone = "8675309";
		// }
	}
}