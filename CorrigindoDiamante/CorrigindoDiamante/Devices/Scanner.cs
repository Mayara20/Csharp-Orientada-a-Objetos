using System;
using System.Collections.Generic;
using System.Text;

namespace CorrigindoDiamante.Devices
{
	class Scanner : Device, IScanner
	{
		public override void processDoc(string doc)
		{
			Console.WriteLine("Scanner processing: " +  doc);
		}
		public string scan()
		{
			return "Scanner scan result";
		}
	}
}
