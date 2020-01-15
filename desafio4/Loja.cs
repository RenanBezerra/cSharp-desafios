using System;
using System.Collections.Generic;
using System.Text;

namespace desafio4
{
	class Loja
	{

		private String nome;
		private String cnpj;
		private List<Livro> livros;
		private List<VideoGame> videoGames;

		//atributos	
		public string Nome { get; set; }
		public string Cnpj { get; set; }
		public string Livros { get; set; }
		public string VideoGames { get; set; }

		public Loja(string nome, string cnpj, List<Livro> livros,
			List<VideoGame> videoGames)
		{
			this.Nome = nome;
			this.Cnpj = cnpj;
			this.livros = livros;
			this.videoGames = videoGames;
		}

		

		//metodos 




		public void listaLivros()
		{
			Console.WriteLine("-------------------------------------------------------------------");
			if (livros.Count == 0)
			{

				Console.WriteLine("lista vazia");

			}
			else
			{
				Console.WriteLine("A loja Americanas possui estes livros para venda:");
				foreach (Livro indice in this.livros)
				{

					Console.WriteLine("Titulo: " + indice.Nome + ", Preço: " + indice.Preco + ", Quantidade: " + indice.Qtd + " em estoque.");
				}
			}

		}

		public void listaVideoGames()
		{
			Console.WriteLine("-------------------------------------------------------------------");
			if (videoGames.Count == 0)
			{

				Console.WriteLine("lista vazia");

			}
			else
			{
				Console.WriteLine("A loja Americanas possui estes video-games para venda:");
				foreach (VideoGame indice in this.videoGames)
				{

					Console.WriteLine("Video-game: " + indice.Modelo + ", Preço: " + indice.Preco + ", Quantidade: " + indice.Qtd + " em estoque.");
				}
			}

		}


		public double patriL, patriV, res = 0;
		public void calculaPatrimonio()
		{
			Console.WriteLine("-------------------------------------------------------------------");
			//livros	
			if (this.livros.Count == 0)
			{

			}
			else
			{
				foreach (Livro indice in this.livros)
				//for (Livro indice : livros)
				{
					patriL += indice.Preco * indice.Qtd;
				}
			}
			Console.WriteLine("livros patrimonio " + patriL);


			//video game	
			if (this.videoGames.Count == 0)
			{


			}
			else
			{
				foreach (VideoGame game in videoGames)
				{
					patriV += game.Preco * game.Qtd;
				}
			}
			Console.WriteLine("video game patrimonio " + patriV);
			res = patriV + patriL;
			Console.WriteLine("O patrimonio da lojas americanas é de " + res);




		}
	}
}
