using System;
using Exercicio_Resolvido_build.Entities;

namespace Exercicio_Resolvido_build.Entities
{
	class Program
	{
		static void Main(string[] args)
		{
			Comentarios a1 = new Comentarios("Tenha uma boa viagem!");
			Comentarios a2 = new Comentarios("Uau isso é incrível!");

			Post a3 = new Post(
				DateTime.Parse("21/06/2018 13:05:44"),
				" Viajar para a Nova Zelândia",
				" Vou visitar este país maravilhoso",
				12);
			a3.AddComentario(a1);
			a3.AddComentario(a2);

			Comentarios b1 = new Comentarios("Boa noite!");
			Comentarios b2 = new Comentarios("Que a força esteja com você!");

			Post b3 = new Post(
				DateTime.Parse("28/07/2018 23:14:19"),
				" Boa noite, galera",
				" Vejo você amanhã",
				5);
			b3.AddComentario(b1);
			b3.AddComentario(b2);

			Console.WriteLine(a3);
			Console.WriteLine(b3);
		}
	}
}
