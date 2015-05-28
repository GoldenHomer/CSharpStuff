using System;
using System.Collections;
using System.Linq;
using System.text;

namespace MultiArray {
	class Program {
		static void Main(string[] args) {
			int [,] arr = new int[3,3] // array using cartesian coordinates equal to a 3x3 matrix.
			int rowsum, totsum = 0;
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					Console.WriteLine("Enter a number");
					arr[i,j] = Convert.ToInt32(Console.ReadLine());
				}
			}

			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					Console.WriteLine("{0} ", arr[i,j]);
					rowsum = rowsum + arr[i,j];
				}

				Console.WriteLine("Row sum is : {0}", rowsum);
				totsum = totsum + rowsum;
				rowsum = 0; // After each row, initialize the sum as zero. Without this, the second row's sum includes the first row and the third includes both 2nd and 1st.
				Console.WriteLine();
			}
			Console.WriteLine("Total sum is: {0} ", totsum);
		}
	}
}

// Realize that arrays in C# must be of the same type. Array lists are the indiscriminate ones.
