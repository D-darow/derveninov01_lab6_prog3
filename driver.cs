using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_lab6_prog3
{
    public class driver
    {
		// Имя
		private string name { get; set; }
		// Фамилия
		private string surname { get; set; }
		// Номер телефона
		private string phone_number { get; set; }

		// Конструктор по умолчанию
		public driver()
		{
			name = null;
			surname = null;
			phone_number = null;
		}
		// Конструктор
		public driver(string name, string surname, string phone_number)
		{
			this.name = name;
			this.surname = surname;
			this.phone_number = phone_number;
		}
		// Ввод информации о водителе
		public void input_driver()
		{
			Console.WriteLine("Введите имя водителя: ");
			name = Console.ReadLine();
			Console.WriteLine("Введите фамилию водителя: ");
			surname = Console.ReadLine();
			Console.WriteLine("Введите номер телефона водителя: ");
			phone_number = Console.ReadLine();
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
