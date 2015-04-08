using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumD {
	class Program {
		enum days{mon = 1, tue, wed, thur, fri, sat, sun} // assign value names to constant integrals.

		static void Main(string[] arg) {
			Console.WriteLine("{0}", (int)days.mon);
			Console.WriteLine("{0}", (int)days.tue);
			Console.WriteLine("{0}", (int)days.wed);
			Console.WriteLine("{0}", (int)days.thur);
			Console.WriteLine("{0}", (int)days.fri);
			Console.WriteLine("{0}", (int)days.sat);
			Console.WriteLine("{0}", (int)days.sun);
		}
	}
}