using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicios_Listas
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("How many employees will be registered? ");//quantos funcionários serão registrados
			int n = int.Parse(Console.ReadLine());

			List<IncreaseSalary> list = new List<IncreaseSalary>();//aumento salario

			for (int i = 1; i <= n; i++)
			{
				Console.Write("Emplyoee #" + i + ":"); //cada funcionário
				Console.WriteLine();
				Console.Write("Id: ");
				int id = int.Parse(Console.ReadLine());
				Console.Write("Name: ");
				string name = Console.ReadLine(); //nome
				Console.Write("Salary: ");
				double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //salário
				list.Add(new IncreaseSalary(id, name, salary));
			}
			Console.Write("Enter the employee id that will have salary increase: ");//entre com o id do funcionário que terá aumento no salário
			int newId = int.Parse(Console.ReadLine());

			IncreaseSalary employee = list.Find(l => l.Id == newId);
			if(employee != null)
			{
				Console.Write("Enter the porcentage: "); //qual a porcentagem de aumento
				double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				employee.increaseSalary(porcentage);
			}
			else
			{
				Console.WriteLine("This id does not exist!"); //esse id não existe
			}
			Console.WriteLine();
			Console.WriteLine("Updated list of employees: ");
			 foreach(IncreaseSalary obj in list)
			{
					Console.WriteLine(obj);
			}
		}
	}
}
