using System;
using System.IO;

namespace Fixacao_Arquivos
{
	class Program
	{
		static void Main(string[] args)
		{
			string arquivo = @"C:\DesenvolvimentoMayara\testex";

			try
			{
				using(StreamReader sr = File.OpenText(arquivo))
				{
					
				}
			}
			catch(IOException Ex)
			{
				Console.WriteLine("ERROR!");
				Console.WriteLine(Ex.Message);
			}
		}
	}
}
