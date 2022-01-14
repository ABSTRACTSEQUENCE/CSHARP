
using System;
namespace CSharpSandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Money cash = new Money(100);
            Console.Write($"У вас есть "); cash.print();
            cash = cash - 100.201M;
            cash.print();
            cash++;
            cash.print();
            Money dengi = new Money(5.5);
            Console.Write(dengi == cash);
            
        }
    }
}
