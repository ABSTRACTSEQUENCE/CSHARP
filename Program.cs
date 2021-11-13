using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpSandBox
{
	class Program { 
		static void Main(string[] args)
		{
			double convert(int Input,double Sec) {
			if (Input == 1) return Sec / 3600; //To Hours
			else if (Input == 2) return Sec / 60; //To minutes
			else if (Input == 3) return Sec; //To seconds
			else{
				Console.WriteLine("Wrong input");
				return 0;
			}
		}
			void convert_menu()
            {
				Console.WriteLine("Awaiting input (sec)...");
				double sec = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine(
					"Press 1 to transfer {0} seconds to hours, \n" +
					"2 to transfer to minutes, \n" +
					"3 to transfer to seconds", sec
					);
				int input = Convert.ToInt32(Console.ReadLine());

				Console.Write("{0} seconds is " + convert(input, sec), sec);
				if (input == 1) Console.WriteLine(" hour(s)");
				else if (input == 2) Console.WriteLine(" minute(s)");
				else if (input == 3) Console.WriteLine(" second(s) (obviously)");
			}
			void llength()
            {
				Console.WriteLine("\nAwaiting input (length)...");
				double length = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine(length / (2 * 3.14));
            }
			//int sum(int a) {return не могу сделать это задание, простите(}
			//float foo = 1;
			//foo /= 3;
			//Console.WriteLine("foo = {0}", foo);
			//foo *= 3;
			//Console.WriteLine("foo = {0}", foo);

			////////////////////////////////////////////////////////////////////////
			convert_menu();
			llength();
			
			
		}
	}
}
