using System;
using System.IO;


namespace Streams
{
	class Program
	{
		static void Main(string[] args)
		{
			string teste = "C:\\DesenvolvimentoMayara\\testeFile.txt";
			//FileStream x = null;
			StreamReader y = null;

			try
			{
				//x = new FileStream(teste, FileMode.Open);
				y = File.OpenText(teste);
				while (!y.EndOfStream)
				{
					string line = y.ReadLine();
					Console.WriteLine(line);
				}
			}
			catch(IOException Ex)
			{
				Console.WriteLine("Ocorreu um erro!");
				Console.WriteLine(Ex.Message);
			}
			finally
			{
				if (y != null) y.Close();
				//if (x != null) x.Close();
			}
		}
	}
}
