using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo1
{
	class Carro
	{
		public string Cor{ get; private set; }
		public string Modelo{ get; private set; }
		public int Portas{ get; private set; }
		public double Valor{ get; private set; }

		public Carro(string cor, string modelo, int portas, double valor)
		{
			Cor = cor;
			Modelo = modelo;
			Portas = portas;
			Valor = valor;
		}
		/*public Carro(string modelo, int portas)
		{
			Modelo = modelo;
			Portas = portas;
			Valor = 85250.00;
		} */
		public Carro(string modelo,string cor, double valor)
		{
			Modelo = modelo;
			Cor = cor;
			Portas = 0;
			Valor = valor;
		}
		public void TrocarCor(string cor)
		{
			Cor = cor;
		}
		public void AplicarDesconto(double desconto)
		{
			Valor = Valor - desconto;
		}
	}
}
