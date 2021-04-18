using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaDiamante.Devices
{
	class Printer : Device
	{
		public override void processDoc(string doc)
		{
			Console.WriteLine("Processando impressão: " + doc);
		}
		public void Print(string document)
		{
			Console.WriteLine("Printer print: " + document);
		}
	}
}
