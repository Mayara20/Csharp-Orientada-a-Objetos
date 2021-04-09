using System;
using System.IO;

namespace Stream_xWriterr
{
	class Program
	{
		static void Main(string[] args)
		{
			string fs = "C:\\DesenvolvimentoMayara\\testeFile.txt";
			string sr = "C:\\DesenvolvimentoMayara\\testeFile3.txt";

			try
			{
				string[] lines = File.ReadAllLines(fs);

				using (StreamWriter sw = File.AppendText(sr))
				{
					foreach(string line in lines)
					{
						sw.WriteLine(line.ToUpper());
					}
				}
			}
			catch(IOException ex)
			{
				Console.WriteLine("Um erro encontrado");
				Console.WriteLine(ex.Message);
			}
		}
	}
}
