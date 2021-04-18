using System;
using System.Collections.Generic;
using System.Text;

namespace Restricoes_Genericas.Services
{
	class CalculationServices
	{
		public T Max<T>(List<T> list) where T : IComparable
		{
			if(list.Count == 0)
			{
				throw new ArgumentException("A lista não pode estar vazia");
			}
			T max = list[0];
			for (int i = 1; i < list.Count; i++) 
			{
				if(list[i].CompareTo(max) > 0)
				{
					max = list[i];
				}
			}
			return max;
		}
	}
}
