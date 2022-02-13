

using System;
namespace CSharpSandBox
{

	class Program
	{
		static void Main(string[] args)
		{
			Money usd = new Money("usd", 1);
			Money eur = new Money("eur", 30);
			Money rub = new Money("rub", 100);
			Money.MoneyConvertDel del = null;
			del += delegate (double amount, string code) // rub
			{
				switch (code.ToLower())
				{
					case "rub":
						return amount;
					case "usd":
						return amount * 0.013336;
					case "eur":
						return amount * 0.011715;
					default: return 0;

				}
			};
			del += delegate (double amount, string code) // usd
			{
				switch (code.ToLower())
				{
					case "rub":
						return amount * 74;
					case "usd":
						return amount;
					case "eur":
						return amount * 0.88106;
					default: return 0;

				}
			};
			del += delegate (double amount, string code) // eur
			{
				switch (code.ToLower())
				{
					case "rub":
						return amount * 85.36;
					case "usd":
						return amount * 1.14;
					case "eur":
						return amount;
					default: return 0;

				}

				Console.WriteLine(rub.Call(del, "rub"));
			};
			del += (double amount, string code) =>
			{
				 switch (code.ToLower())
				 {
					 case "rub":
						 return amount * 142736.01;
					 case "usd":
						 return amount * 1858.70;
					 case "eur":
						 return amount * 1637.58;
					 default: return 0;
				 }
			};
			Console.WriteLine(usd.Call(del, "usd"));
			Console.WriteLine(del.GetInvocationList()[3].DynamicInvoke(1, "usd"));//Конвертация валюты в золото
		}
	} 
}
