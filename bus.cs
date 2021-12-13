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
		private int bus_num { get; init; }
		private int num_of_seats; // Занятые места (max 32)
		private engine bus_engine;
		private wheels bus_wheels;
		private driver bus_driver;
		// Цена проезда (Руб)
		private int price { get; init; }
		private int sum; // Сумма заработанных денег

		// Конструктор
		public bus(int bus_num, int num_of_seats,
			int price, int hs_power, int fuel, int num_of_cylinders,
			int diametr_of_disk, int width_of_tire, string name, string surname, string phone_number)
		{
			this.bus_num = bus_num;
			this.num_of_seats = num_of_seats;
			this.price = price;
			sum = 0;
			engine bus_engine = new engine(hs_power, fuel, num_of_cylinders);
			wheels bus_wheels = new wheels(diametr_of_disk, width_of_tire);
			driver bus_driver = new driver(name, surname, phone_number);
		}
		// Добавить пассажира
		public int add_passenger()
		{
			if (num_of_seats < 32)
			{
				num_of_seats += 1;
				int seats_left = 32 - num_of_seats;
				sum += price;
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
	}
}
