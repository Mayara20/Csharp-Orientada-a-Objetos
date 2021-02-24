using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace apenas_Teste
{
	class Employee
	{
		public int Id { get;private set; }
		public string Name { get;private set; }
		public double Salary { get;private set; }

		public Employee(int id, string name, double salary)
		{
			Id = id;
			Name = name;
			Salary = salary;
		}
		public void newSalary(double porcentage)
		{
			Salary += Salary * porcentage / 100.0;
		}
		public override string ToString()
		{
			return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
