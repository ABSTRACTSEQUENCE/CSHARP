
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpSandBox
{
	struct car
	{
		private double clearance;
		private double eng_vol;//объём двигателя
		private double eng_power;//мощность двигателя
		private double wheel_d;
		private int color_id;
		private string[] color;
		private string[] shifter;
		private int shifter_id;
		public void print()
		{
			if (eng_vol == 0) eng_vol = 3.0;//типа конструктор по умолчанию, простите за костыль, т.к. в C# нельзя переопределить конструктор по умолчанию, я решил сделать так
			if (clearance == 0) clearance = 130;
			if (eng_power == 0) eng_power = 225;
			if (wheel_d == 0) wheel_d = 15;
			if (color_id == 0)
			{
				color = new string[3] { "Красный", "Зелёный", "Жёлтый" };
				Random r = new Random();
				color_id = r.Next(0, 3);
			}
			if (shifter_id == 0)
			{
				Random r = new Random();
				shifter_id = r.Next(0, 2);
				shifter = new string[2] { "Механическая", "Автоматическая" };
			}
			Console.WriteLine(
				$"Высота подвески(мм): {clearance}\n" +
				$"Объём двигателя(л): {eng_vol}\n" +
				$"Мощность двигателя(л.с.) {eng_power}\n" +
				$"Диаметр колеса: { wheel_d} \n" +
				$"Цвет: {color[color_id]}\n" +
				$"Тип коробки передач: {shifter[shifter_id]}");
		}
		public double getset_clearence
		{
			get { return clearance; }
			set { clearance = value; }
		}
		public double getset_eng_vol
		{
			get { return eng_vol; }
			set { eng_vol = value; }
		}
		public double getset_eng_power
		{
			get { return eng_power; }
			set { eng_power = value; }
		}
		public string getset_color
		{
			get { return color[color_id]; }
			set { color[color_id] = value; }
		}
		public double getset_wheel_d
		{
			get { return wheel_d; }
			set { wheel_d = value; }
		}
		public string getset_shifter
		{
			get { return shifter[shifter_id]; }
			set { shifter[shifter_id] = value; }
		}
	}
	partial class carr
	{
		private string name;
		private double clearance;
		private double eng_vol;//объём двигателя
		private double eng_power;//мощность двигателя
		private static double wheel_d;
		private string color;
		private static string shifter;
		public carr(string name, double clearence, double eng_vol, double eng_power, string color)
		{
			this.name = name;
			this.clearance = clearence; 
			this.eng_power = eng_power;
			this.eng_vol = eng_vol;
			this.color = color;
		}
        public carr()
        {
			name = "Машина без названия";
			clearance = 130;
			eng_power = 225;
			eng_vol = 3.0;
			color = "Белый";
			shifter = "Автоматическая";
        }
		partial void partial_method();
		public void obvertka() { partial_method(); } //для того чтобы вызвать частичный метод, т.к. его нельзя сделать публичным
		static carr()
        {
			shifter = "Механическая";
			wheel_d = 15;
        }
		public void print()
		{
			Console.WriteLine(
				$"\n--------------------------------------\n" +
				$"Название автомобиля: {name}\n" +
				$"Высота подвески(мм): {clearance}\n" +
				$"Объём двигателя(л): {eng_vol}\n" +
				$"Мощность двигателя(л.с.) {eng_power}\n" +
				$"Диаметр колеса: { wheel_d} \n" +
				$"Цвет: {color}\n" +
				$"Тип коробки передач: {shifter}");
		}
		public double getset_clearence
		{
			get { return clearance; }
			set { clearance = value; }
		}
		public double getset_eng_vol
		{
			get { return eng_vol; }
			set { eng_vol = value; }
		}
		public double getset_eng_power
		{
			get { return eng_power; }
			set { eng_power = value; }
		}
		public string getset_color
		{
			get { return color; }
			set { color = value; }
		}
		public double getset_wheel_d
		{
			get { return wheel_d; }
			set { wheel_d = value; }
		}
		public string getset_shifter
		{
			get { return shifter; }
			set { shifter = value; }
		}
		public string getset_name {
			get { return name; }
			set { name = value; }
		}
	}
	class Program
	{
		static void structs()
        {
			car SUPRA = new car();
			Console.WriteLine("Супра до тюнинга: ");
			SUPRA.print();
			SUPRA.getset_clearence = 20;
			SUPRA.getset_color = "Фиолетовый";
			SUPRA.getset_shifter = "Автомат";
			SUPRA.getset_eng_vol = 4;
			SUPRA.getset_eng_power = 300;
			Console.WriteLine("\nСупра после тюнинга: ");
			SUPRA.print();
        }
		static void Main(string[] args)
		{
			//structs(); //Структура
			//Класс:
			carr supra = new carr();
			supra.getset_name = "Toyota Supra";
			supra.print();
			supra.getset_clearence = 50; supra.getset_shifter = "Автоматическая";
			supra.print();
			carr VAZ_2107 = new carr("ВАЗ 2107",50,1.5,8,"Чёрный");
			VAZ_2107.print();
			VAZ_2107.getset_shifter = "Механическая";
			VAZ_2107.print();
			carr[] car_arr = new carr[5];
			Console.WriteLine("Машины из массива: ");
			for (int i = 0; i < car_arr.Length; i++)
			{
				car_arr[i] = new carr();
				car_arr[i].print();
			}
			supra.obvertka();
		}
	}
}
