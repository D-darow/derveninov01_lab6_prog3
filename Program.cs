﻿using System;

namespace derveninov01_lab6_prog3
{
    class Program
    {
        static void Main(string[] args)
        {
			// Создание объекта конструктором без параметров
			bus my_bus = new bus();
			my_bus.print_bus();
			// Создание массива объектов конструктором с 1 параметром
			bus[] bus_arr = new bus[2];
			bus_arr[0] = new bus(20);
			bus_arr[1] = new bus(30);
			for (int i = 0; i < 2; i++)
			{
				bus_arr[i].print_bus();
			}
			// Создание объекта конструктором со всеми параметрами
			bus my_bus2 = new bus(23, 0, 25, 1, 1, 8, 30, 40, "asds", "asd", "12345");
			my_bus2.print_bus();
		}
    }
}
