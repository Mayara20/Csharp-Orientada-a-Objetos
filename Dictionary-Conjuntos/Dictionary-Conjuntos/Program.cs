using System;
using System.Collections.Generic;

namespace Dictionary_Conjuntos
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> cookies = new Dictionary<string, string>();

			cookies["Usuario"] = "Bob";
			cookies["Telefone"] = "3844667284";
			cookies["Usuario"] = "Nike";
			cookies["CPF"] = "345876234-56";

			Console.WriteLine(cookies["CPF"]);
			Console.WriteLine(cookies["Usuario"]);
			//cookies.Remove("Telefone");

			if (cookies.ContainsKey("Telefone"))
			{
				Console.WriteLine(cookies["Telefone"]);
			}
			else
			{
				Console.WriteLine("Não existe esse dado solicitado");
			}

			Console.WriteLine("Size = " + cookies.Count);
			Console.WriteLine();

			Console.WriteLine("Todos: ");
			foreach(KeyValuePair<string, string> dados in cookies)
			{
				Console.WriteLine(dados.Key + ": " + dados.Value);
			}
		}
	}
}
 