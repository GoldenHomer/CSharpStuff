using System.text;

namespace unaryOperation_overload {
	class Program {
		int num;

		public Program(int n){
			num = n;
		}

		public void display() {
			Console.WriteLine("Num is {0}", num);
		}

		public static Program operator ++(){ // ++ applied to only one parameter
			Program newobj = new Program(obj.num + 1);
			obj.num = obj.num + 1;
			return obj;
		}

		static void Main(string[] args){
			Program p1 = new Program(20);
			Program p2 = p1++; // post increment. Ex: p2 = 187, p1 = 188
			Program p3 = ++p1;

			p1.display();
			p2.display();
			p3.display();
		}
	}
}

// Classes are reference data type