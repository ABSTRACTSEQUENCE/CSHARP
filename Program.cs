
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpSandBox
{
	class Program
	{
		static void stringdz1()
		{
			//Предоставление пользователю возможности выбрать строки для объединения
			Console.WriteLine("Первая строка: ПЕРВОЕ СЛОВО второе, третье ЧЕТВЁРТОЕ пятое");
			Console.WriteLine("Вторая строка: 1, 2, три, четыре, ПяТь");
			Console.WriteLine("Третья строка: В эТоЙ СтРоКе ПяТь СлОв");
			Console.WriteLine("Какие две строки объединить? (1/2)");
			int input = Convert.ToInt32(Console.ReadLine());//ввод пользователя
			string str1 = null;//объявление первой строки
			if (input == 1)
				str1 = "ПЕРВОЕ СЛОВО второе, третье ЧЕТВЁРТОЕ пятое";//инициализация первой строки
			if (input == 2)
				str1 = "1, 2, три, четыре, ПяТь";//инициализация первой строки
			if (input == 3)
				str1 = "В эТоЙ СтРоКе ПяТь СлОв";//инициализация первой строки
			Console.WriteLine("Какие строки объединить? (2/2)");//объявление второй строки
			input = Convert.ToInt32(Console.ReadLine());
			string str2 = null;
			if (input == 1)
				str2 = "ПЕРВОЕ СЛОВО второе, третье ЧЕТВЁРТОЕ пятое";//инициализация второй строки
			if (input == 2)
				str2 = "1, 2, три, четыре, ПяТь";//инициализация второй строки
			if (input == 3)
				str2 = "В эТоЙ СтРоКе ПяТь СлОв";//инициализация второй строки
			string str3;//объявление "объеденяющей" строки
			if (str1.First().CompareTo(str2.First()) < 0)//если первая буква "меньше" (т.е "первее" по алфавиту),
				str3 = str1 + str2;						//тогда данная строка будет отображена на первом месте
			else str3 = str2 + str1;//в ином случае, другая строка будет на первом месте
			Console.WriteLine(str3);//вывод исходной строки
		}
		static void stringdz2()
        {
			string str = "Какая-то строка";
			Console.WriteLine(str);
			string substr1 = str.Substring(0, 1);
			string substr2 = str.Substring(0, 2);
			string substr3 = str.Substring(0, 3);
			Console.WriteLine(
				$"1 подстрока: {substr1}\n" +
				$"2 подстрока: {substr2}\n" +
				$"3 подстрока: {substr3}\n" +
				$"Сортировка по убыванию: ");
			if (substr1.Length > substr2.Length && substr1.Length > substr3.Length)
			{
				Console.Write(substr1 + " -- ");
				if (substr2.Length > substr3.Length)
					Console.Write(substr2 + " -- " + substr3);
				else
					Console.Write(substr3 + " -- " + substr2);

			}

			else if (substr2.Length > substr1.Length && substr2.Length > substr3.Length)
			{
				Console.Write(substr2 + " -- ");
				if(substr1.Length>substr3.Length)
					Console.Write(substr1 + " -- " + substr3);
				else 
				Console.Write(substr3 + " -- " + substr1);
			}
			else if (substr3.Length > substr1.Length && substr3.Length > substr2.Length)
            {
				Console.Write(substr3 + " -- ");
				if (substr1.Length > substr2.Length)
					Console.Write(substr1 + " -- " + substr2);
				else
					Console.Write(substr2 + " -- " + substr1);
			}
			Console.WriteLine();

		}
		static void stringdz3()
        {
			string str = "eveeen odd eveeen even even even evenee eveeeeen even odddd ev1n ev odd o o o e2en ev"; //odd - 3 элемента(нечётный), even - 4 элемента(чётный)
			string[] strr = str.Split(' '); //методом split отделяем слова по пробелу
			int counter = 0;//счётчик пригодится позже 
			for (int i = 0; i < strr.Length; i++)//считаем чётные строки для выделения памяти
            {
				if (strr[i].Length % 2 == 0)
					counter++; //even
            }
			string[] odd = new string[strr.Length - counter]; //объявляем массив нечётных строк (в counter мы занесли чётные строки, поэтому длина массива = length - counter, т.е. вычитаем из массива чётные строки, остаются нечётные)
			string[] even = new string[counter];//объявляем массив чётных строк
			int even_counter = 0; int odd_counter = 0;//итератор для каждого из массивов
			string[] buffer = new string[strr.Length];//буффер пригодится для того чтобы заносить в него одинаковые элементы
			for (int i = 0; i < strr.Length; i++)//выделение памяти под чётные строки
			{
				if (strr[i].Length % 2 == 0) //если кол-во символов в строке делистя на 2, значит строка чётная
				{
					even[even_counter] = strr[i];//добавляем элемент в массив
					even_counter++;//инкремент итератора для чётных строк
				}
				else 
				{
					odd[odd_counter] = strr[i];//то же самое, но с нечётными
					odd_counter++;
				}
			}
		
			Console.Write("Even: ");
			counter = 0;//обнуление счётчика, т.к. он нам пригодится для другого
			for (int i = 0; i < even.Length; i++)//вывод массива на экран + нахождение одинаковых слов
			{
				Console.Write(even[i] + " ");
				for (int j = 0; j < even.Length; j++)
				{
					if (even[i] == even[j])//если найдено совпадение
					{
						if (i != j)//если это не один и тот же элемент
						{
							buffer[j] = even[j];//сделал присваивание в буффер, чтобы избежать повторного счётчика одних и тех же строк. если сделать через счётчик, то в данном примере выдаст 18, хотя ответ - 8
						}
					}
				}
			}
			for (int i = 0; i < buffer.Length; i++)
			{
				if (buffer[i] != null) counter++;
			}
			Console.WriteLine($"\nОбщих элементов: {counter}");
            for (int i = 0; i < buffer.Length; i++)//зануление буффера
            {
				buffer[i] = null;
            }
			/////////////////////////////////////////Абсолютно то же самое, но с нечётными///////////////////////
			Console.Write("Odd: ");
			counter = 0;
			for (int i = 0; i < odd.Length; i++)
			{
				Console.Write(odd[i] + " ");
				for (int j = 0; j < odd.Length; j++)
				{
					if (odd[i] == odd[j])
					{
						if (i != j)
						{
							buffer[j] = odd[j];
						}
					}
				}
			}
			for (int i = 0; i < buffer.Length; i++)
            {
				if (buffer[i] != null) counter++; 
            }
			Console.WriteLine($"\nОбщих элементов: {counter}");
		}

		static void vedom()
        {
			Console.WriteLine("ФИО");
			string fio = Console.ReadLine();
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("Введите количество предметов");
			int count = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Количество предметов в ведомстве: {count}");
			int[][] vedom = new int[count][];
			string[] subjs = new string[count];
			//Заполняем массив subjs предметами
			Console.WriteLine("------------------------------------------------");
			Console.Write("Введите предметы\n");
            for (int i = 0; i < subjs.Length; i++)
            {
				Console.Write($"({i+1}/{count}) ");
				subjs[i] = Console.ReadLine();
            }
			//узнаём кол-во оценок по каждому из предметов
			Console.WriteLine("------------------------------------------------");
			Console.Write($"Введите кол-во оценок по предмету:\n");
			for (int i = 0; i < subjs.Length; i++)
            {
				Console.Write($"{subjs[i]}\n");
				count = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine($"Количество оценок: {count}");
				vedom[i] = new int[count];//создаём массив с оценками
            }
			Console.WriteLine("------------------------------------------------");
			
			Console.Write($"Введите оценки по предмету \n");
			for (int i = 0; i < subjs.Length; i++)
            {
				Console.Write($"{subjs[i]}\n");

				for (int j = 0; j < vedom[i].Length; j++)
                {
				fail:
					Console.Write($"({j+1} / {vedom[i].Length})\n");
					vedom[i][j] = Convert.ToInt32(Console.ReadLine());
					if (vedom[i][j] > 5)
					{
						Console.WriteLine("Пожалуйста, укажите оценки по пятибальной шкале");
						goto fail;
					}
                }
				Console.WriteLine();
            }
			//вывод на экран
			Console.Write($"ФИО Студента: {fio}\n");
            for (int i = 0; i < subjs.Length; i++)
            {
				Console.Write($"Оценки по предмету {subjs[i]}: ");
                for (int j = 0; j < vedom[i].Length; j++)
                {
					Console.Write($"{vedom[i][j]}, ");
                }
				Console.WriteLine();
            }
			Console.Write(fio);
            for (int i = 0; i < subjs.Length; i++)
            {
				if (vedom[i].Average() > 2.5 && vedom[i].Length >= 2)
					 Console.WriteLine($" аттестован по предмету {subjs[i]}\n");
				else Console.WriteLine($" не аттестован по предмету {subjs[i]}");
			}

        }
		
		static void Main(string[] args)
		{
			//stringdz1(); 
			//stringdz2();
			//stringdz3();
			vedom();
		}

	}
}
