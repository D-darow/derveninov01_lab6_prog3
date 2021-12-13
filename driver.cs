using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_lab6_prog3
{
    public struct driver
    {
		// Имя
		private string name { get; init; }
		// Фамилия
		private string surname { get; init; }
		// Номер телефона
		private string phone_number { get; init; }

		// Конструктор
		public driver(string name, string surname, string phone_number)
		{
			this.name = name;
			this.surname = surname;
			this.phone_number = phone_number;
		}
		// Вывод информации о водителе
		public void print_driver()
		{
			Console.WriteLine("\nИмя водителя: ");
			Console.WriteLine(name);
			Console.WriteLine("Фамилия водителя: ");
			Console.WriteLine(surname);
			Console.WriteLine("Номер телефона водителя: ");
			Console.WriteLine(phone_number);
		}
	}
}
