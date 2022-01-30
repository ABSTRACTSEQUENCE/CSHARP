
using System;
namespace CSharpSandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(5);
            tree.Add(6);
            tree.Add(100);
            tree.Add(1);
            tree.search(100);
            Console.WriteLine(tree.bool_search(1));

            tree.print();
        }
    }
}
