﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores_em_classe2
{
	class Product
	{
		public string Name { get; set; }
		public double Price { get; set; }

		public Product(string name, double price)
		{
			Name = name;
			Price = price;
		}
	}
}
