using System;
using System.Globalization;
using Exercicio_Resolvido_Enum_Composicao.Entities.Enums;
using Exercicio_Resolvido_Enum_Composicao.Entities;


namespace Exercicio_Resolvido_Enum_Composicao.Entities.Enums
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter department's name: ");
			string NameDept = Console.ReadLine();
			Console.WriteLine("Enter worker data: ");
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Level (Junior/Mid_Level/Senior): ");
			WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
			Console.Write("Base Salary: ");
			double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Department dept = new Department(NameDept);
			Worker worker = new Worker(name, level, salary, dept);

			Console.Write("How many contracts to this worker: ");
			int n = int.Parse(Console.ReadLine());
			
			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine("Enter #" + i + "contract data: ");
				Console.Write("Date (DD/MM/YYYY): ");
				DateTime date = DateTime.Parse(Console.ReadLine());
				Console.Write("Value per hour: ");
				double salaryHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				Console.Write("Duration (hours): ");
				int hour = int.Parse(Console.ReadLine());
				HourContract contract = new HourContract(date, salaryHour, hour);
				worker.AddContract(contract);
			}
			Console.WriteLine();
			Console.Write("Enter month and year to calculate income (MM/YYYY): ");
			string monthAndYear = Console.ReadLine();
			int month = int.Parse(monthAndYear.Substring(0, 2));
			int year = int.Parse(monthAndYear.Substring(3));
			Console.WriteLine("Name: " + worker.Name);
			Console.WriteLine("Department: " + worker.Department.Name);
			Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture));
		}
	}
}
