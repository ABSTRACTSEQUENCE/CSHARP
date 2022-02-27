
using System.Collections.Generic;
using System;
using System.Linq;
namespace CSharpSandBox
{

	class Program
	{
		static void Main(string[] args)
		{
			Car supra = new Car("Toyota Supra", 2000000, 225);
			Car priora = new Car("LADA priora", 288000, 98);
			Car lamba = new Car("Lamborghini Gallardo", 14500000, 560);
			Car v_2101 = new Car("LADA 2101", 200000, 64);
			List<Car> cars = new List<Car>() { supra, priora, lamba, v_2101 };

///////////////////////////Вывести данные об автомобилях на экран////////////////////////////////
			Console.WriteLine("Вывести данные об автомобилях на экран\n");
			var linq = from i in cars select i;
			foreach (Car i in linq)
			Console.WriteLine(
				$"Марка: {i.brand}\n" +
				$"Мощность: {i.power} л.с.\n" +
				$"Стоимость: {i.price} руб\n");
//////////////////Сделать выборку автомобилей ценой более 1 000 000 руб. Вывести данные на экран.
			Console.WriteLine("Сделать выборку автомобилей ценой более 1 000 000 руб. Вывести данные на экран.\n");
			linq = from i in cars where i.price >= 1000000 select i;
            foreach (Car i in linq)
			Console.WriteLine($"{i.brand}: {i.price}");
		}
	} 
}
