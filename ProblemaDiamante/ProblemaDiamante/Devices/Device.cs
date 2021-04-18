using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaDiamante.Devices
{
	abstract class Device
	{
		public int SerialNumber { get; set; }
		 public abstract void processDoc(string doc);
	}
}
