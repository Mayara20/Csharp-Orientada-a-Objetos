using System;

namespace modificadorParametros
{
	class Program
	{
		static void Main(string[] args)
		{
			int s1 = Calculator.sum(2, 3);
			int s2 = Calculator.sum(2, 4, 3);

			Console.WriteLine(s1);
			Console.WriteLine(s2);

		}
	}
}
