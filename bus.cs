using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_lab6_prog3
{
    public class bus
    {
		// Номер автобуса
		private int bus_num;
		public int _bus_num 
		{
			get { return bus_num; }
			set { bus_num = value; }
		}
		private int num_of_seats; // Занятые места (max 32)
		private engine bus_engine;
		private wheels bus_wheels;
		private driver bus_driver;
		private static int total_sum; // Общая сумма зар. денег со всех автобусов
		// Цена проезда (Руб)
		private int price;
		public int _price
        {
			get { return price; }
			set { price = value; }
		}
		private int sum; // Сумма заработанных денег
		public int _sum
        {
			get { return sum; }
			set { sum = value; }
        }

		// Конструктор
		public bus(int bus_num, int num_of_seats,
			int price)
		{
			this.bus_num = bus_num;
			this.num_of_seats = num_of_seats;
			this.price = price;
			sum = 0;
			bus_engine = new engine();
			bus_wheels = new wheels();
			bus_driver = new driver();
		}
		// Добавить пассажира
		public int add_passenger()
		{
			if (num_of_seats < 32)
			{
				num_of_seats += 1;
				int seats_left = 32 - num_of_seats;
				sum += price;
				total_sum += price;
				Console.WriteLine("\nПассажир успешно зашел в автобус и оплатил проезд.\nСвободных мест осталось: " + seats_left + "\n");
			}
			else
			{
				Console.WriteLine("\nПассажир не смог занять место. Автобус переолнен.\n");
				return -1;
			}
			return 0;
		}
		// Убрать пассажира
		public int remove_passenger()
		{
			if (num_of_seats > 0)
			{
				num_of_seats -= 1;
				int seats_left = 32 - num_of_seats;
				Console.WriteLine("\nПассажир успешно покинул автобус.\nСвободных мест осталось: " + seats_left + "\n");
			}
			else
			{
				Console.WriteLine("\nОшибка. Автобус пуст.\n");
				return -1;
			}
			return 0;
		}
		// Ввод информации об автобусе
		public void init_bus()
		{
			int flag = 0;
			do
			{
				if (flag == 0) Console.WriteLine("Введите номер автобуса: ");
				if (flag == 1) Console.WriteLine("Ошибка. Введите номер автобуса: ");
				bus_num = Convert.ToInt32(Console.ReadLine());
				flag = 1;
			} while (bus_num < 0);
			flag = 0;
			do
			{
				if (flag == 0) Console.WriteLine("Введите цену проезда: ");
				if (flag == 1) Console.WriteLine("Ошибка. Введите цену проезда: ");
				price = Convert.ToInt32(Console.ReadLine());
				flag = 1;
			} while (price < 0);
			bus_engine.input_engine();
			bus_wheels.input_wheels();
			bus_driver.input_driver();
		}
		// Вывод информации об автобусе
		public void print_bus()
		{
			Console.WriteLine("\nНомер автобуса: ");
			Console.WriteLine(bus_num);
			Console.WriteLine("Занятые места: " + num_of_seats + " из 32");
			Console.WriteLine("Цена проезда: ");
			Console.WriteLine(price);
			Console.WriteLine("Сумма заработанных денег: ");
			Console.WriteLine(sum);
			bus_engine.print_engine();
			bus_wheels.print_wheels();
			bus_driver.print_driver();
		}
		public static int operator + (bus b1, bus b2)
        {
			return b1.sum + b2.sum;
        }
		public static bus operator ++ (bus b1)
        {
			b1.sum += b1.price;
			return b1;
        }
		// Получение общей суммы зар. денег
		public static int get_total_sum()
		{
			return total_sum;
		}
		// Установка общей суммы зар. денег
		public static void set_total_sum(int total)
		{
			total_sum = total;
		}
	}
}
