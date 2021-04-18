using System;
using System.Collections.Generic;
using System.Text;

namespace CorrigindoDiamante.Devices
{
	class Printer : Device, IPrinter
	{
		public override void processDoc(string doc)
		{
			Console.WriteLine("Printer processing: " + doc);
		}
		public void print(string document)
		{
			Console.WriteLine("Printer print: " + document);
		}
	}
}
