using System;
using System.IO;

namespace Path_
{
	class Program
	{
		static void Main(string[] args)
		{
			string pasta = @"C:\DesenvolvimentoMayara\myFolder\File.txt";

			Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
			Console.WriteLine("PathSeparator: " + Path.PathSeparator);
			Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(pasta));
			Console.WriteLine("GetFileName: " + Path.GetFileName(pasta));
			Console.WriteLine("GetExtension: " + Path.GetExtension(pasta));
			Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(pasta));
			Console.WriteLine("GetFullPath: " + Path.GetFullPath(pasta));
			Console.WriteLine("GetTempPath: " + Path.GetTempPath());
		}
	}
}
