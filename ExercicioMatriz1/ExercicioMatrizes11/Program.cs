using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
            Escrever todos os estados num vetor
            Uma matriz onde cada coluna contém a temperatura máxima de cada estado durante um ano
            cada coluna é um estado e cada linha corresponde aos dias
            Receber a sigla do estado e mostrar a temperatura média anual do estado da sigla informada
            */
			string sigla;
			string[] estados = { "AC", "PE", "BA", "RJ", "SP" };
			int[,] temperaturaMaxima ={ {  35,   32,   33,   34,   36  },
										{  41,   42,   43,   44,   45  },
										{  51,   52,   53,   54,   55  },
										{  61,   62,   63,   64,   65  },
										{  20,   21,   22,   23,   24  } };

			Console.WriteLine("Digite a sigla do estado que você deseja saber a temperatura média anual");
			sigla = Console.ReadLine().ToUpper();

			int posicaoEstadoVetor = PosicaoEstado(sigla, estados);

			if (posicaoEstadoVetor != -1)
			{
				Console.WriteLine("A temperatura média foi de: {0}", TemperaturaMediaEstado(temperaturaMaxima, posicaoEstadoVetor));
			}
			else
			{
				Console.WriteLine("A sigla não foi encontrada");
			}
		}

		static int TemperaturaMediaEstado(int[,] temperaturaMaxima, int posicao)
		{
			const int qtdDias = 5;
			int media = 0;

			for (int j = 0; j < qtdDias; j++)
			{
				media = media + temperaturaMaxima[j, posicao];
			}
			media = media / qtdDias;

			return media;
		}

		static int PosicaoEstado(string sigla, string[] estados)
		{
			int posicao = -1;

			for (int i = 0; i < estados.Length; i++)
			{
				if (sigla == estados[i])
				{
					posicao = i;
				}
			}

			return posicao;
		}
	}
}
