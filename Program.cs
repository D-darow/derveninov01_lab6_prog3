using System;

namespace derveninov01_lab6_prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            bus[,] bus_array = new bus[2,2];
            int bus_num = 1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    bus_array[i,j] = new bus(bus_num);
                    bus_num++;
                }
            }
            bus_array[0,0]._price = 25;
            bus_array[0,0].add_passenger();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    bus_array[i,j].print_bus();
                }
            }
        }
    }
}
