using System;
using System.Collections.Generic;

namespace HashSet_Conjuntos
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> set = new HashSet<string>();

			set.Add("x");
			set.Add("y");
			set.Add("r");
			set.Add("t");

			Console.WriteLine(set.Contains("M"));
			
			foreach(string j in set)
			{
				Console.WriteLine(j);
			}
		}
	}
}
