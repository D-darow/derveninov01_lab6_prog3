﻿using System;

namespace derveninov01_lab6_prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива объектов
            bus[] bus_arr = new bus[2];
            bus_arr[0] = new bus(1, 0, 25);
            bus_arr[1] = new bus(2, 0, 20);
            // Добавляем пассажиров
            bus_arr[0].add_passenger();
            bus_arr[1].add_passenger();
            // Перегрузка оператора +
            int sum12 = bus_arr[0] + bus_arr[1];
            Console.WriteLine("Сумма 1 автобуса + Сумма 2 автобуса = " + sum12);
            // Перегрузка оператора ++
            Console.WriteLine("Сумма первого автобуса = " + bus_arr[0]._sum);
            Console.WriteLine("(Первый автобус)++ = " + bus_arr[0]++._sum);
        }
    }
}
