using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_lab6_prog3
{
    class foreign_driver : driver, ICloneable
    {
        protected long RPV_id; // Номер разрешения на временное проживание
		// Конструктор
		public foreign_driver(String name, String surname, String phone_number, long RPV_id) :
			base(name, surname, phone_number)
		{
			this.RPV_id = RPV_id;
		}
		// Переопределние метода вывода
		public new void print_driver()
		{
			base.print_driver();
			Console.WriteLine("Номер разрешения на временное проживание: " + RPV_id);
		}
		// Клоинрование
		public object Clone()
        {
			return new foreign_driver(this.name, this.surname,
				this.phone_number, this.RPV_id);
			
        }
	}
}
