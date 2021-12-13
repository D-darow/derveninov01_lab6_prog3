using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_lab6_prog3
{
    public class engine
    {
		// Лошадиные силы
		private int hs_power { get; set; }
		// Род топлива
		private int fuel 
		{ 
			get { return fuel; }
			set 
			{
				if (value < 1 || value > 2)
					throw new ArgumentOutOfRangeException($"{nameof(value)} должен быть между 1 и 2");
				fuel = value;
			}
		}
		// Количество цилиндров (от 2 до 16)
		private int num_of_cylinders
        {
			get { return num_of_cylinders; }
			set
            {
				if (value < 2 || value > 16)
					throw new ArgumentOutOfRangeException($"{nameof(value)} должен быть между 2 и 16");
				num_of_cylinders = value;
            }
        }
		// Конструтор по умолчанию
		public engine()
		{
			hs_power = 0;
			fuel = 1;
			num_of_cylinders = 2;
		}
		// Конструктор
		public engine(int hs_power, int fuel, int num_of_cylinders)
		{
			this.hs_power = hs_power;
			this.fuel = fuel;
			this.num_of_cylinders = num_of_cylinders;
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
