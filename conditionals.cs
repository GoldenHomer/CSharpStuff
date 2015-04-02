using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vowels {
	class Program {
		static void Main(string[] args) {
			char letter;
			Console.WriteLine("Enter a letter");
			letter = Convert.ToChar(Console.ReadLine());
			// the case do not need statements if they are the same.
			switch (letter) {
				case 'a';
				case 'e';
				case 'i';
				case 'o';
				case 'u':
					Console.WriteLine("Vowel");
					break;
				default:
					Console.WriteLine("Letter is a consonant.");
					break;
			}
		}
	}
}