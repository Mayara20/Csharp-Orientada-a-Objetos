using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace teste
{
	class DadosDoCarro
	{
		private string _modelo;
		private int _ano;
		private string _cor;
		private double _valor;

		public DadosDoCarro(string modelo, int ano, string cor, double valor)
		{
			_modelo = modelo;
			_ano = ano;
			_cor = cor;
			_valor = valor;
		}
		public double Valor
		{
			get { return _valor; }
			set {
				if (value == 0 || value < 0)
				{
					_valor = value;
				}
			}
		}
	
		public void NovoValor(double desconto)
		{
			_valor = _valor - desconto;
		}
		/* public override string ToString()
		{
			return " O nosso novo modelo de "
				+ Modelo
				+ " na cor mais cobiçada do momento esse tom de "
				+ Cor
				+ " charmoso,encantador,magnífico, " +
				"do ano de "
				+ Ano
				+ " por apenas $ "
				+ Valor.ToString("F2", CultureInfo.InvariantCulture)
				+ " não perca a oportunidade de garantir o seu! "; 
		} */
	}
}
