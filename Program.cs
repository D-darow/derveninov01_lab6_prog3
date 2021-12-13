using System;

namespace derveninov01_lab6_prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            bus my_bus = new bus(1, 0, 25, 300, 2, 8, 50, 25, "Валерий", "Петров", "893452135");
            my_bus.add_passenger();
            my_bus.print_bus();
        }
    }
}
