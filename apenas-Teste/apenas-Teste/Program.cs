using System;
using System.Globalization;
using System.Collections.Generic;

namespace apenas_Teste
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("How many employees will be registered? ");
			int n = int.Parse(Console.ReadLine());

			List<Employee> list = new List<Employee>();
			for (int i = 1; i <= n; i++)
			{
				Console.Write("Emplyoee #" + i + ":");
				Console.WriteLine();
				Console.Write("Id: ");
				int id = int.Parse(Console.ReadLine());
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Salary: ");
				double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				list.Add(new Employee(id, name, salary));
			}
			Console.WriteLine();
			Console.Write("Enter the employee id that will have salary increase: ");
			int idAvailable = int.Parse(Console.ReadLine());
			Employee analyze = list.Find(x => x.Id == idAvailable);
			if (analyze != null)
			{
				Console.Write("Enter the percentage: ");
				double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			    analyze.newSalary(porcentage);
			}
			else
			{
				Console.WriteLine("This id does not exist!");
			}
			Console.WriteLine("Updated list of employees: ");
			foreach(Employee obj in list)
			{
				Console.WriteLine(obj);
			}
		}
	}
}
