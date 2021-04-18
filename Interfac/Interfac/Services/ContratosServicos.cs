using System;
using Interfac.Entities;
using System.Collections.Generic;
using System.Text;

namespace Interfac.Services
{
	class ContratosServicos
	{
		IPagamentoOnline _pagamentoOnline;

		public  ContratosServicos(IPagamentoOnline pagamentosOnline)
		{
			_pagamentoOnline = pagamentosOnline;
		}
		public void ProcessamentoContrato(Contrato contrato, int meses)
		{
			double cota = contrato.ValorTotal / meses;
			for(int i = 1; i <= meses; i++)
			{
				DateTime data = contrato.Data.AddMonths(i);
				double cota1 = cota + _pagamentoOnline.JurosSimples(cota, i);
				double cota2 = cota1 + _pagamentoOnline.Taxa(cota1);
				contrato.addParcelas(new Parcelas(data, cota2));
			}
		}

	}
}
