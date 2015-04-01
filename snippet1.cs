// Post increment
int x = 5;
x += 10;
x = x++; // x = 15 because x is assigned before the increment is done.

//Pre increment
int y = 7;
y += 3;
y = --y; // y = 9.

-----------
using System.Text;

namespace Sum_Average {
	class Program {
		static void Main(string[] args){
			int n1, n2, n3, n4, n5, sum, avg;
			Console.WriteLine("Enter number");

			n1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter first number");

			n2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second number");

			n3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter third number");

			n4 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter fourth number");

			n5 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter fifth number");

			sum = n1 + n2 + n3 + n4 + n5;
			avg = sum/5;

			Console.WriteLine("Sum is: {0}", sum);
			Console.WriteLine("Average is: {0}", avg);
		}
	}
}