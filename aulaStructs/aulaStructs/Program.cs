using System;

namespace aulaStructs
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p = new Point();
			p.X = 10;
			p.Y = p.X;
			//p.Y = 20;

			Console.WriteLine(p);
		}
	}
}
