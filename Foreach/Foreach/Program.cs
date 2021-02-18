using System;

namespace Foreach
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] vet = new string[] { "Maria", "Alex", "Bob" };

			for(int i = 0; i < vet.Length; i++)
			{
				Console.WriteLine(vet[i]);
			}
			Console.WriteLine("------------------------");

			foreach(string nomes in vet)
			{
				Console.WriteLine(nomes);
			}
		}
	}
}
