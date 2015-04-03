//I thought C# might have some reverse method like JavaScript!

namespace Palindrome {
	class Program {
		static void Main(string[] args) {
			char[] arr;
			int i=0,j,flag=0;

			Console.WriteLine("Enter a string!");
			arr = Console.ReadLine().ToCharArray();

			j = arr.Length - 1;

			while (i <=j) {
				if (arr[i] == arr[j]) {
					i++;
					j--;
				}

				else {
					flag = 1;
					break;
				}
			}

			if (flag == 0) {
				Console.WriteLine("Entered string is a palindrome.");
			}

			else {
				Console.WriteLine("Bummer - string is not a palindrome.");
			}
		}
	}
}