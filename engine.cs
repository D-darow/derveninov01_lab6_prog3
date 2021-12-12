using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_lab6_prog3
{
    public class engine
    {
        private int hs_power; // Лошадиные силы
        private int fuel; // Род топлива
        private int num_of_cylinders; // Количество цилиндров (от 2 до 16)
		// Конструтор по умолчанию
		public engine()
		{
			hs_power = 0;
			fuel = 1;
			num_of_cylinders = 2;
		}
		// Конструктор
		public engine(int power, int fuel_in, int cylinders)
		{
			hs_power = power;
			fuel = fuel_in;
			num_of_cylinders = cylinders;
		}
		// Установка лошадиных сил
		public void set_hs_power(int hs_power_in)
		{
			hs_power = hs_power_in;
		}
		// Получение лошадиных сил
		public int get_hs_power()
		{
			return hs_power;
		}
		// Установка рода топлива
		public void set_fuel(int fuel_in)
		{
			fuel = fuel_in;
		}
		// Получение рода топлива
		public int get_fuel()
		{
			return fuel;
		}
		// Установка количества цилиндров
		public void set_num_of_cylinders(int num_of_cylinders_in)
		{
			num_of_cylinders = num_of_cylinders_in;
		}
		// Получение количества цилиндров
		public int get_num_of_cylinders()
		{
			return num_of_cylinders;
		}
		// Ввод информации о двигателе
		public void input_engine()
		{
			int flag = 0;
			do
			{
				if (flag == 0) Console.WriteLine("Введите кол-во лошадиных сил:");
				if (flag == 1) Console.WriteLine("Ошибка. Введите кол-во лошадиных сил:");
				hs_power = Convert.ToInt32(Console.ReadLine());
				flag = 1;
			} while (hs_power < 0);
			flag = 0;
			do
			{
				if (flag == 0) Console.WriteLine("Выберите род топлива (1 - бензин, 2 - дизель): ");
				if (flag == 1) Console.WriteLine("Ошибка. Выберите род топлива (1 - бензин, 2 - дизель): ");
				fuel = Convert.ToInt32(Console.ReadLine());
				flag = 1;
			} while (fuel < 1 || fuel > 2);
			flag = 0;
			do
			{
				if (flag == 0) Console.WriteLine("Введите кол-во цилиндров двигателя (2 - 16): ");
				if (flag == 1) Console.WriteLine("Ошибка. Введите кол-во цилиндров двигателя (2 - 16): ");
				num_of_cylinders = Convert.ToInt32(Console.ReadLine());
				flag = 1;
			} while (num_of_cylinders < 2 || num_of_cylinders > 16);
		}
		// Вывод информации о двигателе
		public void print_engine()
		{
			Console.WriteLine("\nКол-во лошадиных сил: ");
			Console.WriteLine(hs_power);
			Console.WriteLine("Род топлива: ");
			if (fuel == 1)
			{
				Console.WriteLine("Бензин");
			}
			else
			{
				Console.WriteLine("Дизель");
			}
			Console.WriteLine("Количество цилиндров:");
			Console.WriteLine(num_of_cylinders);
		}
	}
}
