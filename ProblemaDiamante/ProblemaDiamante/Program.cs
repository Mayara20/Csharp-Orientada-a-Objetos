using System;
using ProblemaDiamante.Devices;

namespace ProblemaDiamante
{
	class Program
	{
		static void Main(string[] args)
		{
			Printer p = new Printer() { SerialNumber = 2455 };
			p.processDoc("My letter: ");
			p.Print("My letter");

			Scanner s = new Scanner() { SerialNumber = 6477 };
			s.processDoc("Scanner my email: ");
			Console.WriteLine(s.scan());
		}
	}
}
