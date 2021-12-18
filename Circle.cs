using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Пример интерфейса
interface Printable
{
	void print();
}
namespace derveninov01_lab6_prog3
{
    class Circle : Figure, Printable
    {
		private double radius;
		public Circle(double r)
		{
			radius = r;
		}
		// Площадь
		public override double getSquare()
		{
			return radius * radius * 3.14;
		}
		// Периметр
		public override double getPerimeter()
		{
			return 2 * 3.14 * radius;
		}
		// Печать
		public void print()
		{
			Console.WriteLine("Радиус круга = " + radius);
		}
	}
}
