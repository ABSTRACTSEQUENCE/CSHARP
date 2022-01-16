
using System;
namespace CSharpSandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Money cash = new Money(100);
            Console.Write($"У вас есть ");Console.WriteLine(cash.ToString());
            try
            {
                cash -= 1000.5M;
                if (cash < 0)
                    throw new Bankrupt();
            }
            catch(Bankrupt b)
            {
                Console.WriteLine(b.msg);
                Console.WriteLine(b.time);

            }
            Console.WriteLine(cash.ToString());
            
                    
        }
    }
}
