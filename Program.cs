using System;

namespace derveninov01_lab6_prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            bus my_bus1 = new bus(1, 0, 25);
            bus my_bus2 = new bus(2, 0, 20);
            my_bus1.add_passenger();
            my_bus2.add_passenger();
            Console.WriteLine("Общая сумма заработанных денег = " + bus.get_total_sum());
        }
    }
}
