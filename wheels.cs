using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_lab6_prog3
{
    public struct wheels
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

		// Конструктор
		public wheels(int diametr_of_disk, int width_of_tire)
		{
			this.diameter_of_disk = diametr_of_disk;
			this.width_of_tire = width_of_tire;
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
