using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			//considere um vetor de 8 posições  contendo o nome dos alunos
			//uma matriz 8x3 contendo as notas dos 3 modulos de um curso de cada aluno
			//cada linha da matriz corresponde a um aluno armazenado na mesma posição da linha do vetor
			//Mostrar
			//o nome e a media de cada aluno
			//o nome e a quantidade dos aluno que obtiveram media igual ou acima da media geral
			//os nomes dos alunos que obtiveram a media abaixo da media geral
			//os alunos que ficaram apenas acima da media geral
			//nome do aluno e o numeros dos modulos dos alunos que tiraram zero em algum modulo

			//declaração da matriz e vetor
			#region
			string[] NomeAlunos = { "José",
									"Marcos",
									"Antônio",
									"Tadeu",
									"Josivanio",
									"Juca",
									"Douglas",
									"Jeferson",
									"Juvenal"}; //7 posições

			double[,] Nota = { { 0,  1, 2 }, //modulos
                               { 10, 9, 8 }, // daqui pra baixo sao notas
                               { 8,  7, 6 },
							   { 6,  0, 4 },
							   { 4,  3, 2 },
							   { 2,  1, 0 },
							   { 10, 7, 5 },
							   { 9,  5, 10},
							   { 7,  7, 3 } };//7 posições

			double[] Media;
			double somatorioMedia = 0, mediaGeral = 0;
			int contAcima = 0, contAbaixo = 0, contZero = 0;
			#endregion

			Media = new double[9];

			for (int i = 1; i < 8; i++) //medias individuais
			{
				for (int i4 = 0; i4 < 3; i4++)
				{
					somatorioMedia = somatorioMedia + Nota[i, i4];
				}
				somatorioMedia = somatorioMedia / 3;
				Media[i] = somatorioMedia;
				somatorioMedia = 0;
			}

			for (int i = 1; i < 8; i++) //media geral
			{
				for (int i2 = 0; i < 3; i++)
				{
					somatorioMedia = Nota[i, i2] + somatorioMedia;
				}
			}
			mediaGeral = somatorioMedia / 24; //media geral calculada


			for (int i = 1; i < 8; i++) //quantidade de pessoas acima, abaixo da média e zero
			{
				if (Media[i] >= mediaGeral)
				{
					contAcima++;
				}
				if (Media[i] < mediaGeral)
				{
					contAbaixo++;
				}
				for (int x = 0; x < 3; x++) //contar as notas abaixo de zero (checa cada coluna de uma linha para ver se é igual a zero)
				{
					if (Nota[i, x] == 0)
					{
						contZero++;
					}
				}
			}
			Console.WriteLine("A média geral de todos os alunos foi de: {0:F2}", mediaGeral);
			Console.WriteLine("{0} Alunos ficaram com a média acima ou igual a média geral, {1} Alunos ficaram com a média abaixo da média geral", contAcima, contAbaixo);
			Console.WriteLine("e {0} tiraram zero em pelo menos um módulo", contZero);
			for (int i2 = 1; i2 < 8; i2++) //exibição dos alunos
			{
				Console.WriteLine();
				for (int i3 = 0; i3 < 3; i3++)
				{
					if (Media[i2] >= mediaGeral)
					{
						Console.Write("O aluno {0} tirou {1} no módulo {2} |", NomeAlunos[i2], Nota[i2, i3], Nota[0, i3] + 1);
						Console.WriteLine("Este aluno ficou acima da média geral");
					}
					if (Media[i2] < mediaGeral)
					{
						Console.Write("O aluno {0} tirou {1} no módulo {2} |", NomeAlunos[i2], Nota[i2, i3], Nota[0, i3] + 1);
						Console.WriteLine("Este aluno ficou abaixo da média geral");
					}
					else if (Media[i2] == 0)
					{
						Console.Write("O aluno {0} tirou {1} no módulo {2} |", NomeAlunos[i2], Nota[i2, i3], Nota[0, i3] + 1);
						Console.WriteLine("Este aluno tirou zero em pelo menos um módulo");
					}
				}
				Console.Write("Sua média foi {0:F2}", Media[i2]);
				Console.WriteLine();
			}
		}
	}
}
