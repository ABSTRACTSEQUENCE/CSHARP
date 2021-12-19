
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpSandBox
{
	class Program
	{
		protected abstract class figure
		{
			protected double a;
			abstract public double S();
			abstract public double P();
			public abstract void print();

		}
		protected class triangle : figure
		{
			protected double b, c;
			public triangle(double a, double b, double c)
			{
				this.a = a;
				this.b = b;
				this.c = c;
			}
			public override double S()
			{
				double p = (a + b + c) / 2;
				double h = (2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / a;

				return 0.5 * (a * h);
			}
			public override double P()
			{
				return a + b + c;
			}
			public override void print()
			{
				Console.WriteLine(($"Периметр треугольника: {P()} \nПлощадь треугольника: {S()}"));
			}
		}
		protected class sq : figure
		{
			public sq(double a)
			{
				this.a = a;
			}
			public override double S()
			{
				return a * a;
			}
			public override double P()
			{
				return a * 4;
			}
			public override void print()
			{
				Console.WriteLine($"Площадь квадрата: {S()}\nПериметр квадрата: {P()}");
			}

		}
		protected class rhomb : figure
		{
			double alpha;
			public rhomb(double a, double alpha)
			{
				this.a = a;
				this.alpha = alpha;
			}
			public override double S()
			{
				alpha *= Math.PI / 180; //Чтобы перевести в радианы, т.к. sin читает только радианы
				return Math.Sin(alpha);
			}
			public override double P()
			{
				return 4 * a;
			}
			public override void print()
			{
				Console.WriteLine($"Площадь ромба: {S()}\nПериметр ромба: {P()}");
			}
		}
		protected class rect : figure
		{
			protected double b;
			public rect(double a, double b)
			{
				this.a = a;
				this.b = b;
			}
			public override double S()
			{
				return a * b;
			}
			public override double P()
			{
				return (a + b) * 2;
			}
			public override void print()
			{
				Console.WriteLine($"Площадь прямоугольника: {S()}\nПериметр прямоугольника: {P()}");
			}
		}
		protected class parall : figure // параллелограмм
		{
			protected double b;
			protected double h;
			public parall(double a, double b, double h)
			{
				this.a = a;
				this.b = b;
				this.h = h;
			}

			public override double P()
			{
				return 2 * (a + b);
			}
			public override double S()
			{
				return a * h;
			}
			public override void print()
			{
				Console.WriteLine($"Площадь параллелограма: {S()}\nПериметр параллелограма: {P()}");
			}
		}
		protected class trapezoid : figure
		{
			protected double b, c, d, h;
			public trapezoid(double a, double b, double c, double d, double h)
			{
				this.a = a;
				this.b = b;
				this.c = c;
				this.d = d;
				this.h = h;
			}

			public override double P()
			{
				return a + b + c + d;
			}
			public override double S()
			{
				return 0.5 * h * (a + b);
			}
			public override void print()
			{
				Console.WriteLine($"Площадь трапеции: {S()}\nПериметр трапеции: {P()}");
			}
		}

		static void Main(string[] args)
		{
			triangle tri = new triangle(11,11,11);
			tri.print();

			Console.WriteLine();

			sq square = new sq(2);
			square.print();


			Console.WriteLine();

			rhomb r = new rhomb(3, 90);
			r.print();
			rect rect = new rect(3, 2);

			Console.WriteLine();
			rect.print();
			Console.WriteLine();

			parall p = new parall(2, 3, 5);
			p.print();

			Console.WriteLine();

			trapezoid t = new trapezoid(2, 4, 6, 8, 5);
			t.print();

			Console.WriteLine("Массив:");
			figure[] fig = { square, t};
		}
	}
}
