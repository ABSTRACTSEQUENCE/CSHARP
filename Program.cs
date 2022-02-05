
using System;
namespace CSharpSandBox
{
	class Program
	{
		static void Main(string[] args)
		{
			Tree<string> tree = new Tree<string>();
			tree.Add("ыыыы");
			tree.Add("аааа");
			tree.Add("абвгд");
			tree.Add(" ");
			tree.print();
			
		}
	}
}
