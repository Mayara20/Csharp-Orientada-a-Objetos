using System;
using Exercicio_interfac.Entities;
using Exercicio_interfac.Services;

namespace Exercicio_interfac
{
	class ServicosAluguel
	{
		public double PrecoPorHora { get; private set; }
		public double PrecoPorDia { get; private set; }

		public ServicosAluguel()
		{
		}
		private ITaxService TaxaService;
		public ServicosAluguel(double precoPorHora, double precoPorDia, ITaxService taxaService)
		{
			PrecoPorHora = precoPorHora;
			PrecoPorDia = precoPorDia;
			TaxaService = taxaService;
		}
		public void ProcessamentoFaturamento(AluguelCarro aluguel)
		{
			TimeSpan duration = aluguel.Entrega.Subtract(aluguel.Retirada);

			double pagamento = 0.0;
			if (duration.TotalHours <= 12.0)
			{
				pagamento = PrecoPorHora * Math.Ceiling(duration.TotalHours);
			}
			else
			{
				pagamento = PrecoPorDia * Math.Ceiling(duration.TotalDays);
			}

			double taxa = TaxaService.Taxa(pagamento);

			aluguel.Fatura = new Fatura(pagamento, taxa);
		}
	}
}
