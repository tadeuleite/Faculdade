using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatrizes5
{
	class Program
	{
		static void Main(string[] args)
		{
			//Fazer uma matriz 8x5, cujo o conteúdo da primeira coluna é a capital
			//e as outras municipios de cada um dos 8 estados representados pelas linhas

			//Exibir em que linha se encontra o estado mais populoso
			//Exibir em que coluna se encontra o municipio mais populoso de cada estado
			//Exibir a média geral da população das capitais
			//Exibir quantas capitais estão acima da média de população

			//cada linha é um estado, a primeira coluna é sua capital e as demais colunas são seus municipios

			int[,] Populacao = { { 0, 1,  2,  3,  4,  5  },
								 { 1, 11, 21, 31, 41, 51 },
								 { 2, 12, 22, 32, 42, 52 },
								 { 3, 13, 23, 33, 43, 53 },
								 { 4, 14, 24, 34, 44, 54 },
								 { 5, 15, 25, 35, 45, 55 },
								 { 6, 16, 26, 36, 46, 56 },
								 { 7, 17, 27, 37, 47, 57 },
								 { 8, 18, 28, 28, 48, 58 } };

			int acimaMedia = 0, mediaPop = 0, maiorPop = 0, linhaPop = 0, colunaPop = 0, maiorPopMun = 0;

			//exibir matriz e gravar o maior municipio e em que linha está
			#region
			Console.WriteLine("COLUNAS > | 1  | 2  | 3  | 4  | 5  |");
			for (int i = 1; i < 9; i++)
			{
				Console.Write("LINHA {0} > |", i);
				for (int j = 1; j < 6; j++)
				{
					Console.Write("{0}  |", Populacao[i, j]);
					if (maiorPop < Populacao[i, j])
					{
						maiorPop = Populacao[i, j];
						linhaPop = i;
					}
					mediaPop = mediaPop + Populacao[i, j];
				}
				Console.WriteLine("");
			}
			Console.WriteLine("");
			#endregion

			//exibir, em cada linha, qual o municipio com maior população
			#region
			for (int i3 = 1; i3 < 9; i3++)
			{
				colunaPop = 0;
				for (int j3 = 1; j3 < 6; j3++)
				{
					if (colunaPop < Populacao[i3, j3])
					{
						colunaPop = Populacao[i3, j3];
						maiorPopMun = j3;
					}
				}
				Console.WriteLine("O município mais populoso da linha {0} se encontra na coluna {1}", i3, maiorPopMun);
			}
			#endregion

			mediaPop = mediaPop / 40; //média

			//exibir quantas e quais capitais estão acima da média de população
			#region
			Console.WriteLine("\nAs capitais acima da média de população ({0}) são:\n", mediaPop);
			for (int i2 = 1; i2 < 9; i2++)
			{
				for (int j2 = 1; j2 < 6; j2++)
				{
					if (mediaPop < Populacao[i2, j2])
					{
						Console.Write("{0}  ", Populacao[i2, j2]);
						acimaMedia++;
					}
				}
				Console.WriteLine("");
			}
			Console.WriteLine("\nAo total, {0} capitais ficaram acima da média de população", acimaMedia);
			Console.WriteLine("\nO estado com maior população se encontra na linha {0}", linhaPop);
			#endregion
		}
	}
}
