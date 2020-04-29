using Covid_19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19.Controller
{
	class Simular
	{
		/*public Pessoas[]  Contaminacao ()
		{
			Pessoas[] contaminacao;

			return contaminacao;
		}*/

		
		public Pessoas[,] Preencher()
		{
			//instancia a classe random 
			Random random = new Random();

		

			// gera o numero randomicamente da matriz 
			int linhas = random.Next(10, 100);

			// variavel se a pessoa esta contaminada 
			bool contaminada = false;

			//tempo contaminado 
			int tempo = 0;
			Pessoas[,] pessoas;
			//cria uma matriz quadrada 
			pessoas = new Pessoas[linhas, linhas];

			//total de objetos da matriz
			int totPessoas = linhas * linhas;

			//percorre a linha 
			for (int i = 0; i < linhas; i++)
			{
				//percorre a coluna 
				for (int x = 0; x < linhas; x++)
				{
					int idade = random.Next(1, 99);
					int auxConta = random.Next(0, 2);
					



					//verifica se a pessoa foi contaminada 
					if (auxConta == 0)
					{
						contaminada = false;
						tempo = 1;
					}
						
					else
						contaminada = true;


					// instancia a pessoa 
					Pessoas pessoa = new Pessoas(idade, true, contaminada,tempo);

					//preenche a matriz pessoas
					pessoas[i, x] = pessoa;
				}
			}



			return pessoas;
		}

		public Pessoas[,] Caminhar(Pessoas[,] pessoas)
		{
			int linhas = pessoas.GetLength(0);
			int colunas = pessoas.GetLength(1);
			Pessoas[,] aposCaminhar;
			aposCaminhar = new Pessoas[linhas, colunas];
			Random random = new Random();
			

			//percorrer todas as linhas da matriz 
			for (int i =0; i < linhas; i++)
			{
				//percorrer todas as colunas

				for(int x = 0; x< colunas; x++)
				{
					//procurar um lugar onde a matriz nao foi preenchida ainda 
					while (true)
					{
						int linha = random.Next(0, pessoas.GetLength(0));
						int coluna = random.Next(0, pessoas.GetLength(0));

						//verifica se alguem ja nao caminhou pra essa posicao
						if (aposCaminhar[linha, coluna] == null)
						{
							aposCaminhar[linha, coluna] = pessoas[i, x];
							break;
						}

					}

				}
				
			}
			return aposCaminhar;

		} 
		public Pessoas[,] Curar (Pessoas[,] pessoas)
		{
			Pessoas[,] curadas;
			int linhas = pessoas.GetLength(0);
			int colunas = pessoas.GetLength(1);

			curadas = new Pessoas[linhas, colunas];

			Random random = new Random();


			return curadas;


		}
	}
}
