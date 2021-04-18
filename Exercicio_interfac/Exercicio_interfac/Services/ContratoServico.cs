using System;
using Exercicio_Interfac.Entities;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interfac.Services
{
	class ContratoServico
	{
		private IPagamentosOnline _pagamentosOnline;

		public ContratoServico(IPagamentosOnline pagamentosOnline)
		{
			_pagamentosOnline = pagamentosOnline;
		}
		public void ProcessandoContrato(Contrato contrato, int meses)
		{
			double cota = contrato.ValorTotal / meses;
			for(int i = 1; i <= meses; i++)
			{
				DateTime dataM = contrato.Data.AddMonths(i);
				double cota1 = cota + _pagamentosOnline.JurosSimples(cota,i);
				double cota2 = cota1 + _pagamentosOnline.Taxa(cota1);
				contrato.addParcelas(new Parcelas(dataM, cota2));
			}
		}
	}
}
