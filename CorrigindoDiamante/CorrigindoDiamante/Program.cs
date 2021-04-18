using System;
using CorrigindoDiamante.Devices;

namespace CorrigindoDiamante
{
	class Program
	{
		static void Main(string[] args)
		{
			Scanner s = new Scanner() { SerialNumber = 2445 };
			s.processDoc("My email: ");
			Console.WriteLine(s.scan());

			Printer p = new Printer() { SerialNumber = 5773 };
			p.processDoc("My letter");
			p.print("My letter");

			ComboDevice c = new ComboDevice() { SerialNumber = 6366 };
			c.processDoc("My dissertation");
			c.print("My dissertation");
			Console.WriteLine(c.scan());
		}
	}
}
