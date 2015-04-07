using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessSpecifier {
	class Program {
		protected int num; // private is default accesser.
	}

	class Test:Program {
		static void Main (string[] args) {
			Program p = new Program();
			Test t = new Test();
			p.num; // Cannot do this since num is protected. Limited to class Program.
			t.num; // Valid since Test inherits from Program class.
		}
	}
}