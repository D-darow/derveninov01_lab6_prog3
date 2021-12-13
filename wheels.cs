using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_lab6_prog3
{
    public class wheels
    {
		// Диаметр колеса (В дюймах)
		private int diameter_of_disk;
		public int _diameter_of_disk
        {
			get { return diameter_of_disk; }
			set { diameter_of_disk = value; }
        }
		// Ширина шины (В мм)
		private int width_of_tire;
		public int _width_of_tire
        {
			get { return width_of_tire; }
			set { width_of_tire = value; }
        }

		// Конструктор по умолчанию
		public wheels()
		{
			diameter_of_disk = 0;
			width_of_tire = 0;
		}
		// Конструктор
		public wheels(int diametr_of_disk, int width_of_tire)
		{
			this.diameter_of_disk = diametr_of_disk;
			this.width_of_tire = width_of_tire;
		}
		// Ввод информации о колесах
		public void input_wheels()
		{
			int flag = 0;
			do
			{
				if (flag == 0) Console.WriteLine("Введите диаметр диска (Дюйм): ");
				if (flag == 1) Console.WriteLine("Ошибка. Введите диаметр диска (Дюйм): ");
				diameter_of_disk = Convert.ToInt32(Console.ReadLine());
				flag = 1;
			} while (diameter_of_disk < 0);
			flag = 0;
			do
			{
				if (flag == 0) Console.WriteLine("Введите ширину шины (мм): ");
				if (flag == 1) Console.WriteLine("Ошибка. Введите ширину шины (мм): ");
				width_of_tire = Convert.ToInt32(Console.ReadLine());
				flag = 1;
			} while (width_of_tire < 0);
		}
		// Вывод информации о колесах
		public void print_wheels()
		{
			Console.WriteLine("Диаметр колеса (В дюймах): ");
			Console.WriteLine(diameter_of_disk);
			Console.WriteLine("Ширина шины (В мм): ");
			Console.WriteLine(width_of_tire);
		}
	}
}
