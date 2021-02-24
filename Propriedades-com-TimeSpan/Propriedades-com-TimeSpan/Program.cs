using System;

namespace Propriedades_com_TimeSpan
{
	class Program
	{
		static void Main(string[] args)
		{
			TimeSpan m = new TimeSpan(1, 30, 10);
			TimeSpan m1 = new TimeSpan(0, 10, 5);

			Console.WriteLine(m);
			Console.WriteLine(m1);

			TimeSpan sum = m.Add(m1);//adicionou
			Console.WriteLine(sum);
			TimeSpan dif = m.Subtract(m1); //subtraiu
			Console.WriteLine(dif);
			TimeSpan mult = m1.Multiply(2);//multiplicou
			Console.WriteLine(mult);
			TimeSpan div = m1.Divide(2);//dividiu
			Console.WriteLine(div);
		}
	}
}
