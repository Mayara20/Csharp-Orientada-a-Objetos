using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_Listas
{
	class IncreaseSalary
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Salary { get;private set; }

		public  IncreaseSalary(int id, string name, double salary)
		{
			Id = id;
			Name = name;
			Salary = salary;
		}
		public void increaseSalary(double porcentage)
		{
			Salary += Salary * porcentage / 100.0;
		}
		public override string ToString()
		{
			return Id 
				+ ", "
				+ Name
				+ ", "
				+ Salary.ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
