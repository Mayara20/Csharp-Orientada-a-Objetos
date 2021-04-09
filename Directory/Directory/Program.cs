using System;
using System.IO;
using System.Collections.Generic;

namespace Teste
{
	class Program
	{
		static void Main(string[] args)
		{
			string pasta = @"C:\DesenvolvimentoMayara\myFolder";

			try
			{
				//DirectoryInfo past = new DirectoryInfo(pasta);
				//IEnumerable<string> folders = Directory.EnumerateDirectories(pasta, "*.*", SearchOption.AllDirectories);
				var folders = Directory.EnumerateDirectories(pasta, "*.*", SearchOption.AllDirectories);
				Console.WriteLine("Folders: ");
				foreach(string s in folders)
				{
					Console.WriteLine(s);
				}
				Console.WriteLine("------------------------------------");
				var files = Directory.EnumerateFiles(pasta, "*.*", SearchOption.AllDirectories);
				Console.WriteLine("Files: ");
				foreach (string s in files)
				{
					Console.WriteLine(s);
				}
				Directory.CreateDirectory(pasta + "\\new folder");
			}
			catch (IOException ex)
			{
				Console.WriteLine("ERROR");
				Console.WriteLine(ex.Message);
			}

		}
	}
}
