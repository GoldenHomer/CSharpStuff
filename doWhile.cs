using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Do_while {
	class Program {
		static void Main(string[] args) {
			int n1, n2, r, menuchoice;
			char yesNoChoice;

			do {
				Console.WriteLine("Enter first number");
				n1 = convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter second number");
				n2 = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine("1: +");
				Console.WriteLine("2: -");
				Console.WriteLine("3: *");
				Console.WriteLine("4: /");
				Console.WriteLine("5: %");
				Console.WriteLine("6: Exit");
				Console.WriteLine("Enter a choice (1-6)");
				menuchoice = Convert.ToInt32(Console.ReadLine());

				if(menuchoice == 6) {
					break;
				}

				else {
					switch(menuchoice) {
						case 1:
							r = n1 + n2;
							Console.WriteLine("Addition is: {0}", r);
							break;

						case 2:
							r = n1 - n2;
							Console.WriteLine("Difference is: {0}", r);
							break;

						case 3:
							r = n1*n2;
							Console.WriteLine("Product is: {0}", r);
							break;

						case 4:
							r = n1/n2; // n2 != 0
							Console.WriteLine("Division is: {0}", r);
							break;

						case 5:
							r = n1%n2;
							Console.WriteLine("Remainder is: {0}", r);
							break;
						default:
							Console.WriteLine("Invalid choice");
							break;
					}
				}

				Console.WriteLine("Do you want to continue?");
				yesNoChoice = Convert.ToChar(Console.ReadLine());
			} while (yesNoChoice == 'y' || yesNoChoice == 'Y'); // Let's not forget the while loop.
		}
	}
}