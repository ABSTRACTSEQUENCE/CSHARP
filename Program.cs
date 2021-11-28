
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpSandBox
{
	class Program
	{

		static void print(int[][]arr, int size)
        {
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write($"{arr[i][j]} ");
				}
				Console.WriteLine();
			}
		}
		static void Main(string[] args)
		{
			///-------------------------------------------ДЗ С МАССИВАМИ----------------------------------
			void arr_dz()
			{
				Random rand = new Random();
				int buffer = 0;
				const int size = 5;//размер массива
				int[] arr = new int[size];//объявление массива
				for (int i = 0; i < size; i++)
				{
					arr[i] = rand.Next(0, 10);//Заполнение массива рандомными числами
				}
				Console.Write("Исходный массив: ");
				for (int i = 0; i < size; i++)
				{
					Console.Write($" {arr[i]}");//вывод исходного массива
				}
				for (int i = 0; i < size; i++)
				{
					if (arr[i] == 0)/*простите, я, скорее всего, не так понял задание
									 заменил нули на -1, можно считать это задание не выполненым*/
						arr[i] = -1;
				}
				Console.Write("\nИзменённый массив: ");
				for (int i = 0; i < size; i++)
				{
					Console.Write($" {arr[i]}");//вывод на экран изменённого массива
				}
				Console.WriteLine();//отступ для читабельности
			}
			void arr_dz_2()
			{
				/*Задание номер 2: Преобразовать массив так, чтобы сначала шли отрицательные числа, а потом положительные*/
				Random rand = new Random();
				int buffer = 0;
				const int size = 5;//размер массива
				int[] arr = new int[size];//объявление массива
				for (int i = 0; i < size; i++)
				{
					arr[i] = rand.Next(-10, 10);//Заполнение массива рандомными числами
				}
				Console.Write("Исходный массив: ");
				for (int i = 0; i < size; i++)
				{
					Console.Write($" {arr[i]}");//вывод исходного массива
				}
				for (int i = 0; i < size; i++)
				{
					if (arr[i] < 0)//находим отрицательное значение
						for (int j = 0; j < size; j++)//новый цикл чтобы передвинуть не отрицательные значения на место отрицательных
						{
							if (arr[j] >= 0)//находим не отрицательное значение
							{
								buffer = arr[j];//сохраняем значение в буффер
								arr[j] = arr[i];//меняем отрицательное значение с неотрицательным
								arr[i] = buffer;//подставляем значение в буфере на место отрицательного значения
							}
						}
				}
				Console.Write("\nИзменённый массив: ");
				for (int i = 0; i < size; i++)
				{
					Console.Write($" {arr[i]}");//вывод на экран изменённого массива
				}
				Console.WriteLine();//отступ для читабельности
			}
			void arr_dz_3()
			{
				Random rand = new Random();
				const int size = 5;//размер массива
				int[] arr = new int[size];//объявление массива
				for (int i = 0; i < size; i++)
				{
					arr[i] = rand.Next(-10, 10);//Заполнение массива рандомными числами
				}
				Console.Write("Исходный массив: ");
				for (int i = 0; i < size; i++)
				{
					Console.Write($" {arr[i]}");//вывод исходного массива
				}
				Console.WriteLine("\nВведите число: ");
				int input = Convert.ToInt32(Console.ReadLine());
				int count = 0;
				for (int i = 0; i < size; i++)
				{
					if (input == arr[i])
						count++;
				}

				if (count == 0)
				{ Console.WriteLine($"Числа {input} нет в массиве"); return; }
				Console.WriteLine($"Число {input} встречается в массиве {count} раз(а)");
			}
			void arr_dz_4()
			{
				Random rand = new Random();
				const int size = 5;
				int[][] arr = new int[size] [];
				for(int i = 0; i < arr.Length; i++)
                {
					for(int j = 0; j < size; j++)
                    {
						arr[i] = new int[size];
                    }
                }
				for (int i = 0; i < arr.Length; i++)
				{
					for (int j = 0; j < size; j++)
					{
						arr[i] [j] = rand.Next(0,10);
					}
				}
				Console.WriteLine("Исходный массив: "); print(arr, size);
				Console.WriteLine("Какой столбец нужно заменить?");
				int input1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("С каким столбцом необходимо произвести замену?");
				int input2 = Convert.ToInt32(Console.ReadLine());
				if (input1 > arr.Length || input2 > arr.Length)
				{
					Console.WriteLine($"Ошибка! В массиве всего {arr.Length} столбцов! Запущен процесс самоуничтожения\nДо самоуничтожения осталось:");
					for (int i = 5; i > 0; i--)
					{
						Console.WriteLine(i);

					}
				}
				int[] buffer = new int[size];
				for (int i = 0; i < size; i++)
                {
					buffer[i] = arr[input1 - 1][i];
					arr[input1 - 1][i] = arr[input2 - 1][i];
					arr[input2 - 1][i] = buffer[i];
                }

				print(arr, size);

			}
			arr_dz();//первое задание
			//arr_dz_2();//второе задание
			//arr_dz_3();//третье задание
			//arr_dz_4();//четвёртое задание
		}
		}
	}