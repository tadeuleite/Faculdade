using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatrizes7
{
	class Program
	{
		static void Main(string[] args)
		{
			//Considere uma matriz 5x5, contendo números
			//Exiba em ordem crescente ( da esquerda para direita e de cima para baixo)

			int[,] Numeros = {  { 10, 12, 15, 14, 13 },
								{ 21, 25, 24, 23, 22 },
								{ 30, 35, 36, 38, 39 },
								{ 42, 44, 43, 45, 49 },
								{ 55, 52, 50, 57, 53 } };

			int[] Organizar = new int[Numeros.Length];

			OrganizarMatriz(Numeros, Organizar);

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					Console.Write("{0} ", Numeros[i, j]);
				}
				Console.WriteLine();
			}
		}
		static void OrganizarMatriz(int[,] matriz, int[] vetor)
		{
			const int tamanhoMatriz = 5;
			int contadorVetor = 0;
			int armazenador = 0;

			for (int x = 0; x < tamanhoMatriz; x++)
			{
				for (int y = 0; y < tamanhoMatriz; y++)
				{
					vetor[contadorVetor] = matriz[x, y];
					contadorVetor++;
				}
			}

			for (int i = 0; i < matriz.Length - 1; i++)
			{
				for (int i2 = i + 1; i2 < matriz.Length; i2++)
				{
					if (vetor[i] > vetor[i2])
					{
						armazenador = vetor[i];
						vetor[i] = vetor[i2];
						vetor[i2] = vetor[i];
					}
				}
			}
			contadorVetor = 0;
			for (int c = 0; c < tamanhoMatriz; c++)
			{
				for (int c2 = 0; c2 < tamanhoMatriz; c2++)
				{
					matriz[c, c2] = vetor[contadorVetor];
					contadorVetor++;
				}
			}
		}
	}
}