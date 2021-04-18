using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaDiamante.Devices
{
	class Scanner : Device
	{
		public override void processDoc(string doc)
		{
			Console.WriteLine("Processando Scanner: " + doc);
		}
		public string scan()
		{
			return "Scanner scan result";
		}
	}
}
