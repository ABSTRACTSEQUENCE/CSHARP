
using System;
namespace CSharpSandBox
{
    public interface IDrawable
    {
        void draw();
    }
    public interface IPrintable
    {
        void print();
    }
    class Program
    {
        protected abstract class figure
        {
            protected double a;
            abstract public double S();
            abstract public double P();
            public abstract void print();
           

        }
        protected class triangle : figure, IPrintable
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
            public void draw()
            {
                for (int i = 0; i < a; i++)
                {
                    Console.Write("* ");

                    for (int j = 0; j < b; j++)
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
        }
        protected class sq : figure, IDrawable, IPrintable
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
            public void draw()
            {
                for (int j = 0; j < a; j++)
                {
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            public override void print()
            {
                Console.WriteLine($"Площадь квадрата: {S()}\nПериметр квадрата: {P()}");
                draw();
            }

        }
        protected class rhomb : figure, IPrintable
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
        protected class rect : figure, IPrintable, IDrawable
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
            public void draw()
            {
                for (int j = 0; j < b; j++)
                {
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            public override void print()
            {
                Console.WriteLine($"Площадь прямоугольника: {S()}\nПериметр прямоугольника: {P()}");
                draw();
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
        protected class scene
        {
            public figure[] figures;
            public scene(figure[] figures)
            {
                this.figures = figures;
            }
            public void draw_scene()
            {
                for(int i = 0; i < figures.Length; i++)
                {
                    figures[i].print();
                }
            }
        }

        static void Main(string[] args)
        {
            triangle tri = new triangle(11, 11, 11);
            tri.print();

            Console.WriteLine();

            sq square = new sq(4);
            square.print();
            square.draw();

            Console.WriteLine();

            rhomb r = new rhomb(3, 90);
            r.print();
            rect rect = new rect(3, 2);

            Console.WriteLine();
            rect.print();
            rect.draw();
            Console.WriteLine();

            parall p = new parall(2, 3, 5);
            p.print();

            Console.WriteLine();

            trapezoid t = new trapezoid(2, 4, 6, 8, 5);
            t.print();
            Console.WriteLine("---------------------------------------------------");
            figure[] figures = new figure[3];
            figures[0] = square;
            figures[1] = tri;
            figures[2] = rect;
            scene sc = new scene(figures);
            sc.draw_scene();
        }
    }
}
