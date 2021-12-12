using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_lab6_prog3
{
    public class driver
    {
        private string name; // Имя
        private string surname; // Фамилия
        private string phone_number; // Номер телефона

		// Конструктор по умолчанию
		public driver()
		{
			name = null;
			surname = null;
			phone_number = null;
		}
		// Конструктор
		public driver(string name_in, string surname_in, string phone_number_in)
		{
			name = name_in;
			surname = surname_in;
			phone_number = phone_number_in;
		}
		// Установка имени
		public void set_name(string name_in)
		{
			name = name_in;
		}
		// Получение имени
		public string get_name()
		{
			return name;
		}
		// Установка фамилии
		public void set_surname(string surname_in)
		{
			surname = surname_in;
		}
		// Получение фамилии
		public string get_surname()
		{
			return surname;
		}
		// Установка номера телефона
		public void set_phone_number(string phone_number_in)
		{
			phone_number = phone_number_in;
		}
		// Получение номера телефона
		public string get_phone_number()
		{
			return phone_number;
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
