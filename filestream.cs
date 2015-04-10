using System;
using System.Collections. Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileIO {
	class Program {

		public void ReadDate(){
			FileStream fs = new FileStream(@"biggulp.txt", FileMode.open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);

			string str = sr.ReadLine();
			Console.WriteLine(str);
			sr.Close();
			fs.Close();
			}

		public void WriteDate() {
			FileStream fs = new FileStream(@"stanford.txt", FileMode.Create, FileAccess.Write); // Local method inside writedate()
			StreamWriter sw = new StreamWriter(fs);
			sw.Write("I wasn't cheating! I was just being intelligent and successful!");
			sw.Flush(); // How appropriate
			sw.Close();
			fs.Close();
		}

		static void Main(string[] args) {
			Program p = new Program();
			p.ReadDate();
		}
	}
}

// Similar methods for reading and writing binary files and directories.