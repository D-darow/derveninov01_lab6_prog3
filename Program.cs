using System;

namespace derveninov01_lab6_prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            foreign_driver new_driver = new foreign_driver("Кто", "То", "967565678", 4325);
            // Глубокое клонирование
            foreign_driver clone_driver = (foreign_driver) new_driver.Clone();
            clone_driver.print_driver();
            // Производный класс от абстрактного Figure
            Circle my_circle = new Circle(2.345);
            Console.WriteLine("\nПлощадь круга = " + my_circle.getSquare());
        }
    }
}
