using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpSandBox
{
	class Program
	{
		static void Main(string[] args)
		{
			bool first = true;
			int mult = 1;
			void factor(int value) {
				if (value != 1)
				{
					mult++;
					while (value % mult == 0)
					{
						if (first) { Console.Write($"{value} = {mult}"); first = false; }
						else Console.Write($"*{mult}");
						value /= mult;
					}
					factor(value);
				}
				Console.WriteLine();
			}
			void SqEq(double a, double b, double c)
			{
				Console.WriteLine($"{a}x2 + {b}x + c = 0");
				double d = (b * b) - 4 * a * c;
				if (d == 0) Console.WriteLine(-b / 2 * a);
				else if (d > 0)
				{
					double x1 = (-b + Math.Sqrt(d)) / (2 * a);
					double x2 = (-b - Math.Sqrt(d)) / (2 * a);
					Console.WriteLine($"x1= {x1}" +
									$"\nx2 = {x2};");
				}
				else if (d < 0) Console.WriteLine("Корней уравненея нет");
			}
			
			//SqEq(1,100,3); //квадратное уравнение
			//factor(100);   //разложение на множители
		}
	}
}