using Covid_19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19.Controller
{
	class Verificar
	{
		public Pessoas[,] doenca (Pessoas[,] pessoas)
		{
			int linhas = pessoas.GetLength(0);
			int colunas = pessoas.GetLength(1);
			int contaminar;
			Random random = new Random();
			for (int i = 0; i < linhas; i++)
			{
				for (int x = 0; x < colunas; x++)
				{
					//50% da pessoa se contaminar 
					contaminar = random.Next(0, 2); 

					//verifica se existe alguem acima
					if (i != 0)
					{
						Pessoas acima = pessoas[i - 1, x];

						//verifica se a pessoa acima esta infectada 
						if (acima._contaminado)
							//verifica se vai contaminar ou nao
							if(contaminar == 1)
							pessoas[i, x]._contaminado = true;
					}
					//verifica se tem alguem a baixo 
					if (i != linhas)
					{
						Pessoas baixo = pessoas[i + 1, x];
						if (baixo._contaminado)
							//verifica se vai contaminar ou nao
							if (contaminar == 1)
								pessoas[i, x]._contaminado = true;
					}

					//verifica se tem alguem a esquerda
					if (x !=0)
					{
						Pessoas esquerda = pessoas[i, x -1];

						if (esquerda._contaminado)
							//verifica se vai contaminar ou nao
							if (contaminar == 1)
								pessoas[i, x]._contaminado = true;
					}

					//verifica se tem alguem a direita 
					if(x != colunas)
					{
						Pessoas direita = pessoas[i, x +1];

						if (direita._contaminado)
							//verifica se vai contaminar ou nao
							if (contaminar == 1)
								pessoas[i, x]._contaminado = true;
					}
					
				}

			}


			return pessoas;
		}
	}
}
