using System;
using System.IO;

namespace Using_Block
{
	class Program
	{
		static void Main(string[] args)
		{
			string teste = "C:\\DesenvolvimentoMayara\\testeFile6.txt";
			try
			{
				using (StreamReader sr = File.OpenText(teste))
				{
					while (!sr.EndOfStream)
					{
						string line = sr.ReadLine();
						Console.WriteLine(line);
					}
				}
			}
			catch (IOException Ex)
			{
				Console.WriteLine("Um erro encontrado");
				Console.WriteLine(Ex.Message);
			}
		}
	}
}
