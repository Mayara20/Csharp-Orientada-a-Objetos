using System;
using System.Globalization;
using Exercicio_Proposto_Polimorfismo.Entities;
using System.Collections.Generic;

namespace Exercicio_Proposto_Polimorfismo
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Enter the number of employees: ");
			int x = int.Parse(Console.ReadLine());

			List<Funcionario> employees = new List<Funcionario>();

			for (int i = 1; i <= x; i++)
			{
				Console.WriteLine($"Employee #{i} data: ");
				Console.Write("Outsourced (y/n)? ");
				char resp = char.Parse(Console.ReadLine());
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Hours: ");
				int hours = int.Parse(Console.ReadLine());
				Console.Write("Value per hour: ");
				double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (resp == 'y' || resp == 'Y')
				{
					Console.Write("Additional charge: ");
					double despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					employees.Add(new FuncionariosTerceirizados(name, hours, valuePerHour, despesaAdicional));
				}
				else
				{
					employees.Add(new Funcionario(name, hours, valuePerHour));
				}
			}
			Console.WriteLine();
			Console.WriteLine("PAYMENTS:");
			foreach(Funcionario emp in employees)
			{
				Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
			}
		}
	}
}
