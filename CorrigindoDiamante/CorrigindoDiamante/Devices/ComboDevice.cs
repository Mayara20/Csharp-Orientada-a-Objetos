using System;
using System.Collections.Generic;
using System.Text;

namespace CorrigindoDiamante.Devices
{
	class ComboDevice : Device ,IScanner, IPrinter
	{
		public void print(string document)
		{
			Console.WriteLine("Combodevice print " + document);
		}

		public override void processDoc(string doc)
		{
			Console.WriteLine("Combodevice processing " + doc);
		}

		public string scan()
		{
			return "Combodevice scan result ";
		}
	}
}
