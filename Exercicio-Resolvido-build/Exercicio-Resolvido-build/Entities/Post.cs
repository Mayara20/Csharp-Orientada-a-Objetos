using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Resolvido_build.Entities
{
	class Post
	{
		public DateTime Momento { get; set; }
		public string Titulo { get; set; }
		public string Conteudo { get; set; }
		public int Likes {get; set; }
		public List<Comentarios> Comentario { get; set; } = new List<Comentarios>();

		public Post()
		{
		}
		public Post(DateTime momento, string titulo, string conteudo, int likes)
		{
			Momento = momento;
			Titulo = titulo;
			Conteudo = conteudo;
			Likes = likes;
		}
		public void AddComentario(Comentarios comentario)
		{
			Comentario.Add(comentario);
		}
		public void RemoveComentario(Comentarios comentarios)
		{
			Comentario.Add(comentarios);
		}
		public override string ToString()
		{
			StringBuilder x = new StringBuilder();
			x.AppendLine(Titulo);
			x.Append(Likes);
			x.Append(" Likes - ");
			x.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss "));
			x.AppendLine(Conteudo);
			x.AppendLine(" Comentarios: ");
			foreach (Comentarios c in Comentario)
			{
				x.AppendLine(c.Texto);
			}
			return x.ToString();
		}
	}
}
