using System;

namespace derveninov01_lab6_prog3
{
    class Program
    {
        static void Main(string[] args)
        {
			bus my_bus = new bus();
			my_bus.add_passenger();
			try
			{
				int check = my_bus.remove_passenger();
				if (check == -1) throw new Exception("\nАвтобус пуст.\n");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			try
			{
				int check = my_bus.remove_passenger();
				if (check == -1) throw new Exception("\nАвтобус пуст.\n");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
    }
}
