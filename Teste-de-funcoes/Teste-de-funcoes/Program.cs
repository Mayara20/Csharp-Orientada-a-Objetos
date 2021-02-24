using System;
using System.Collections.Generic;

namespace Teste_de_funcoes
{
	class Program
	{
		static void Main(string[] args)
		{
			string test = "Mayara Meireles  ";
			
			string n1 = test.ToUpper();
			string n2 = test.ToLower();
			string n3 = test.Substring(0, 7);
			string n4 = test.Substring(7);
			string n5 = test.Trim();
			int n6 = test.IndexOf("a");
			int n7 = test.LastIndexOf("e");
			string n8 = test.Replace("a", "i");
			string n9 = test.Replace("e", "a");

			Console.WriteLine("_" + test + "_");
			Console.WriteLine("ToUpper: _" + n1 + "_");
			Console.WriteLine("ToLower: _" + n2 + "_");
			Console.WriteLine();
			Console.WriteLine("Substring: _" + n3 + "_");
			Console.WriteLine("Substring: _" + n4 + "_");
			Console.WriteLine();
			Console.WriteLine("Trim: _" + n5 + "_"); 
			Console.WriteLine();
			Console.WriteLine("IndexOf: _" + n6 + "_");
			Console.WriteLine("LastIndexOf: _" + n7 + "_");
			Console.WriteLine();
			Console.WriteLine("Replace: _" + n8 + "_");
			Console.WriteLine("Replace: _" + n9 + "_");
		}
	}
}
